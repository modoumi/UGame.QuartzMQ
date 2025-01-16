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
using UGame.Quartz.Service.Services.BasicReport;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.SReport.AppProviderJobs
{
    public class SrProvDayJob : AppProvJobBase
    {
        private readonly Sr_prov_dayMO _srProvDayMo = new();
        private ILogger<SrAppDayJob> _logger;
        private const int BATCHCOUNT = 5000;
        public SrProvDayJob()
        {
            _logger = LogUtil.CreateLogger<SrAppDayJob>();
        }
        public override async Task Execute(AppProvDayContext context)
        {
            //任务开始时间
            var utcNow = DateTime.UtcNow;
            if (context.SrAppDayDict.Count == 0)
            {
                this._logger.LogInformation("context.srappdaydict字典数据为空，退出执行！dayid:{0}",context.ReportDate);
                return;
            }
            this._logger.LogInformation("开始执行SrAppDayJob,dayId:{0}",context.ReportDate);
            var tm = new TransactionManager();
            try
            {
                var rows=await _srProvDayMo.RemoveByDayIdAsync(context.ReportDate,tm);
                var srProvDayEos = context.SrAppDayDict.Values.GroupBy(x => new { x.ProviderID, x.CountryID, x.CurrencyID }).Select(x =>
                {
                    return new Sr_prov_dayEO
                    {
                        DayId = context.ReportDate,
                        ProviderID = x.Key.ProviderID,
                        CountryID = x.Key.CountryID,
                        CurrencyID = x.Key.CurrencyID,
                        BetUsers = x.SelectMany(o=>o.UserIdsHashSet).ToHashSet().Count(),
                        BetCount = x.Sum(o => o.BetCount),
                        BetAmount = x.Sum(o => o.BetAmount),
                        BetBonus = x.Sum(o => o.BetBonus),
                        WinCount = x.Sum(o => o.WinCount),
                        WinAmount = x.Sum(o => o.WinAmount),
                        WinBonus = x.Sum(o => o.WinBonus),
                        RecDate = utcNow
                    };
                });
                rows = await _srProvDayMo.AddByBatchAsync(srProvDayEos, BATCHCOUNT, tm);
                tm.Commit();
                this._logger.LogInformation("SrProvDayJob执行完成！dayid:{0}",context.ReportDate);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                this._logger.LogError(ex, "SrProvDayJob统计出错！dayId:{0}",context.ReportDate);
            }
        }

        protected override async Task<DateTime?> GetMaxDayId()
        {
            var maxDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_srProvDayMo.TableName} order by DayID desc limit 1");
            return maxDayId;
        }

        protected override async Task<DateTime?> GetMinDayId()
        {
            var minDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_srProvDayMo.TableName} order by DayID asc limit 1");
            return minDayId;
        }
    }
}
