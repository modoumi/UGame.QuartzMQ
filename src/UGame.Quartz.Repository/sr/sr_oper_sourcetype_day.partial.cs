using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sr_oper_sourcetype_dayPO
    {
        #region tinyfx
        public static implicit operator Sr_oper_sourcetype_dayEO(Sr_oper_sourcetype_dayPO value)
        {
            if (value==null) return null;
            return new Sr_oper_sourcetype_dayEO
            {
		        DayID = value.DayID,
		        SourceType = value.SourceType,
		        OperatorID = value.OperatorID,
		        Bonus = value.Bonus,
            };
        }
        public static implicit operator Sr_oper_sourcetype_dayPO(Sr_oper_sourcetype_dayEO value)
        {
            if (value==null) return null;
            return new Sr_oper_sourcetype_dayPO
            {
		        DayID = value.DayID,
		        SourceType = value.SourceType,
		        OperatorID = value.OperatorID,
		        Bonus = value.Bonus,
            };
        }
        #endregion
    }
}