using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sr_user_settl_dayPO
    {
        #region tinyfx
        public static implicit operator Sr_user_settl_dayEO(Sr_user_settl_dayPO value)
        {
            if (value==null) return null;
            return new Sr_user_settl_dayEO
            {
		        UserID = value.UserID,
		        CurrencyID = value.CurrencyID,
		        SumDay = value.SumDay,
		        BatchID = value.BatchID,
		        BetSum = value.BetSum,
		        WinSum = value.WinSum,
		        AmountSum = value.AmountSum,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sr_user_settl_dayPO(Sr_user_settl_dayEO value)
        {
            if (value==null) return null;
            return new Sr_user_settl_dayPO
            {
		        UserID = value.UserID,
		        CurrencyID = value.CurrencyID,
		        SumDay = value.SumDay,
		        BatchID = value.BatchID,
		        BetSum = value.BetSum,
		        WinSum = value.WinSum,
		        AmountSum = value.AmountSum,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}