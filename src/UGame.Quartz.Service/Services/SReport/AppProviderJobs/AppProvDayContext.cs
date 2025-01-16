using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.DAL;
using UGame.Quartz.Service.Services.BasicReport;
using UGame.Quartz.Repository;
using Xxyy.Sharding;

namespace UGame.Quartz.Service.Services.SReport.AppProviderJobs
{
    public class AppProvDayContext
    {
        /// <summary>
        /// utc时间
        /// </summary>
        /// <param name="dayId"></param>
        public AppProvDayContext(DateTime dayId)
        {
            ReportDate = dayId;
        }

        /// <summary>
        /// utc时间
        /// </summary>
        public DateTime ReportDate { get; }

        public Dictionary<string, SrAppDayDto> SrAppDayDict { get; set; } = new();
        //public Dictionary<string,HashSet<string>> UserIdsHashSets { get; set; } = new();

        ///// <summary>
        ///// 当日新增的所有下注订单数
        ///// </summary>
        //public List<S_provider_orderEO> ProviderOrderEos { get; set; } = new();
    }
}
