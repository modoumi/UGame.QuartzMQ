using EasyNetQ;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using TinyFx;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using TinyFx.Reflection;
using UGame.Quartz.Service;
using UGame.Quartz.Service.MQMsg;
using UGame.Quartz.Service.Services.BasicReport;
using UGame.Quartz.Service.Services.BasicReport.BankPaytypeWorker;
using UGame.Quartz.Service.Services.BasicReport.OperDayWorker;
using UGame.Quartz.Service.Services.BasicReport.UserDayWorker;
using UGame.Quartz.Service.Services.Sb;
using UGame.Quartz.Service.Services.SReport;
using UGame.Quartz.Service.Services.SReport.AppProviderJobs;
using UGame.Quartz.Service.Services.SReport.OperDayWorker;
using UGame.Quartz.Service.Services.SReport.PromoterWorker;
using Xxyy.Quartz.DAL;
using S_user_dayPO = Xxyy.DAL.S_user_dayPO;

namespace UGame.Quartz.WebAPI.Controllers
{
    public class SbController : QuartzControllerBase
    {
        private SbService _reportSvc = new();

        /// <summary>
        /// 沙巴发送通知
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task Exec(DateTime? date)
        {
            try
            {
                await _reportSvc.Exec(date);
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "执行_basicSvc.sb异常！ipo:{0}", SerializerUtil.SerializeJsonNet(date));
            }
        }
         
       



    }
    }

