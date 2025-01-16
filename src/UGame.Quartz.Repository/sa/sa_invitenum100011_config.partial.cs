using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sa_invitenum100011_configPO
    {
        #region tinyfx
        public static implicit operator Sa_invitenum100011_configEO(Sa_invitenum100011_configPO value)
        {
            if (value==null) return null;
            return new Sa_invitenum100011_configEO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        UserNumStart = value.UserNumStart,
		        UserNumEnd = value.UserNumEnd,
		        Bonus = value.Bonus,
		        PayCondition = value.PayCondition,
		        FlowMultip = value.FlowMultip,
            };
        }
        public static implicit operator Sa_invitenum100011_configPO(Sa_invitenum100011_configEO value)
        {
            if (value==null) return null;
            return new Sa_invitenum100011_configPO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        UserNumStart = value.UserNumStart,
		        UserNumEnd = value.UserNumEnd,
		        Bonus = value.Bonus,
		        PayCondition = value.PayCondition,
		        FlowMultip = value.FlowMultip,
            };
        }
        #endregion
    }
}