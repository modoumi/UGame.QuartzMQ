using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Src_push_configPO
    {
        #region tinyfx
        public static implicit operator Src_push_configEO(Src_push_configPO value)
        {
            if (value==null) return null;
            return new Src_push_configEO
            {
		        CfgID = value.CfgID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        GameTop = value.GameTop,
		        UserTop = value.UserTop,
		        ResetTime = value.ResetTime,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Src_push_configPO(Src_push_configEO value)
        {
            if (value==null) return null;
            return new Src_push_configPO
            {
		        CfgID = value.CfgID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        GameTop = value.GameTop,
		        UserTop = value.UserTop,
		        ResetTime = value.ResetTime,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}