using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Src_push_messagePO
    {
        #region tinyfx
        public static implicit operator Src_push_messageEO(Src_push_messagePO value)
        {
            if (value==null) return null;
            return new Src_push_messageEO
            {
		        MessageID = value.MessageID,
		        SummaryTime = value.SummaryTime,
		        OperatorID = value.OperatorID,
		        SummaryType = value.SummaryType,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        AppID = value.AppID,
		        UserID = value.UserID,
		        ProfitAmount = value.ProfitAmount,
		        LossAmount = value.LossAmount,
		        SumProfit = value.SumProfit,
		        SumLoss = value.SumLoss,
		        RegisterUsers = value.RegisterUsers,
		        BetUsers = value.BetUsers,
		        OrderNum = value.OrderNum,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Src_push_messagePO(Src_push_messageEO value)
        {
            if (value==null) return null;
            return new Src_push_messagePO
            {
		        MessageID = value.MessageID,
		        SummaryTime = value.SummaryTime,
		        OperatorID = value.OperatorID,
		        SummaryType = value.SummaryType,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        AppID = value.AppID,
		        UserID = value.UserID,
		        ProfitAmount = value.ProfitAmount,
		        LossAmount = value.LossAmount,
		        SumProfit = value.SumProfit,
		        SumLoss = value.SumLoss,
		        RegisterUsers = value.RegisterUsers,
		        BetUsers = value.BetUsers,
		        OrderNum = value.OrderNum,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}