using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sa_invitenum100013_configPO
    {
        #region tinyfx
        public static implicit operator Sa_invitenum100013_configEO(Sa_invitenum100013_configPO value)
        {
            if (value==null) return null;
            return new Sa_invitenum100013_configEO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        ValidQuantity = value.ValidQuantity,
		        OrderNum = value.OrderNum,
		        Bonus = value.Bonus,
            };
        }
        public static implicit operator Sa_invitenum100013_configPO(Sa_invitenum100013_configEO value)
        {
            if (value==null) return null;
            return new Sa_invitenum100013_configPO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        ValidQuantity = value.ValidQuantity,
		        OrderNum = value.OrderNum,
		        Bonus = value.Bonus,
            };
        }
        #endregion
    }
}