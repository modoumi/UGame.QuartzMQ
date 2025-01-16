using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.RabbitMQ;

namespace UGame.Quartz.Service.MQMsg
{
    public class SROperatorPerDayMsg
    {
        /// <summary>
        /// 运营商当地日期
        /// </summary>
        public DateTime DayId { get; set; }

        /// <summary>
        /// 开始日期(运营商当地日期)
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 结束日期(运营商当地日期)
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 运营商编号
        /// </summary>
        public string OperatorId { get; set; }
        public string MessageId { get; set; }
        public long Timestamp { get; set; }
        public object MQMeta { get; set; }
    }
}
