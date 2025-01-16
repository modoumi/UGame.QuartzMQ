using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sr_oper_bank_paytype_dayPO
    {
        #region tinyfx
        public static implicit operator Sr_oper_bank_paytype_dayEO(Sr_oper_bank_paytype_dayPO value)
        {
            if (value==null) return null;
            return new Sr_oper_bank_paytype_dayEO
            {
		        DayID = value.DayID,
		        OperatorID = value.OperatorID,
		        BankID = value.BankID,
		        PaytypeID = value.PaytypeID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        PayUsers = value.PayUsers,
		        CashUsers = value.CashUsers,
		        PayOwnFee = value.PayOwnFee,
		        PayUserFee = value.PayUserFee,
		        PayAmount = value.PayAmount,
		        CashAmount = value.CashAmount,
		        CashOwnFee = value.CashOwnFee,
		        CashUserFee = value.CashUserFee,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sr_oper_bank_paytype_dayPO(Sr_oper_bank_paytype_dayEO value)
        {
            if (value==null) return null;
            return new Sr_oper_bank_paytype_dayPO
            {
		        DayID = value.DayID,
		        OperatorID = value.OperatorID,
		        BankID = value.BankID,
		        PaytypeID = value.PaytypeID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        PayUsers = value.PayUsers,
		        CashUsers = value.CashUsers,
		        PayOwnFee = value.PayOwnFee,
		        PayUserFee = value.PayUserFee,
		        PayAmount = value.PayAmount,
		        CashAmount = value.CashAmount,
		        CashOwnFee = value.CashOwnFee,
		        CashUserFee = value.CashUserFee,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}