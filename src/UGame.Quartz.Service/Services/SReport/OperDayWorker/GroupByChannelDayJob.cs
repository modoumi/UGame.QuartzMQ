using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using TinyFx;
using Xxyy.Common.Caching;
using Xxyy.MQ.Quartz;
using UGame.Quartz.Service.Services.BasicReport.OperDayWorker;
using UGame.Quartz.Repository;
using Microsoft.Extensions.Logging;
using TinyFx.Data;
using TinyFx.Extensions.AutoMapper;
using Xxyy.DAL;
using Xxyy.Common;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using TinyFx.Reflection;
using UGame.Quartz.Service.Services.BasicReport;

namespace UGame.Quartz.Service.Services.SReport.OperDayWorker
{
    public class GroupByChannelDayJob : JobBase//ISRDayWorker
    {
        //private OperatorDayContext _context;
        private readonly Sr_channel_dayMO _channelDayMo = new();
        private readonly Sr_channel_sourcetype_dayMO _channelSouceTypeDayMO = new();
        private ILogger<GroupByChannelDayJob> _logger;
        private const int BATCHCOUNT = 2000;
        private static readonly int[] DAYS = new[] { -1, -3, -7, -14, -20, -30 };
        private static readonly int[] EXTRADAYS = new[] { -2, -4,-5,-6};
        private static readonly int[] BETDAYS = new[] { -1 };
        private static readonly IEnumerable<int> GGRDAYS = Enumerable.Range(-29, 30);
        private static readonly IEnumerable<int> GGRDAYS2 = Enumerable.Range(-30, 31);

        public GroupByChannelDayJob()
        {
            _logger = LogUtil.CreateLogger<GroupByChannelDayJob>();
            //_context = context;
            //_context.FromMode = 2;
        }

        //public GroupByChannelDayJob(OperatorDayContext context)
        //{
        //    _logger = LogUtil.CreateLogger<GroupByChannelDayJob>();
        //    _context = context;
        //    _context.FromMode = 2;
        //}

        public override async Task Execute(OperatorDayContext _context)
        {
            _context.FromMode = 2;
            var startTime = DateTime.UtcNow;
            var tm = new TransactionManager();
            try
            {
                 this._logger.LogInformation("开始执行GroupByChannelDayJob！dayid:{0},operatorid:{1}", _context.ReportDate,_context.OperatorId);

                //过滤frommode=2并按照ChannelId分组
                var userDayEos = _context.UserDayEos?.Where(x => x.FromMode == 2&&!string.IsNullOrWhiteSpace(x.FromId)).GroupBy(x => x.FromId).ToDictionary(g => g.Key, g => g.ToList())
                   ?? new Dictionary<string, List<Repository.S_user_dayEO>>();

                var providerOrderEos = _context.ProviderOrderEos?.Where(x => x.FromMode == 2 && !string.IsNullOrWhiteSpace(x.FromId)).GroupBy(x => x.FromId).ToDictionary(g => g.Key, g => g.ToList())
                    ?? new Dictionary<string, List<S_provider_orderEO>>();

                var bankOrderEos = _context.BankOrderEos?.Where(x => x.FromMode == 2 && !string.IsNullOrWhiteSpace(x.FromId)).GroupBy(x => x.FromId).ToDictionary(g => g.Key, g => g.ToList ())
                    ?? new Dictionary<string, List<Sb_bank_orderEO>>();

                var currencyChangeEos = _context.CurrencyChangeEos?.Where(x => x.FromMode == 2 && !string.IsNullOrWhiteSpace(x.FromId)).GroupBy(x => x.FromId).ToDictionary(g => g.Key, g => g.ToList())
                    ?? new Dictionary<string, List<S_currency_changeEO>>();

                var cashAuditEos = _context.CashAuditEos?.Where(x => x.FromMode == 2 && !string.IsNullOrWhiteSpace(x.FromId)).GroupBy(x => x.FromId).ToDictionary(g => g.Key, g => g.ToList())
                    ?? new Dictionary<string, List<Sc_cash_auditEO>>();

                var requireFlowOrderEos = _context.RequireFlowOrderEos?.Where(x => x.FromMode == 2 && !string.IsNullOrWhiteSpace(x.FromId)).GroupBy(x => x.FromId).ToDictionary(g => g.Key, g => g.ToList())
                    ?? new Dictionary<string, List<Xxyy.DAL.S_requireflow_orderEO>>();

                ICalculator calculator = null;
                DayCalculatorDto result = null;
               
                var channelDayEos = new List<Sr_channel_dayEO>();
                var srChannelActivityBonusDayEOs = new List<Sr_channel_sourcetype_dayEO>();

                 var channelList = userDayEos.Keys.Concat(providerOrderEos.Keys).Concat(bankOrderEos.Keys).Concat(currencyChangeEos.Keys).Concat(cashAuditEos.Keys).Concat(requireFlowOrderEos.Keys).Distinct();
                //_context.FromMode = 2;
                //BasicReportContext contextCopy = (BasicReportContext)_context.Clone();
                foreach (var channelId in channelList)
                {
                    var contextCopy = new OperatorDayContext(_context.ReportDate, _context.OperatorId);
                    contextCopy.FromMode = 2;
                    contextCopy.UserDayEos = userDayEos.GetValueOrDefault(channelId, new List<Repository.S_user_dayEO>());
                    contextCopy.ProviderOrderEos = providerOrderEos.GetValueOrDefault(channelId, new List<S_provider_orderEO>());
                    contextCopy.CurrencyChangeEos = currencyChangeEos.GetValueOrDefault(channelId,new List<S_currency_changeEO>());
                    contextCopy.BankOrderEos = bankOrderEos.GetValueOrDefault(channelId,new List<Sb_bank_orderEO>());

                    contextCopy.CashAuditEos = cashAuditEos.GetValueOrDefault(channelId,new List<Sc_cash_auditEO>());
                    contextCopy.RequireFlowOrderEos = requireFlowOrderEos.GetValueOrDefault(channelId,new List<Xxyy.DAL.S_requireflow_orderEO>());


                    contextCopy.GroupKey = channelId;
                    //_context.FromMode=2;
                    calculator = new DayCalculator(contextCopy);
                    result = await calculator.Execute();
                    var eo = result.Map<Sr_channel_dayEO>();
                    eo.DayID = _context.ReportDate.Date;
                    eo.ChannelID = channelId;
                    eo.OperatorID = _context.OperatorId;
                    var (totalCash, totalBonus,totalBalanceCalcTime) = await new UserCalcService().GetTotalBalance(contextCopy);
                    eo.TotalBalance = totalCash;
                    eo.BonusRemainAmount = totalBonus;
                    eo.TotalBalanceCalcTime = totalBalanceCalcTime;
                    channelDayEos.Add(eo);
                    if(result.ActivityDict!=null&&result.ActivityDict.Any())
                    {
                        srChannelActivityBonusDayEOs.AddRange(result.ActivityDict.Select(x => new Sr_channel_sourcetype_dayEO
                        {
                            DayID = _context.ReportDate.Date,
                            ChannelID = channelId,
                            SourceType = x.Key,
                            OperatorID = _context.OperatorId,
                            Bonus = x.Value
                        }));
                    }
                }

                if (channelDayEos.Count == 0)
                {
                    tm.Rollback();
                    return;
                }
                var rows = await _channelDayMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm, _context.ReportDate.Date, _context.OperatorId);

                rows = await _channelSouceTypeDayMO.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm, _context.ReportDate.Date, _context.OperatorId);

