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
using System.Numerics;
using System.Security.Cryptography;
using UGame.Quartz.Service.Services.BasicReport;

namespace UGame.Quartz.Service.Services.SReport.OperDayWorker
{
    public class SrOperAppDayJob: JobBase //ISRDayWorker
    {
        private readonly Sr_oper_app_dayMO _appDayMo = new();
        private ILogger<SrOperAppDayJob> _logger;
        private const int BATCHCOUNT = 5000;

        public SrOperAppDayJob()
        {
            _logger = LogUtil.CreateLogger<SrOperAppDayJob>();
            //_context = context;
        }


        public override async Task Execute(OperatorDayContext _context)
        {
            try
            {
                var rows = await _appDayMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", _context.ReportDate.Date, _context.OperatorId);
                //_logger.LogDebug("SrAppDayJob 删除" + rows+"条"+sql);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SrAppDayJob 处理出错：date-{0},operatorId:{1} ,ex:{2}", _context.ReportDate,
                    _context.OperatorId, ex.ToString());
            }
            var tm = new TransactionManager();
            try
            {
                DateTime update=DateTime.UtcNow;
                var countryId = DbCacheUtil.GetCountryByOperatorId(_context.OperatorId);
                
                //获取需要插入的数据
                var res1 = _context.ProviderOrderEos.GroupBy(a =>new { a.AppID,a.ProviderID }).Select(a =>
                {
                   // var providerEo = DbCacheUtil.GetApp(a.Key);
                    return new Sr_oper_app_dayEO
                    {
                        AppID = a.Key.AppID,
                        DayId = _context.ReportDate.Date,
                        ProviderID = a.Key.ProviderID,
                        OperatorID = _context.OperatorId,
                        BetAmount = a.Sum(a1 => a1.PlanBet),
                        WinAmount = a.Sum(a1 => a1.PlanWin),
                        BetBonus = a.Sum(a1 => a1.BetBonus),
                        WinBonus = a.Sum(a1 => a1.WinBonus),
                        CountryID = countryId.CountryID,
                        CurrencyID = countryId.CurrencyID,
                        NewBetUsers = a.Where(x => (x.ReqMark == 1 || x.ReqMark == 3) &&(_context.GetUserDayEo(x.UserID)?.IsRegister??false)).Select(x => x.UserID).Distinct().Count(),
                        NewUserBetAmount = a.Where(x => x.ReqMark != 4&& (_context.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.PlanBet),
                        NewUserBetBonus = a.Where(x => x.ReqMark != 4&& (_context.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.BetBonus),
                        NewUserWinAmount = a.Where(x => x.ReqMark != 4&& (_context.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.PlanWin),
                        NewUserWinBonus = a.Where(x => x.ReqMark != 4&& (_context.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.WinBonus),
                        WinCount = a.Where(x => x.ReqMark == 2 || x.ReqMark == 3).Count(),
                        BetCount = a.Where(x => x.ReqMark == 1 || x.ReqMark == 3).Count(),
                        BetUsers = a.GroupBy(d => d.UserID).Count(),
                        RecDate = update
                    };
                    });
                //清空旧数据
                //var rows = await _appDayMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm,
                //    _context.ReportDate.Date, _context.OperatorId);
                //添加
                int  rows = await _appDayMo.AddByBatchAsync(res1, BATCHCOUNT, tm);
                tm.Commit();
                _logger.LogInformation("SrOperAppDayJob 处理成功!");
            }
            catch (Exception ex)
            {
                tm.Rollback();
                _logger.LogError(ex, "SrOperAppDayJob 处理出错：date-{0},operatorId:{1} ,ex:{2}", _context.ReportDate,
                    _context.OperatorId, ex.ToString());
            }
        }

        /// <summary>
        /// 获取运营商指定某天的最大dayId
        /// </summary>
        /// <returns></returns>
        protected override async Task<DateTime?> GetMaxDayId(string operatorId)
        {
            var maxDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_appDayMo.TableName} where OperatorID=@OperatorID order by DayID desc limit 1", operatorId);
            if (maxDayId >= DateTime.UtcNow.ToLocalTime(operatorId).Date.AddDays(-1))
            {
                return DateTime.UtcNow.ToLocalTime(operatorId).Date.AddDays(-1).AddDays(-1);
            };
            return maxDayId;
        }

        protected async override Task<DateTime?> GetMinDayId(string operatorId)
        {
            var minDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_appDayMo.TableName} where OperatorID=@OperatorID order by DayID asc limit 1", operatorId);
            return minDayId;
        }
    }
}
