using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sr_prov_dayPO
    {
        #region tinyfx
        public static implicit operator Sr_prov_dayEO(Sr_prov_dayPO value)
        {
            if (value==null) return null;
            return new Sr_prov_dayEO
            {
		        DayId = value.DayId,
		        ProviderID = value.ProviderID,
		        CountryID = value.CountryID,
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
        public static implicit operator Sr_prov_dayPO(Sr_prov_dayEO value)
        {
            if (value==null) return null;
            return new Sr_prov_dayPO
            {
		        DayId = value.DayId,
		        ProviderID = value.ProviderID,
		        CountryID = value.CountryID,
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