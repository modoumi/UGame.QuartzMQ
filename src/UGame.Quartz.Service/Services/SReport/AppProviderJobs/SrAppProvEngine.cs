using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Logging;
using UGame.Quartz.Service.MQMsg;
using Xxyy.DAL;
using UGame.Quartz.Service.Services.BasicReport;
using UGame.Quartz.Service.Services.BasicReport.BankPaytypeWorker;
using Xxyy.Sharding;

namespace UGame.Quartz.Service.Services.SReport.AppProviderJobs
{
    public class SrAppProvEngine
    {

        public SRAppProvPerDayMsg Msg { get; }

        /// <summary>
        /// 每页条数
        /// </summary>
        protected const int PAGESIZE = 10000;

        public SrAppProvEngine(SRAppProvPerDayMsg msg)
        {
            Msg = msg;
        }

        public async Task Execute()
        {
            var appDayJob = new SrAppDayJob();
            var (appStartDate, appEndDate) = await appDayJob.CalcStartEndDate(this.Msg.StartDate, this.Msg.EndDate);

            var provDayJob = new SrProvDayJob();
            var (provStartDate, provEndDate) = await provDayJob.CalcStartEndDate(this.Msg.StartDate, this.Msg.EndDate);

            var startDate = new List<DateTime> { appStartDate, provStartDate }.Where(x => x != DateTime.MinValue).OrderBy(x => x).FirstOrDefault();

            var endDate = new List<DateTime> { appEndDate, provEndDate }.Where(x => x != DateTime.MinValue).OrderByDescending(x => x).FirstOrDefault();

            if (startDate == DateTime.MinValue || endDate == DateTime.MinValue || startDate > endDate)
            {
                LogUtil.Info($"startDate：{startDate}或endDate:{endDate}无效,退出！");
                return;
            }
                

            //构造job sorteddictionary
            var jobDict = new SortedDictionary<DateTime, List<AppProvJobBase>>();
            var totalDays = endDate.Subtract(startDate).TotalDays;
            for (var i = 0; i <= totalDays; i++)
            {
                var dayId = startDate.AddDays(i);
                //appjob
                if (appStartDate <= dayId && appEndDate >= dayId)
                {
                    if (jobDict.TryGetValue(dayId, out var jobList))
                        jobList.Add(appDayJob);
                    else
                        jobDict.Add(dayId, new List<AppProvJobBase> { appDayJob });
                }
                //provDayJob
                if (provStartDate <= dayId && provEndDate >= dayId)
                {
                    if (jobDict.TryGetValue(dayId, out var jobList))
                        jobList.Add(provDayJob);
                    else
                        jobDict.Add(dayId, new List<AppProvJobBase> { provDayJob });
                }
            }
            //execute
            if (jobDict.Any())
            {
                foreach (var jobItem in jobDict)
                {
                    //var context = await (new AppProvContextBuilder(jobItem.Key).InitContextData());
                    var context = new AppProvDayContext(jobItem.Key);
                    foreach (var job in jobItem.Value)
                    {
                        await job.Execute(context);
                    }
                }
            }
        }
    }
}
