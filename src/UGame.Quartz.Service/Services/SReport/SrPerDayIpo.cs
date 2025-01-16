using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.BasicReport
{
    /// <summary>
    /// 每日基础统计ipo
    /// </summary>
    public class SrPerDayIpo
    {
        /// <summary>
        /// 指定某一天兼容历史遗留
        /// </summary>
        public DateTime? reportDate { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OperatorId { get; set; }
    }

    public class SrPerHourIpo: SrPerDayIpo
    {

    }
}
