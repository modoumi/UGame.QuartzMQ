using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sr_app_dayPO
    {
        #region tinyfx
        public static implicit operator Sr_app_dayEO(Sr_app_dayPO value)
        {
            if (value==null) return null;
            return new Sr_app_dayEO
            {
		        DayId = value.DayId,
		        AppID = value.AppID,
		        CountryID = value.CountryID,
		        ProviderID = value.ProviderID,
		        CurrencyID = value.CurrencyID,
		        BetUsers = value.BetUsers,
		        BetCount = value.BetCount,
		        BetAmount = value.BetAmount,
		        BetBonus = value.BetBonus,
		        WinCount = value.WinCount,
		        WinAmount = value.WinAmount,
		        WinBonus = value.WinBonus,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sr_app_dayPO(Sr_app_dayEO value)
        {
            if (value==null) return null;
            return new Sr_app_dayPO
            {
		        DayId = value.DayId,
		        AppID = value.AppID,
		        CountryID = value.CountryID,
		        ProviderID = value.ProviderID,
		        CurrencyID = value.CurrencyID,
		        BetUsers = value.BetUsers,
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