                //设置近30天GGR以及留存率及充值留存率
                var ggrChannelDayEos = await SetGGR(channelDayEos,_context.ReportDate,_context.OperatorId);
                if (null != ggrChannelDayEos && ggrChannelDayEos.Any())
                {
                    SetRetation(channelDayEos, ggrChannelDayEos,_context.ReportDate);
                    foreach (var ggrOperDayEo in ggrChannelDayEos)
                    {
                        rows = await _channelDayMo.PutAsync(ggrOperDayEo, tm);
                    }
                }
                foreach (var eo in channelDayEos)
                {
                    ResetEoRetation(eo);
                    ResetEoDNU_GGR(eo);
                }
                //添加
                rows = await _channelDayMo.AddByBatchAsync(channelDayEos, BATCHCOUNT, tm);

                if (srChannelActivityBonusDayEOs.Any())
                {
                    rows = await _channelSouceTypeDayMO.AddByBatchAsync(srChannelActivityBonusDayEOs, BATCHCOUNT, tm);
                }

                tm.Commit();

                _logger.LogInformation("GroupByChannelDayJob处理成功!dayid:{0},operatorid:{1}",_context.ReportDate,_context.OperatorId);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                _logger.LogError(ex, "GroupByChannelDayJob处理出错：date-{0},operatorId:{1}",_context.ReportDate,_context.OperatorId);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="srChannelDayEos"></param>
        /// <param name="srGGRChannelDayEos"></param>
        /// <param name="reportDate"></param>
        /// <returns></returns>
        private void SetRetation(IEnumerable<Sr_channel_dayEO> srChannelDayEos, IEnumerable<Sr_channel_dayEO> srGGRChannelDayEos, DateTime reportDate)
        {
            if (null == srGGRChannelDayEos || !srGGRChannelDayEos.Any())
                return;

            foreach (var channelEo in srChannelDayEos)
            {
                foreach (var day in DAYS)
                {
                    var retation = srGGRChannelDayEos.FirstOrDefault(x => reportDate.AddDays(day).Date == x.DayID&&x.ChannelID==channelEo.ChannelID);
                    if (null == retation) continue;
                    //设置留存率
                    ReflectionUtil.SetPropertyValue(retation, $"RetentionD{-day}", ReflectionUtil.GetPropertyValue(channelEo, $"RetentionD{-day}"));
                    //设置充值留存率
                    ReflectionUtil.SetPropertyValue(retation, $"PayRetentionD{-day}", ReflectionUtil.GetPropertyValue(channelEo, $"PayRetentionD{-day}"));
                }
                foreach (var day in EXTRADAYS)
                {
                    var retation = srGGRChannelDayEos.FirstOrDefault(x => reportDate.AddDays(day).Date == x.DayID && x.ChannelID == channelEo.ChannelID);
                    if (null == retation) continue;
                    //设置充值留存率
                    ReflectionUtil.SetPropertyValue(retation, $"PayRetentionD{-day}", ReflectionUtil.GetPropertyValue(channelEo, $"PayRetentionD{-day}"));
                }

                foreach (var day in BETDAYS)
                {
                    var retation = srGGRChannelDayEos.FirstOrDefault(x => reportDate.AddDays(day).Date == x.DayID && x.ChannelID == channelEo.ChannelID);
                    if (null == retation) continue;
                    //设置充值留存率
                    ReflectionUtil.SetPropertyValue(retation, $"BetD{-day}", ReflectionUtil.GetPropertyValue(channelEo, $"BetD{-day}"));
                }
            }
        }

