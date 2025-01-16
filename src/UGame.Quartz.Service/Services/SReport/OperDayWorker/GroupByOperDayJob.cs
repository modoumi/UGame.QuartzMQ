using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Collections;
using TinyFx.Data;
using TinyFx.Extensions.AutoMapper;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using TinyFx.Reflection;
using UGame.Quartz.Service.Services.SReport;
using UGame.Quartz.Service.Services.SReport.OperDayWorker;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Quartz;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.BasicReport.OperDayWorker
{
    public class GroupByOperDayJob :JobBase//: ISRDayWorker
    {
        //private readonly OperatorDayContext _context;
        private readonly Sr_oper_dayMO _operDayMo = new();
        private readonly Sr_oper_sourcetype_dayMO _operSourceTypeDayMO = new();
        private ILogger<GroupByOperDayJob> _logger;
        private const int BATCHCOUNT = 2000;
        private static readonly int[] DAYS = new[] { -1, -3, -7, -14, -20, -30 };
        private static readonly int[] EXTRAPAYDAYS = new[] { -2,-4,-5,-6};
        private static readonly int[] BETDAYS = new[] { -1 };
        private static readonly IEnumerable<int> GGRDAYS = Enumerable.Range(-29, 30);
        private static readonly IEnumerable<int> GGRDAYS2 = Enumerable.Range(-30, 31);

        public GroupByOperDayJob()
        {
            _logger = LogUtil.CreateLogger<GroupByOperDayJob>();
        }

        public override async Task Execute(OperatorDayContext context)
        {
            this._logger.LogInformation("开始执行GroupByOperDayJob！dayid:{0},operatorid:{1}",context.ReportDate,context.OperatorId);
            //任务开始时间
            var startTime = DateTime.UtcNow;

            var tm = new TransactionManager();
            try
            {
                var operatorEo = DbCacheUtil.GetOperator(context.OperatorId);
                context.GroupKey = context.OperatorId;
                context.FromMode = 0;
                ICalculator calculator = new DayCalculator(context);
                var result = await calculator.Execute();

                 var eo = result.Map<Sr_oper_dayEO>();
                eo.DayID = context.ReportDate.Date;
                eo.OperatorID = context.OperatorId;
                eo.CountryID = operatorEo.CountryID;
                eo.CurrencyID = operatorEo.CurrencyID;

                var (totalCash,totalBonus,totalBalanceCalcTime) =await new UserCalcService().GetTotalBalance(context);
                eo.TotalBalance = totalCash;
                eo.BonusRemainAmount= totalBonus;
                eo.TotalBalanceCalcTime= totalBalanceCalcTime;
                
                var rows = await _operDayMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm, context.ReportDate.Date, context.OperatorId);
                rows = await _operSourceTypeDayMO.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm, context.ReportDate.Date, context.OperatorId);
                
                //设置近30天GGR以及留存率及充值留存率
                 var ggrOperDayEos = await SetGGR(eo);
                if (null != ggrOperDayEos && ggrOperDayEos.Any())
                {
                    SetRetation(eo, ggrOperDayEos);
                    foreach (var ggrOperDayEo in ggrOperDayEos)
                    {
                        rows = await _operDayMo.PutAsync(ggrOperDayEo, tm);
                    }
                }
                //DNU_GGR置零，当天保留
                ResetEoDNU_GGR(eo);
                //当前登录留存率置零、设置充值留存率置零
                ResetEoRetation(eo);
             
                //添加
                rows = await _operDayMo.AddAsync(eo, tm);
                if (null != result.ActivityDict && result.ActivityDict.Any())
                {
                    var operActivityBonusDays = result.ActivityDict.Select(x => new Sr_oper_sourcetype_dayEO
                    {
                        DayID = context.ReportDate.Date,
                        SourceType = x.Key,
                        OperatorID = context.OperatorId,
                        Bonus = x.Value
                    });
                    rows = await _operSourceTypeDayMO.AddByBatchAsync(operActivityBonusDays, BATCHCOUNT, tm);
                }
               
                tm.Commit();
                var endTime = DateTime.UtcNow;
                await MQUtil.PublishAsync(new SRPerDayMsg
                {
                    DayId = context.ReportDate,
                    OperatorId= context.OperatorId,
                    SRStartTime = startTime,
                    SREndTime = endTime,
                    Type = SRPerDayType.SrOperDay
                });

                _logger.LogInformation("GroupByOperDayJob处理成功!dayid:{0},operatorid:{1}",context.ReportDate,context.OperatorId);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                _logger.LogError(ex, "GroupByOperDayJob处理出错!dayid:{0},operatorid:{1}",context.ReportDate,context.OperatorId);
            }
        }

        /// <summary>
        /// 设置留存率（登录留存率和充值留存率）
        /// </summary>
        /// <param name="srOperDayEO"></param>
        /// <param name="srOperDayEos"></param>
        /// <returns></returns>
        private void SetRetation(Sr_oper_dayEO srOperDayEO, IEnumerable<Sr_oper_dayEO> srOperDayEos)
        {
            if (null == srOperDayEos || !srOperDayEos.Any())
                return;
            foreach (var day in DAYS)
            {
               var retation= srOperDayEos.FirstOrDefault(x=> srOperDayEO.DayID.AddDays(day).Date==x.DayID);
               if (null==retation) continue;
                //设置留存率
                ReflectionUtil.SetPropertyValue(retation, $"RetentionD{-day}",ReflectionUtil.GetPropertyValue(srOperDayEO, $"RetentionD{-day}"));
                //设置充值留存率
                ReflectionUtil.SetPropertyValue(retation, $"PayRetentionD{-day}", ReflectionUtil.GetPropertyValue(srOperDayEO, $"PayRetentionD{-day}"));
            }
            //额外的
            foreach (var day in EXTRAPAYDAYS)
            {
                var retation = srOperDayEos.FirstOrDefault(x => srOperDayEO.DayID.AddDays(day).Date == x.DayID);
                if (null == retation) continue;
                //设置充值留存率
                ReflectionUtil.SetPropertyValue(retation, $"PayRetentionD{-day}", ReflectionUtil.GetPropertyValue(srOperDayEO, $"PayRetentionD{-day}"));
            }

            foreach (var day in BETDAYS)
            {
                var retation = srOperDayEos.FirstOrDefault(x => srOperDayEO.DayID.AddDays(day).Date == x.DayID);
                if (null == retation) continue;
                //设置充值留存率
                //下注留存率
                ReflectionUtil.SetPropertyValue(retation, $"BetD{-day}", ReflectionUtil.GetPropertyValue(srOperDayEO, $"BetD{-day}"));
            }
        }

        /// <summary>
        /// 获取sr_oper_day最大dayid
        /// </summary>
        /// <returns></returns>
        protected override async Task<DateTime?> GetMaxDayId(string operatorId)
        {
            var maxDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_operDayMo.TableName} where OperatorID=@OperatorID order by DayID desc limit 1", operatorId);
            return maxDayId;
        }

        protected async override Task<DateTime?> GetMinDayId(string operatorId)
        {
            var minDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_operDayMo.TableName} where OperatorID=@OperatorID order by DayID asc limit 1", operatorId);
            return minDayId;
        }

        /// <summary>
        /// 获取近31(因ggr统计从0开始算，Retation从1开始算)天待设置GGR的统计列表
        /// </summary>
        /// <returns></returns>
        private async Task<List<Sr_oper_dayEO>> GetGGRSrOperDayEoList(DateTime dayId,string operatorId)
        {
            var dayIds = GGRDAYS2.Select(x => dayId.Date.AddDays(x).ToString("yyyy-MM-dd"));
            return await _operDayMo.GetAsync($"DayID in ('{string.Join("','", dayIds)}') and OperatorID='{operatorId}'");
        }

        /// <summary>
        /// 设置近30天真金GGR
        /// </summary>
        /// <param name="srOperDayEO"></param>
        /// <returns></returns>
        private async Task<List<Sr_oper_dayEO>> SetGGR(Sr_oper_dayEO srOperDayEO)
        {
            var ggrOperDayEos = await GetGGRSrOperDayEoList(srOperDayEO.DayID,srOperDayEO.OperatorID);
            if (null == ggrOperDayEos || !ggrOperDayEos.Any())
                return null;
            foreach (var day in GGRDAYS)
            {
                var ggrOperDayEo = ggrOperDayEos.FirstOrDefault(x => srOperDayEO.DayID.AddDays(day).Date == x.DayID);
                if (null == ggrOperDayEo) continue;
                //设置dnu_ggr
                ReflectionUtil.SetPropertyValue(ggrOperDayEo, $"DNU_GGR{-day + 1}", ReflectionUtil.GetPropertyValue(srOperDayEO, $"DNU_GGR{-day + 1}"));
            }
            return ggrOperDayEos;
        }

        /// <summary>
        /// 留存率和充值留存率重置为0
        /// </summary>
        /// <param name="eo"></param>
        private void ResetEoRetation(Sr_oper_dayEO eo)
        {
            foreach (var day in DAYS)
            {
                //当前登录留存率置零
                ReflectionUtil.SetPropertyValue(eo, $"RetentionD{-day}", 0f);
                //设置充值留存率置零
                ReflectionUtil.SetPropertyValue(eo, $"PayRetentionD{-day}", 0f);
            }
            foreach (var day in EXTRAPAYDAYS)
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

        /// <summary>
        /// DNU_GGR重置为0
        /// </summary>
        /// <param name="eo"></param>
        private void ResetEoDNU_GGR(Sr_oper_dayEO eo)
        {
            foreach (var day in GGRDAYS)
            {
                //DNU_GGR置零，当天保留
                if (day != 0)
                {
                    ReflectionUtil.SetPropertyValue(eo, $"DNU_GGR{-day + 1}", 0l);
                }
            }
        }

    }
}
