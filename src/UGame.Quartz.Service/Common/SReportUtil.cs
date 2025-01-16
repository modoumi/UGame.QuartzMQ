using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.Quartz.Service.Services.BasicReport;
using UGame.Quartz.Service.Services.SReport;

namespace UGame.Quartz.Service.Common
{
    public static class SReportUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public static IEnumerable<UserLastEndBalanceBonusDto> GetUserLastEndBalanceBonus(this IDayCalculatorIpo ipo)
        {
            var bankOrderBalanceAndBonus = ipo.BankOrderEos.GroupBy(x => x.UserID).Select(g =>
            {
                var lastOrder = g.OrderByDescending(x => x.BankCallbackTime).Last();
                return new UserLastEndBalanceBonusDto { UserId = g.Key, LastTime = lastOrder.BankCallbackTime, EndBalance = lastOrder.EndBalance, EndBonus = lastOrder.EndBonus };
            }) ?? new List<UserLastEndBalanceBonusDto>();

            var providerOrderBalanceAndBonus = ipo.ProviderOrderEos.GroupBy(x => x.UserID).Select(g =>
            {
                var lastOrder = g.OrderByDescending(x => x.ResponseTime).Last();
                return new UserLastEndBalanceBonusDto { UserId = g.Key, LastTime = lastOrder.ResponseTime, EndBalance = lastOrder.EndBalance, EndBonus = lastOrder.EndBonus };
            }) ?? new List<UserLastEndBalanceBonusDto>();

            var currencyChangeBalanceAndBonus = ipo.CurrencyChangeEos.GroupBy(x => x.UserID).Select(g =>
            {
                var lastOrder = g.OrderByDescending(x => x.DealTime).Last();
                return new UserLastEndBalanceBonusDto { UserId = g.Key, LastTime = lastOrder.DealTime, EndBalance = lastOrder.EndBalance, EndBonus = lastOrder.EndBonus };
            }) ?? new List<UserLastEndBalanceBonusDto>();


            var result = bankOrderBalanceAndBonus.Concat(providerOrderBalanceAndBonus).Concat(currencyChangeBalanceAndBonus).GroupBy(x => x.UserId, (userId, g) => g.OrderByDescending(o => o.LastTime).First());
            return result;
        }
    }
}
