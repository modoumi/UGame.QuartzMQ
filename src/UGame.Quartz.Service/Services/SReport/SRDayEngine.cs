using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Logging;
using TinyFx;
using Xxyy.Common;
using Xxyy.MQ.Quartz;
using UGame.Quartz.Repository;
using System.Drawing.Printing;
using Xxyy.MQ.Xxyy;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Xxyy.DAL;
using EasyNetQ;
using UGame.Quartz.Service.Common;
using UGame.Quartz.Service.MQMsg;
using UGame.Quartz.Service.Services.BasicReport.BankPaytypeWorker;
using UGame.Quartz.Service.Services.BasicReport.OperDayWorker;
using UGame.Quartz.Service.Services.BasicReport.UserDayWorker;
using UGame.Quartz.Service.Services.DingTalk;
using UGame.Quartz.Service.Services.SReport;
using UGame.Quartz.Service.Services.SReport.OperDayWorker;
using UGame.Quartz.Service.Services.SReport.PromoterWorker;
using UGame.Quartz.Service.Caching;
using Xxyy.Sharding;

namespace UGame.Quartz.Service.Services.BasicReport
{
    public class SRDayEngine
    {

        private readonly SROperatorPerDayMsg _msg;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public SRDayEngine(SROperatorPerDayMsg msg)
        {
            this._msg = msg;
            //_context = new OperatorDayContext(msg.DayId, msg.OperatorId);
        }

        public async Task Execute(string operatorId)
         {
            var srAppDayJob = new SrOperAppDayJob();
            var (appStartDate, appEndDate) =await srAppDayJob.CalcStartEndDate(this._msg.StartDate,this._msg.EndDate,operatorId);

            var srBankPaytypeDayJob = new SrBankPaytypeDayJob();
            var (bankPaytypeStartDate, bankPaytypeEndDate) = await srBankPaytypeDayJob.CalcStartEndDate(this._msg.StartDate, this._msg.EndDate, operatorId);

            var sRUserDayJob = new SRUserDayJob();
            var (userStartDate, userEndDate) = await sRUserDayJob.CalcStartEndDate(this._msg.StartDate, this._msg.EndDate,operatorId);

            var groupByOperDayJob = new GroupByOperDayJob();
             var(operStartDate,operEndDate) = await groupByOperDayJob.CalcStartEndDate(this._msg.StartDate, this._msg.EndDate,operatorId);

            var groupByChannelDayJob = new GroupByChannelDayJob();
             var(channelStartDate,channelEndDate) = await groupByChannelDayJob.CalcStartEndDate(this._msg.StartDate,this._msg.EndDate,operatorId);

            var sfPromoterPerfDayJob = new SfPromoterPerfDayJob();
            var(promoterStartDate,promoterEndDate) = await sfPromoterPerfDayJob.CalcStartEndDate(this._msg.StartDate, this._msg.EndDate, operatorId);

            var startDate = new List<DateTime> { appStartDate,bankPaytypeStartDate, userStartDate, operStartDate, channelStartDate, promoterStartDate }.Where(x=>x!=DateTime.MinValue).OrderBy(x=>x).FirstOrDefault();

            var endDate = new List<DateTime> { appEndDate, bankPaytypeEndDate, userEndDate, operEndDate, channelEndDate, promoterEndDate }.Where(x => x != DateTime.MinValue).OrderByDescending(x=>x).FirstOrDefault();

            if(startDate==DateTime.MinValue||endDate==DateTime.MinValue||startDate>endDate)
              return;

            //构造job sorteddictionary
            var jobDict = new SortedDictionary<DateTime, List<JobBase>>();
            var totalDays = endDate.Subtract(startDate).TotalDays;
            for (var i=0;i<=totalDays;i++)
            {
                var dayId = startDate.AddDays(i);
                //appjob
                if (appStartDate <= dayId && appEndDate >= dayId)
                {
                    if (jobDict.TryGetValue(dayId, out var jobList))
                        jobList.Add(srAppDayJob);
                    else
                        jobDict.Add(dayId, new List<JobBase> { srAppDayJob });
                }
                //srBankPaytypeDayJob
                if (bankPaytypeStartDate <= dayId && bankPaytypeEndDate >= dayId)
                {
                    if (jobDict.TryGetValue(dayId, out var jobList))
                        jobList.Add(srBankPaytypeDayJob);
                    else
                        jobDict.Add(dayId, new List<JobBase> { srBankPaytypeDayJob });
                }
                //sRUserDayJob
                if (userStartDate <= dayId && userEndDate >= dayId)
                {
                    if (jobDict.TryGetValue(dayId, out var jobList))
                        jobList.Add(sRUserDayJob);
                    else
                        jobDict.Add(dayId, new List<JobBase> { sRUserDayJob });
                }
                //groupByOperDayJob
                if (operStartDate <= dayId && operEndDate >= dayId)
                {
                    if (jobDict.TryGetValue(dayId, out var jobList))
                        jobList.Add(groupByOperDayJob);
                    else
                        jobDict.Add(dayId, new List<JobBase> { groupByOperDayJob });
                }
                //groupByChannelDayJob
                if (channelStartDate <= dayId && channelEndDate >= dayId)
                {

                    if (jobDict.TryGetValue(dayId, out var jobList))
                        jobList.Add(groupByChannelDayJob);
                    else
                        jobDict.Add(dayId, new List<JobBase> { groupByChannelDayJob });
                }
                //sfPromoterPerfDayJob
                if (promoterStartDate <= dayId && promoterEndDate >= dayId)
                {
                    if (jobDict.TryGetValue(dayId, out var jobList))
                        jobList.Add(sfPromoterPerfDayJob);
                    else
                        jobDict.Add(dayId, new List<JobBase> { sfPromoterPerfDayJob });
                }
            }
            //execute
            if(jobDict.Any())
            {
                foreach (var jobItem in jobDict)
                {
                    var context = await (new OperatorDayContextBuilder(operatorId,jobItem.Key).InitContextData());
                    foreach (var job in jobItem.Value)
                    {
                        await job.Execute(context);
                    }
                }
            }
        }

        private async Task SendDingTalkDay()
        {
            var _dingTalkService = new DingTalkService();

            var operatorId = this._msg.OperatorId;
            var startDate = DateTime.UtcNow.ToLocalTime(this._msg.OperatorId).AddDays(-1).Date;
            var endDate = startDate.AddDays(1).Date;
            //发送钉钉消息
            var request = new DingTalkIpo()
            {
                operatorId = operatorId,
                startTime = startDate,
                endTime = endDate,
                ReportType = DingTalkReportType.EveryDay
            };
            try
            {
                await _dingTalkService.LoadDingTalkDay(request);
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "跑完srdayengine发送钉钉每日消息异常！");
            }
        }
    }
}
