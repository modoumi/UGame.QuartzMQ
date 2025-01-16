using Microsoft.AspNetCore.Mvc;
using TinyFx;
using TinyFx.AspNet;
using UGame.Quartz.Service.Services.BasicReport;
using UGame.Quartz.Service.Services.SReport;
using UGame.Quartz.Service.Services.SReport.AppProviderJobs;
using UGame.Quartz.Service.Services.SReport.OperDayWorker;

namespace UGame.Quartz.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [IgnoreActionFilter]
    public class QuartzControllerBase:ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="errorMsg"></param>
        /// <exception cref="CustomException"></exception>
        protected void ThrowIfEmpty(string param,string errorMsg)
        {
            if (string.IsNullOrWhiteSpace(param))
                throw new CustomException(errorMsg);
        }

        /// <summary>
        /// 执行job
        /// </summary>
        /// <param name="job"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        protected async Task ExecuteJob(JobBase job,DateTime? startDate,DateTime? endDate,string operatorId)
        {
            var (jobStartDate, jobEndDate) = await job.CalcStartEndDate(startDate, endDate, operatorId);
            if (jobStartDate == DateTime.MinValue || jobEndDate == DateTime.MinValue)
                throw new CustomException($"未获取到有效的日期！startDate：{jobStartDate}和endDate:{jobEndDate}");
            if (jobStartDate > jobEndDate)
                throw new CustomException($"startDate:{jobStartDate}不能大于endDate:{jobEndDate}");

            var totalDays = jobEndDate.Subtract(jobStartDate).TotalDays;
            for (var i = 0; i <= totalDays; i++)
            {
                var dayId = jobStartDate.AddDays(i);
                var context = await new OperatorDayContextBuilder(operatorId, dayId).InitContextData();
                await job.Execute(context);
            }
        }

        /// <summary>
        /// 执行job
        /// </summary>
        /// <param name="job"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        protected async Task ExecuteJob(AppProvJobBase job, DateTime? startDate, DateTime? endDate)
        {
            var (jobStartDate, jobEndDate) = await job.CalcStartEndDate(startDate, endDate);
            if (jobStartDate == DateTime.MinValue || jobEndDate == DateTime.MinValue)
                throw new CustomException($"未获取到有效的日期！startDate：{jobStartDate}和endDate:{jobEndDate}");
            if (jobStartDate > jobEndDate)
                throw new CustomException($"startDate:{jobStartDate}不能大于endDate:{jobEndDate}");

            var totalDays = jobEndDate.Subtract(jobStartDate).TotalDays;
            for (var i = 0; i <= totalDays; i++)
            {
                var dayId = jobStartDate.AddDays(i);
                //var context = await new AppProvContextBuilder(dayId).InitContextData();
                var context = new AppProvDayContext(dayId);
                await job.Execute(context);
            }
        }

        protected async Task ExecuteJob(DateTime? startDate, DateTime? endDate, string operatorId, params JobBase[] joblist)
        {
            //var (jobStartDate, jobEndDate) = await job.CalcStartEndDate(startDate, endDate, operatorId);
            //if (jobStartDate == DateTime.MinValue || jobEndDate == DateTime.MinValue)
            //    throw new CustomException($"未获取到有效的日期！startDate：{jobStartDate}和endDate:{jobEndDate}");
            if (endDate == null || startDate == null || endDate.Value < startDate.Value)
                throw new CustomException($"无效的日期startDate:{startDate},endDate:{endDate}");

            var totalDays = endDate.Value.Subtract(startDate.Value).TotalDays;
            for (var i = 0; i <= totalDays; i++)
            {
                var dayId = startDate.Value.AddDays(i);
                var context = await new OperatorDayContextBuilder(operatorId, dayId).InitContextData();
                foreach (var job in joblist)
                {
                    await job.Execute(context);
                }
            }
        }
    }
}
