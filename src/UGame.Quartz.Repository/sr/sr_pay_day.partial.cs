using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sr_pay_dayPO
    {
        #region tinyfx
        public static implicit operator Sr_pay_dayEO(Sr_pay_dayPO value)
        {
            if (value==null) return null;
            return new Sr_pay_dayEO
            {
		        DayID = value.DayID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        BankID = value.BankID,
		        PayTotal = value.PayTotal,
		        OrderTotalNum = value.OrderTotalNum,
		        PaySuccesOrderNum = value.PaySuccesOrderNum,
		        PaySuccessRate = value.PaySuccessRate,
		        PayOwnFee = value.PayOwnFee,
		        PayAverage = value.PayAverage,
		        CashTotal = value.CashTotal,
		        CashSuccesOrderNum = value.CashSuccesOrderNum,
		        CashUserFee = value.CashUserFee,
		        MerchantInventory = value.MerchantInventory,
            };
        }
        public static implicit operator Sr_pay_dayPO(Sr_pay_dayEO value)
        {
            if (value==null) return null;
            return new Sr_pay_dayPO
            {
		        DayID = value.DayID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        BankID = value.BankID,
		        PayTotal = value.PayTotal,
		        OrderTotalNum = value.OrderTotalNum,
		        PaySuccesOrderNum = value.PaySuccesOrderNum,
		        PaySuccessRate = value.PaySuccessRate,
		        PayOwnFee = value.PayOwnFee,
		        PayAverage = value.PayAverage,
		        CashTotal = value.CashTotal,
		        CashSuccesOrderNum = value.CashSuccesOrderNum,
		        CashUserFee = value.CashUserFee,
		        MerchantInventory = value.MerchantInventory,
            };
        }
        #endregion
    }
}