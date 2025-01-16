using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sa_invite100013_configPO
    {
        #region tinyfx
        public static implicit operator Sa_invite100013_configEO(Sa_invite100013_configPO value)
        {
            if (value==null) return null;
            return new Sa_invite100013_configEO
            {
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        PayLimit = value.PayLimit,
		        BetLimit = value.BetLimit,
		        BetType = value.BetType,
		        FlowMultip = value.FlowMultip,
            };
        }
        public static implicit operator Sa_invite100013_configPO(Sa_invite100013_configEO value)
        {
            if (value==null) return null;
            return new Sa_invite100013_configPO
            {
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        PayLimit = value.PayLimit,
		        BetLimit = value.BetLimit,
		        BetType = value.BetType,
		        FlowMultip = value.FlowMultip,
            };
        }
        #endregion
    }
}