        ///// <summary>
        ///// 获取留存列表
        ///// </summary>
        ///// <returns></returns>
        //private async Task<IEnumerable<Sr_channel_dayEO>> GetRetationEoList(DateTime reportDate,string operatorId)
        //{
        //    var dayIds = DAYS.Select(x => reportDate.Date.AddDays(x).ToString("yyyy-MM-dd"));
        //    return await _channelDayMo.GetAsync($"DayID in ('{string.Join("','", dayIds)}') and OperatorID='{operatorId}'");
        //}

        /// <summary>
        /// 获取sr_channel_day最大dayid
        /// </summary>
        /// <returns></returns>
        protected override async Task<DateTime?> GetMaxDayId(string operatorId)
        {
            var maxDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_channelDayMo.TableName} where OperatorID=@OperatorID order by DayID desc limit 1", operatorId);
            return maxDayId;
        }

        protected async override Task<DateTime?> GetMinDayId(string operatorId)
        {
            var minDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_channelDayMo.TableName} where OperatorID=@OperatorID order by DayID asc limit 1", operatorId);
            return minDayId;
        }

        /// <summary>
        /// 获取近30天待设置GGR的统计列表
        /// </summary>
        /// <returns></returns>
        private async Task<List<Sr_channel_dayEO>> GetGGRSrChannelDayEoList(DateTime reportDate,string operatorId)
        {
            var dayIds = GGRDAYS2.Select(x => reportDate.Date.AddDays(x).ToString("yyyy-MM-dd"));
            return await _channelDayMo.GetAsync($"DayID in ('{string.Join("','", dayIds)}') and OperatorID='{operatorId}'");
        }

        /// <summary>
        /// 设置近30天真金GGR
        /// </summary>
        /// <param name="srChannelDayEos">待添加的渠道统计eos</param>
        /// <param name="reportDate"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        private async Task<List<Sr_channel_dayEO>> SetGGR(IEnumerable<Sr_channel_dayEO> srChannelDayEos,DateTime reportDate,string operatorId)
        {
            var ggrChannelDayEos = await GetGGRSrChannelDayEoList(reportDate,operatorId);
            if (null == ggrChannelDayEos || !ggrChannelDayEos.Any())
                return null;
            foreach (var channelEo in srChannelDayEos)
            {
                foreach (var day in GGRDAYS)
                {
                    var ggrChannelDayEo = ggrChannelDayEos.FirstOrDefault(x => reportDate.AddDays(day).Date == x.DayID && x.ChannelID == channelEo.ChannelID);
                    if (null == ggrChannelDayEo) continue;
                    //设置GGR
                    ReflectionUtil.SetPropertyValue(ggrChannelDayEo, $"DNU_GGR{-day + 1}", ReflectionUtil.GetPropertyValue(ggrChannelDayEo, $"DNU_GGR{-day + 1}"));
                }
            }
            return ggrChannelDayEos;
        }

        /// <summary>
        /// 留存率和充值留存率重置为0
        /// </summary>
        /// <param name="eo"></param>
        private void ResetEoRetation(Sr_channel_dayEO eo)
        {
            foreach (var day in GGRDAYS)
            {
                //DNU_GGR置零，当天保留
                if (day != 0)
                {
                    ReflectionUtil.SetPropertyValue(eo, $"DNU_GGR{-day + 1}", 0L);
                }
            }
        }

        /// <summary>
        /// DNU_GGR重置为0
        /// </summary>
        /// <param name="eo"></param>
        private void ResetEoDNU_GGR(Sr_channel_dayEO eo)
        {
            foreach (var day in DAYS)
            {
                //当前登录留存率置零
                ReflectionUtil.SetPropertyValue(eo, $"RetentionD{-day}", 0f);
                //设置充值留存率置零
                ReflectionUtil.SetPropertyValue(eo, $"PayRetentionD{-day}", 0f);
            }
            foreach (var day in EXTRADAYS)
            {
                //设置充值留存率置零
                ReflectionUtil.SetPropertyValue(eo, $"PayRetentionD{-day}", 0f);
            }

            foreach (var day in BETDAYS)
            {
                //下注留存率
                ReflectionUtil.SetPropertyValue(eo, $"BetD{-day}", 0f);
            }
        }
    }
}
