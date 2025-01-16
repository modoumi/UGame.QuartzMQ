using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sr_user_betting_hourPO
    {
        #region tinyfx
        public static implicit operator Sr_user_betting_hourEO(Sr_user_betting_hourPO value)
        {
            if (value==null) return null;
            return new Sr_user_betting_hourEO
            {
		        DayId = value.DayId,
		        OperatorID = value.OperatorID,
		        UserCount = value.UserCount,
            };
        }
        public static implicit operator Sr_user_betting_hourPO(Sr_user_betting_hourEO value)
        {
            if (value==null) return null;
            return new Sr_user_betting_hourPO
            {
		        DayId = value.DayId,
		        OperatorID = value.OperatorID,
		        UserCount = value.UserCount,
            };
        }
        #endregion
    }
}