using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.RabbitMQ;

namespace UGame.Quartz.Service.MQMsg
{
    public class SRAppProvPerDayMsg
    {

        /// <summary>
        /// 开始日期utc
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 结束日期utc
        /// </summary>
        public DateTime? EndDate { get; set; }
        public string MessageId { get; set; }
        public long Timestamp { get; set; }
        public object MQMeta { get; set; }
    }
}
