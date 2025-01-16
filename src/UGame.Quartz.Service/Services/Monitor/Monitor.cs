using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Xxyy.Common;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.Monitor
{
    public class Monitor
    {
        private readonly S_currency_changeMO currencyChangeMo = new S_currency_changeMO();
        private readonly Sb_bank_orderMO _sbBankOrderMo = new Sb_bank_orderMO();

        private readonly Sat_itemMO _itemMo = new Sat_itemMO();
        private readonly L_activity_baseMO _activityBaseMo = new L_activity_baseMO();

        //每小时增长率阈值
        private readonly decimal LimitIncreaseRateAmount = 100;
        //private readonly decimal LimitNewAcitiveAmount = 5000;//活动总
        //每小时新活动阈值
        private readonly decimal LimitAmount = 2000;//活动限额

        //总活动和直提限制
        private readonly decimal LimitTotalRateAmount = 100;
        //总活动和直提限制
        private readonly decimal LimitTotalAmount = 3000;




        public Dictionary<string, string> MonitorCurrencyChange(string countryId,DateTime todayUtcStart,DateTime todayUtcEnd)
        {
            var dateUtcNow= DateTime.UtcNow;
            //var todayLocalCountry = dateUtcNow.ToLocalTimeByCountryId(countryId);
            //var yesterdayLocalCountry = todayLocalCountry.AddDays(-1);
            //var yesterdayUtc = dateUtcNow.ToUtcTimeByCountryId(countryId);

            //var yesterdayUtc = dateUtcNow.AddDays(-1);
            //var yesterdayUtcStart = yesterdayUtc.Minute>=30 ? new DateTime(yesterdayUtc.Year,yesterdayUtc.Month,yesterdayUtc.Day,yesterdayUtc.Hour,0,0): new DateTime(yesterdayUtc.Year, yesterdayUtc.Month, yesterdayUtc.Day, yesterdayUtc.Hour-1, 30, 0);
            //var yesterdayUtcEnd = yesterdayUtc.Minute >= 30 ? new DateTime(yesterdayUtc.Year, yesterdayUtc.Month, yesterdayUtc.Day, yesterdayUtc.Hour, 29, 59) : new DateTime(yesterdayUtc.Year, yesterdayUtc.Month, yesterdayUtc.Day, yesterdayUtc.Hour - 1, 59, 59);

            var activityName1 = _itemMo.GetAll().Select(a => new L_activity_baseEO() { ActivityID = a.SourceTypeID, Name = a.Name }).ToList();
            var activityName2 = _activityBaseMo.GetAll();
            var activityName = activityName1.Union(activityName2).ToList();


            //var todayUtcStart = dateUtcNow.Minute >= 30 ? new DateTime(dateUtcNow.Year, dateUtcNow.Month, dateUtcNow.Day, dateUtcNow.Hour, 0, 0) : new DateTime(dateUtcNow.Year, dateUtcNow.Month, dateUtcNow.Day, dateUtcNow.Hour - 1, 30, 0);
            //var todayUtcEnd = dateUtcNow.Minute >= 30 ? new DateTime(dateUtcNow.Year, dateUtcNow.Month, dateUtcNow.Day, dateUtcNow.Hour, 29, 59) : new DateTime(dateUtcNow.Year, dateUtcNow.Month, dateUtcNow.Day, dateUtcNow.Hour - 1, 59, 59);

            var yesterdayDatas =
                currencyChangeMo.Get($" DealTime>=@startDate and DealTime<=@endDate and SourceType  not in ('300002','2','300001') and UserKind=1 and Status=2",
                    values: new object[] { todayUtcStart.AddDays(-1), todayUtcEnd.AddDays(-1) });

            var todayDatas =
                currencyChangeMo.Get($" DealTime>=@startDate and DealTime<=@endDate and SourceType  not in ('300002','2','300001') and UserKind=1 and Status=2",
                    values: new object[] { todayUtcStart, todayUtcEnd });

          var yesterdayAmountDatas= yesterdayDatas.GroupBy(c => c.SourceType).Select(a=> new {
                SourceType = a.Key,
                Amount = a.Sum(c => c.Amount).AToMByCountryId(countryId)
            }).ToList();

          var todaydayAmountDatas = todayDatas.GroupBy(c => c.SourceType).Select(a => new {
              SourceType = a.Key,
              Amount = a.Sum(c => c.Amount).AToMByCountryId(countryId)
          }).ToList();

          //新增的活动，昨天不存在
          var newAcitive = todaydayAmountDatas.Where(c => !yesterdayAmountDatas.Select(a => a.SourceType).ToArray().Contains(c.SourceType) && c.Amount >= LimitAmount).ToDictionary(c => c.SourceType.ToString(),c=>c.Amount.ToString());

          foreach (var yestmpData in yesterdayAmountDatas)
          {
              var todaytmpData = todaydayAmountDatas.FirstOrDefault(c => c.SourceType == yestmpData.SourceType);
              if (todaytmpData != null)
              {
                  string acName = activityName.FirstOrDefault(c => c.ActivityID == yestmpData.SourceType) == null
                      ? yestmpData.SourceType.ToString()
                      : activityName.FirstOrDefault(c => c.ActivityID == yestmpData.SourceType).Name;

                  if (todaytmpData.Amount == 0)
                  {
                      newAcitive.Add(acName, "无数据");
                  }
                  else
                  {
                      var increaseRateAmount = (todaytmpData.Amount - yestmpData.Amount) / todaytmpData.Amount * 100;
                      if (Math.Abs(increaseRateAmount) >= LimitIncreaseRateAmount&&todaytmpData.Amount> LimitAmount)
                      {
                          newAcitive.Add(acName, increaseRateAmount.ToString("0.00") + "%"+",当前小时段的金额"+ todaytmpData.Amount+"/昨天同时段金额" + yestmpData.Amount);
                      }
                  }

              }
          }

          var totalRateAmount = (todaydayAmountDatas.Sum(c=>c.Amount) - yesterdayAmountDatas.Sum(c=>c.Amount)) / todaydayAmountDatas.Sum(c => c.Amount) * 100;
          if (Math.Abs(totalRateAmount) >= LimitTotalRateAmount && todaydayAmountDatas.Sum(c => c.Amount) >= LimitTotalAmount)
          {
              newAcitive.Add("活动总赠送金额", totalRateAmount.ToString("0.00") + "%"+",当前小时段金额"+ todaydayAmountDatas.Sum(c => c.Amount)+"昨天同时段金额" + yesterdayAmountDatas.Sum(c => c.Amount));
          }

          //newAcitive.Add("查询时间段UTC", todayUtcStart.ToString("yyyy-MM-dd HH:mm:ss")+"  "+ todayUtcEnd.ToString("yyyy-MM-dd HH:mm:ss"));
            //newAcitive.Add("查询时间段北京", todayUtcStart.AddHours(8).ToString("yyyy-MM-dd HH:mm:ss") + "  " + todayUtcEnd.AddHours(8).ToString("yyyy-MM-dd HH:mm:ss"));
            //newAcitive.Add("查询时间段当地", todayUtcStart.ToLocalTimeByCountryId(countryId).ToString("yyyy-MM-dd HH:mm:ss") + "  " + todayUtcEnd.ToLocalTimeByCountryId(countryId).ToString("yyyy-MM-dd HH:mm:ss"));
            return newAcitive;
        }

        public Dictionary<string, string> MonitorBank(string countryId,DateTime todayUtcStart, DateTime todayUtcEnd)
        {
            Dictionary<string,string> dictionary= new Dictionary<string, string>();

            //var dateUtcNow = DateTime.UtcNow;
 
            //var todayUtcStart = dateUtcNow.Minute >= 30 ? new DateTime(dateUtcNow.Year, dateUtcNow.Month, dateUtcNow.Day, dateUtcNow.Hour, 0, 0) : new DateTime(dateUtcNow.Year, dateUtcNow.Month, dateUtcNow.Day, dateUtcNow.Hour - 1, 30, 0);
            //var todayUtcEnd = dateUtcNow.Minute >= 30 ? new DateTime(dateUtcNow.Year, dateUtcNow.Month, dateUtcNow.Day, dateUtcNow.Hour, 29, 59) : new DateTime(dateUtcNow.Year, dateUtcNow.Month, dateUtcNow.Day, dateUtcNow.Hour - 1, 59, 59);

            var yesterdayDatas =
                _sbBankOrderMo.Get($" BankCallbackTime>=@startDate and BankCallbackTime<=@endDate and UserKind=1 and Status=2",
                    values: new object[] { todayUtcStart.AddDays(-1), todayUtcEnd.AddDays(-1) });

            var todayDatas =
                _sbBankOrderMo.Get($" BankCallbackTime>=@startDate and BankCallbackTime<=@endDate and UserKind=1 and Status=2",
                    values: new object[] { todayUtcStart, todayUtcEnd });

            var yesterdayAmountDatas = yesterdayDatas.GroupBy(c => c.OrderType).Select(a => new {
                OrderType = a.Key,
                Amount = a.Sum(c => c.Amount).AToMByCountryId(countryId)
            }).ToList();

            var todaydayAmountDatas = todayDatas.GroupBy(c => c.OrderType).Select(a => new {
                OrderType = a.Key,
                Amount = a.Sum(c => c.Amount).AToMByCountryId(countryId)
            }).ToList();

          

            var yesterdayAmountDataPay = yesterdayAmountDatas.Where(c => c.OrderType == 1).Sum(c => c.Amount);
            var todaydayAmountDataPay = todaydayAmountDatas.Where(c => c.OrderType == 1).Sum(c => c.Amount);
            var todaydayAmountDataPayRate =
                ((todaydayAmountDataPay - yesterdayAmountDataPay) / todaydayAmountDataPay * 100);
            if (todaydayAmountDataPayRate >=
                LimitIncreaseRateAmount)
            {
                dictionary.Add("充值订单", todaydayAmountDataPayRate.ToString("0.00") + "%"+ ",当前小时段充值金额" + todaydayAmountDataPay + "昨天同时段金额" + yesterdayAmountDataPay);
            }

            var yesterdayDatasAudit = Math.Abs(yesterdayDatas.Where(c => !c.IsAuditOrder).Sum(c => c.Amount).AToMByCountryId(countryId));
            var todayDatasAudit = Math.Abs(todayDatas.Where(c => !c.IsAuditOrder).Sum(c => c.Amount).AToMByCountryId(countryId));

            if (todayDatasAudit == 0)
            {
                dictionary.Add("直接提现订单", "无数据");
            }
            else
            {
                var auditRate = (todayDatasAudit - yesterdayDatasAudit) / todayDatasAudit * 100;
                if (Math.Abs(auditRate) >= LimitTotalRateAmount&& Math.Abs(todayDatasAudit) >= LimitTotalAmount)
                {
                    dictionary.Add("直接提现订单", auditRate.ToString("0.00") + "%"+",当前小时段提现金额"+ todayDatasAudit+"昨天同时段金额"+ yesterdayDatasAudit);
                }
            }

            return dictionary;
        }
    }
}
