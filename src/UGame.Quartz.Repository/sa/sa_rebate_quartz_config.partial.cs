using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sa_rebate_quartz_configPO
    {
        #region tinyfx
        public static implicit operator Sa_rebate_quartz_configEO(Sa_rebate_quartz_configPO value)
        {
            if (value==null) return null;
            return new Sa_rebate_quartz_configEO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        ActivityID = value.ActivityID,
		        CountryID = value.CountryID,
		        RewardRatio = value.RewardRatio,
		        MinAmount = value.MinAmount,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
		        AmountType = value.AmountType,
            };
        }
        public static implicit operator Sa_rebate_quartz_configPO(Sa_rebate_quartz_configEO value)
        {
            if (value==null) return null;
            return new Sa_rebate_quartz_configPO
            {
		        ConfigID = value.ConfigID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        ActivityID = value.ActivityID,
		        CountryID = value.CountryID,
		        RewardRatio = value.RewardRatio,
		        MinAmount = value.MinAmount,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
		        AmountType = value.AmountType,
            };
        }
        #endregion
    }
}