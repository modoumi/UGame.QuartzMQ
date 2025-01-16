using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class L_activity_basePO
    {
        #region tinyfx
        public static implicit operator L_activity_baseEO(L_activity_basePO value)
        {
            if (value==null) return null;
            return new L_activity_baseEO
            {
		        ActivityID = value.ActivityID,
		        Name = value.Name,
            };
        }
        public static implicit operator L_activity_basePO(L_activity_baseEO value)
        {
            if (value==null) return null;
            return new L_activity_basePO
            {
		        ActivityID = value.ActivityID,
		        Name = value.Name,
            };
        }
        #endregion
    }
}