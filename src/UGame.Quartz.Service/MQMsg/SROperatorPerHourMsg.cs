using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.MQMsg
{
    public class SROperatorPerHourMsg
    {

        /// <summary>运营商当地日期</summary>
        public DateTime ReportDate { get; set; }

        /// <summary>运营商编号</summary>
        public string OperatorId { get; set; }
        public string MessageId { get; set; }
        public long Timestamp { get; set; }
        public object MQMeta { get; set; }
    }
}
