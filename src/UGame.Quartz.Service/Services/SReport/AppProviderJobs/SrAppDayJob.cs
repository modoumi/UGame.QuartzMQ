using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Data;
using TinyFx.Logging;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using UGame.Quartz.Service.Services.BasicReport;
using UGame.Quartz.Service.Services.BasicReport.OperDayWorker;
using UGame.Quartz.Repository;
using Xxyy.Sharding;

namespace UGame.Quartz.Service.Services.SReport.AppProviderJobs
{
    public class SrAppDayJob : AppProvJobBase
    {
        private readonly Sr_app_dayMO _srAppDayMo = new();
        private ILogger<SrAppDayJob> _logger;
        private const int BATCHCOUNT = 5000;
        private AppProvDayContext _context;
        private const int PAGESIZE =10000;
        public SrAppDayJob()
        {
            _logger = LogUtil.CreateLogger<SrAppDayJob>();
        }
        public override async Task Execute(AppProvDayContext context)
        {
            this._context = context;
            this._logger.LogInformation("开始执行SrAppDayJob!dayid:{0}",context.ReportDate);
           
            try
            {
                //初始化加载sr_app_day字典
                this._context.SrAppDayDict = await this.InitSrAppDayEosDict();
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, "执行InitSrAppDayEosDict加载srappdaydict异常");
                this._context.SrAppDayDict?.Clear();
                return;
            }
            if (_context.SrAppDayDict.Count == 0)
            {
                _logger.LogInformation($"_context.srappdaydict字典数据为空，退出执行！");
                return;
            }
            var tm = new TransactionManager();
            try
            {
                var rows = await _srAppDayMo.RemoveByDayIdAsync(context.ReportDate, tm);
                rows = await _srAppDayMo.AddByBatchAsync(context.SrAppDayDict.Values.Select(x => new Sr_app_dayEO
                {
                    DayId = x.DayId,
                    AppID = x.AppID,
                    CountryID = x.CountryID,
                    ProviderID= x.ProviderID,
                    CurrencyID = x.CurrencyID,
                    BetUsers=x.BetUsers,
                    BetCount=x.BetCount,
                    BetAmount=x.BetAmount,
                    BetBonus=x.BetBonus,
                    WinCount=x.WinCount,
                    WinAmount=x.WinAmount,
                    WinBonus=x.WinBonus,
                    RecDate=x.RecDate
                }), BATCHCOUNT, tm);
                tm.Commit();
                this._logger.LogInformation("SrAppDayJob执行完成,dayid:{0}",context.ReportDate);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                this._logger.LogError(ex, "SrAppDayJob统计插入sr_app_day表出错！dayId:{0}", _context.ReportDate);
            }
        }

        /// <summary>
        /// 获取sr_oper_day最大dayid
        /// </summary>
        /// <returns></returns>
        protected override async Task<DateTime?> GetMaxDayId()
        {
            var maxDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_srAppDayMo.TableName} order by DayID desc limit 1");
            return maxDayId;
        }

        protected async override Task<DateTime?> GetMinDayId()
        {
            var minDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_srAppDayMo.TableName} order by DayID asc limit 1");
            return minDayId;
        }

        /// <summary>
        /// 获取sr_app_dayeo字典
        /// </summary>
        /// <returns></returns>
        private async Task<Dictionary<string,SrAppDayDto>> InitSrAppDayEosDict()
        {
            var utcNow = DateTime.UtcNow;
            var dict = new Dictionary<string, SrAppDayDto>();
            //_context.SrAppDayDict = dict;
            //dayId,appid,countryid
            Dictionary<string, HashSet<string>> userIdsDict = new();
            var startDate = _context.ReportDate;
            var endDate = _context.ReportDate.AddDays(1);
            var providerOrderMo = new S_provider_orderMO();
            providerOrderMo.UseReadConnectionString= true;
            try
            {
                var dataTables = await new SProviderOrderService().GetTableNames(new ProviderOrderFilter
                {
                    BeginUtcDate = startDate,
                    EndUtcDate = endDate
                });
                dataTables.Add("s_sb_order");

                foreach (var datatable in dataTables)
                {
                    providerOrderMo.TableName = datatable;
                    var pageCount = await providerOrderMo.GetPageCountAsync(PAGESIZE, $" RecDate>=@startDate and RecDate<@endDate and ReqMark!=4 and Status =2 and CurrencyType=9" + (datatable == "s_sb_order" ? " and IsFree=0" : ""), values: new object[] { startDate, endDate });
                    if (pageCount == 0) continue;

                    //List<S_provider_orderEO> providerOrders;
                    for (var page = 1; page <= pageCount; page++)
                    {
                        var providerOrders = await providerOrderMo.GetPagerListAsync(PAGESIZE, page, "RecDate>=@startDate and RecDate<@endDate and ReqMark!=4 and Status =2 and CurrencyType=9" + (datatable == "s_sb_order" ? " and IsFree=0" : ""), "OrderId", startDate, endDate);
                        if (null == providerOrders || !providerOrders.Any())
                            continue;

                        foreach (var item in providerOrders)
                        {
                            var tempOrder = item;
                            var dictKey = $"{tempOrder.AppID}|{tempOrder.CountryID}";
                            if (userIdsDict.ContainsKey(dictKey))
                            {
                                userIdsDict[dictKey].Add(tempOrder.UserID);
                            }
                            else
                            {
                                var userIds = new HashSet<string>();
                                userIds.Add(tempOrder.UserID);
                                userIdsDict.TryAdd(dictKey, userIds);
                            }
                            if (dict.ContainsKey(dictKey))
                            {
                                var eo = dict[dictKey];
                                eo.BetUsers = userIdsDict[dictKey].Count;
                                eo.BetCount += ((tempOrder.ReqMark == 1 || tempOrder.ReqMark == 3) ? 1 : 0);
                                eo.BetAmount += tempOrder.PlanBet;
                                eo.BetBonus += tempOrder.BetBonus;
                                eo.WinCount += ((tempOrder.ReqMark == 2 || tempOrder.ReqMark == 3) ? 1 : 0);
                                eo.WinAmount += tempOrder.PlanWin;
                                eo.WinBonus += tempOrder.WinBonus;
                                //eo.UserIdsHashSet = userIdsDict[dictKey];
                            }
                            else
                            {
                                dict.Add(dictKey, new SrAppDayDto
                                {
                                    DayId = _context.ReportDate,
                                    AppID = tempOrder.AppID,
                                    CountryID = tempOrder.CountryID,
                                    ProviderID = tempOrder .ProviderID,
                                    CurrencyID = tempOrder.CurrencyID,
                                    BetUsers = userIdsDict[dictKey].Count,
                                    BetCount = ((tempOrder.ReqMark == 1 || tempOrder .ReqMark == 3) ? 1 : 0),
                                    BetAmount = tempOrder.PlanBet,
                                    BetBonus = tempOrder.BetBonus,
                                    WinCount = ((item.ReqMark == 2 || tempOrder.ReqMark == 3) ? 1 : 0),
                                    WinAmount = tempOrder.PlanWin,
                                    WinBonus = tempOrder.WinBonus,
                                    RecDate = utcNow,
                                    UserIdsHashSet = userIdsDict[dictKey]
                                });
                            }
                        }
                        await Task.Delay(1000);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"初始化加载srappdaydict字典异常！dayId:{_context.ReportDate}");
            }
            return dict;
        }
    }
}
