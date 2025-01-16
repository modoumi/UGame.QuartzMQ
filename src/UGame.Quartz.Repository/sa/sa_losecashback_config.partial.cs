using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sa_losecashback_configPO
    {
        #region tinyfx
        public static implicit operator Sa_losecashback_configEO(Sa_losecashback_configPO value)
        {
            if (value==null) return null;
            return new Sa_losecashback_configEO
            {
		        ID = value.ID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RangeMin = value.RangeMin,
		        RangeMax = value.RangeMax,
		        RefundMultiple = value.RefundMultiple,
		        FlowMultip = value.FlowMultip,
		        RefundMax = value.RefundMax,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sa_losecashback_configPO(Sa_losecashback_configEO value)
        {
            if (value==null) return null;
            return new Sa_losecashback_configPO
            {
		        ID = value.ID,
		        OperatorID = value.OperatorID,
		        CountryId = value.CountryId,
		        CurrencyID = value.CurrencyID,
		        RangeMin = value.RangeMin,
		        RangeMax = value.RangeMax,
		        RefundMultiple = value.RefundMultiple,
		        FlowMultip = value.FlowMultip,
		        RefundMax = value.RefundMax,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}