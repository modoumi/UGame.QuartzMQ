using EasyNetQ;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Collections;
using TinyFx.Data;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using UGame.Quartz.Service.Services.SReport;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Quartz;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.BasicReport.BankPaytypeWorker
{
    /// <summary>
    /// 每天每个运营商、每个银行每个支付方式的充值用户数和提现用户数以及手续费的统计等job
    /// </summary>
    public class SrBankPaytypeDayJob : JobBase //: BasicReportJobBase<SrBankPaytypeDayJob>
    {
        private readonly Sr_oper_bank_paytype_dayMO _operBankPaytypeDayMo = new();
        //private readonly OperatorDayContext _context;
        protected readonly ILogger<SrBankPaytypeDayJob> _logger;


        /// <summary>
        /// 批量插入的条数
        /// </summary>
        protected const int BATCHCOUNT = 2000;

        //public SrBankPaytypeDayJob(OperatorDayContext context)
        //{
        //    _logger = LogUtil.CreateLogger<SrBankPaytypeDayJob>();
        //    this._context = context;
        //}
        public SrBankPaytypeDayJob()
        {
            _logger = LogUtil.CreateLogger<SrBankPaytypeDayJob>();
        }
        //public async Task Execute()
        //{
        //    try
        //    {
        //        await HandleOperatorBankDay();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"sr_bank_paytype_day.Execute处理出错dayId：{this._context.ReportDate},operatorId:{this._context.OperatorId}");
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task HandleOperatorBankDay(OperatorDayContext context)
        {
            this._logger.LogInformation("开始执行SrBankPaytypeDayJob,dayid:{0},operatorid:{1}",context.ReportDate, context.OperatorId);
            var srStartTime = DateTime.UtcNow;
            var operatorId = context.OperatorId;
            var startDate = context.ReportDate.Date.ToUtcTime(operatorId);
            var endDate = context.ReportDate.Date.AddDays(1).ToUtcTime(operatorId);

            if (null == context.BankOrderEos || !context.BankOrderEos.Any()) return;
            var operatorEo = DbCacheUtil.GetOperator(context.OperatorId);
            var query = context.BankOrderEos.GroupBy(x => new
            {
                x.OperatorID,
                x.BankID,
                x.PaytypeID
            }).Select(g =>
            {
               // var operatorEo = DbCacheUtil.GetOperator(g.Key.OperatorID);
                return new Sr_oper_bank_paytype_dayEO
                {
                    DayID = context.ReportDate.Date,
                    OperatorID = context.OperatorId,
                    BankID = g.Key.BankID,
                    PaytypeID = g.Key.PaytypeID,
                    CountryID = operatorEo.CountryID,
                    CurrencyID = operatorEo.CurrencyID,
                    PayUsers = g.Where(x => x.OrderType == 1).Select(x => x.UserID).Distinct().Count(),
                    PayOwnFee = g.Where(x => x.OrderType == 1).Sum(x => x.OwnFee),
                    PayUserFee = g.Where(x => x.OrderType == 1).Sum(x => x.UserFee),
                    CashUsers = g.Where(x => x.OrderType == 2).Select(x => x.UserID).Distinct().Count(),
                    PayAmount=g.Where(x=>x.OrderType==1).Sum(x=>x.Amount),
                    CashAmount=g.Where(x=>x.OrderType==2).Sum(x=>x.Amount),
                    CashOwnFee = g.Where(x => x.OrderType == 2).Sum(x => x.OwnFee),
                    CashUserFee = g.Where(x => x.OrderType == 2).Sum(x => x.UserFee),
                    RecDate = DateTime.UtcNow
                };
            });

            var tm = new TransactionManager();
            try
            {
                //先清理startdate
                //var rows = await _operBankPaytypeDayMo.RemoveByDayIDAsync(startDate);
                var rows = await _operBankPaytypeDayMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm, context.ReportDate.Date, operatorId);
                //_logger.LogInformation($"sr_bank_paytype_day中成功删除{rows}行");
                await _operBankPaytypeDayMo.AddByBatchAsync(query, BATCHCOUNT, tm);
                tm.Commit();
                var srEndTime = DateTime.UtcNow;
                await MQUtil.PublishAsync(new SRPerDayMsg
                {
                    DayId = startDate,
                    OperatorId= operatorId,
                    SRStartTime = srStartTime,
                    SREndTime = srEndTime,
                    Type = SRPerDayType.SrOperBankPaytypeDay
                });
                _logger.LogInformation("sr_bank_paytype_day处理成功!dayid:{0},operatorid:{1}", context.ReportDate, context.OperatorId);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                _logger.LogError(ex, "sr_bank_paytype_day处理出错!dayid：{0},operatorid:{1}", context.ReportDate, context.OperatorId);
            }
        }

        /// <summary>
        /// 获取sr_oper_day最大dayid
        /// </summary>
        /// <returns></returns>
        protected override async Task<DateTime?> GetMaxDayId(string operatorId)
        {
            var maxDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_operBankPaytypeDayMo.TableName} where OperatorID=@OperatorID order by DayID desc limit 1", operatorId);
            return maxDayId;
        }


        public override async Task Execute(OperatorDayContext context)
        {
            try
            {
                await HandleOperatorBankDay(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"sr_bank_paytype_day.Execute处理出错dayId：{context.ReportDate},operatorId:{context.OperatorId}");
            }
        }

        protected async override Task<DateTime?> GetMinDayId(string operatorId)
        {
            var minDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_operBankPaytypeDayMo.TableName} where OperatorID=@OperatorID order by DayID asc limit 1", operatorId);
            return minDayId;
        }
    }
}
