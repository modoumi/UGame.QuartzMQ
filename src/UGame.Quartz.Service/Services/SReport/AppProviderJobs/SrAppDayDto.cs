using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.SReport.AppProviderJobs
{
    public class SrAppDayDto: Sr_app_dayEO
    {
        /// <summary>
        /// 用户id字典  key--dayid|appid|countryid
        /// </summary>
        public HashSet<string> UserIdsHashSet { get; set; }
    }
}
