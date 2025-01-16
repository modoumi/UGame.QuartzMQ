using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sr_oper_app_dayPO
    {
        #region tinyfx
        public static implicit operator Sr_oper_app_dayEO(Sr_oper_app_dayPO value)
        {
            if (value==null) return null;
            return new Sr_oper_app_dayEO
            {
		        DayId = value.DayId,
		        OperatorID = value.OperatorID,
		        AppID = value.AppID,
		        ProviderID = value.ProviderID,
		        CurrencyID = value.CurrencyID,
		        CountryID = value.CountryID,
		        BetUsers = value.BetUsers,
		        NewBetUsers = value.NewBetUsers,
		        NewUserBetAmount = value.NewUserBetAmount,
		        NewUserWinAmount = value.NewUserWinAmount,
		        NewUserBetBonus = value.NewUserBetBonus,
		        NewUserWinBonus = value.NewUserWinBonus,
		        BetCount = value.BetCount,
		        BetAmount = value.BetAmount,
		        BetBonus = value.BetBonus,
		        WinCount = value.WinCount,
		        WinAmount = value.WinAmount,
		        WinBonus = value.WinBonus,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sr_oper_app_dayPO(Sr_oper_app_dayEO value)
        {
            if (value==null) return null;
            return new Sr_oper_app_dayPO
            {
		        DayId = value.DayId,
		        OperatorID = value.OperatorID,
		        AppID = value.AppID,
		        ProviderID = value.ProviderID,
		        CurrencyID = value.CurrencyID,
		        CountryID = value.CountryID,
		        BetUsers = value.BetUsers,
		        NewBetUsers = value.NewBetUsers,
		        NewUserBetAmount = value.NewUserBetAmount,
		        NewUserWinAmount = value.NewUserWinAmount,
		        NewUserBetBonus = value.NewUserBetBonus,
		        NewUserWinBonus = value.NewUserWinBonus,
		        BetCount = value.BetCount,
		        BetAmount = value.BetAmount,
		        BetBonus = value.BetBonus,
		        WinCount = value.WinCount,
		        WinAmount = value.WinAmount,
		        WinBonus = value.WinBonus,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}