using Microsoft.Extensions.Logging;
using TinyFx.Data;
using TinyFx.Logging;
using Xxyy.Common;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.PayReport
{
    public class PayReportService
    {
        private Sb_bank_orderMO _sbbBankMO = new();
        private Sr_pay_dayMO _pay_DayMO = new();
        private ILogger<PayReportService> _logger;

        public PayReportService()
        {
            _logger = LogUtil.CreateLogger<PayReportService>();
        }

        public async Task<bool> Execute(PayReportIpo ipo)
        {
            // 当前日期
            var _dayId = DateTime.UtcNow.ToLocalTime(ipo.OperatorID).AddDays(-1).Date;

            if (null != ipo.Date && ipo.Date.Value != DateTime.MinValue)
                _dayId = ipo.Date.Value.Date;

            var startTime = _dayId.ToUtcTime(ipo.OperatorID).Date;
            var endTime = _dayId.AddDays(1).ToUtcTime(ipo.OperatorID).Date;

            var where = " RecDate>=@StartTime and RecDate<=@EndTime AND OperatorID=@OperatorID AND UserKind = 1 ";
            var paramters = new List<object>() { startTime, endTime, ipo.OperatorID };
            _sbbBankMO.UseReadConnectionString= true;
            var sbOrders = await _sbbBankMO.GetAsync(where, paramters.ToArray());

            var groupPay = sbOrders.Where(w => w.OrderType == 1).GroupBy(x => new { x.BankID, x.OperatorID, x.CurrencyID });

            var payDayEos = groupPay.Select(w =>
            {
                // 充值
                var payTotal = w.Where(t => t.OrderType == 1).Sum(t => t.Amount);
                var paySuccesOrderNum = w.Where(t => t.OrderType == 1 && t.Status == 2).Count();
                var orderTotalNum = w.Count();
                var paySuccessRate = paySuccesOrderNum / (w.Count() == 0 ? 1 : w.Count());
                var payOwnFee = (long)w.Where(t => t.OrderType == 1).Sum(t => t.OwnFee);
                var payAverage = payTotal / (paySuccesOrderNum == 0 ? 1 : paySuccesOrderNum);

                // 提现
                var cashTotal = w.Where(t => t.OrderType == 2).Sum(t => t.Amount);
                var cashSuccesOrderNum = w.Where(t => t.OrderType == 2).Count();
                var cashUserFee = (long)w.Where(t => t.OrderType == 2).Sum(t => t.UserFee);

                return new Sr_pay_dayEO
                {
                    DayID = _dayId,
                    CurrencyID = w.Key.CurrencyID,
                    BankID = w.Key.BankID,
                    OperatorID = ipo.OperatorID,
                    PayTotal = payTotal,
                    OrderTotalNum = orderTotalNum,
                    PaySuccesOrderNum = paySuccesOrderNum,
                    PaySuccessRate = paySuccessRate,
                    PayOwnFee = payOwnFee,
                    PayAverage = payAverage,
                    CashTotal = cashTotal,
                    CashSuccesOrderNum = cashSuccesOrderNum,
                    CashUserFee = cashUserFee,
                    MerchantInventory = (long)(payTotal - cashTotal - payOwnFee)
                };
            }).ToList();

            var tm = new TransactionManager();
            try
            {
                await _pay_DayMO.RemoveAsync("DayId = @DayId", tm, _dayId.Date);
                await _pay_DayMO.AddByBatchAsync(payDayEos, payDayEos.Count(), tm);

                tm.Commit();
                return true;

            }
            catch (Exception ex)
            {
                tm.Rollback();
                _logger.LogError(ex, $"sr_pay_day处理出错：{_dayId}");
                return false;
            }
        }
    }
}
