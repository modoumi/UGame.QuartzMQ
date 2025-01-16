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
using UGame.Quartz.Service.Services.BasicReport.BankPaytypeWorker;
using UGame.Quartz.Service.Services.BasicReport.OperDayWorker;
using UGame.Quartz.Service.Services.BasicReport.UserDayWorker;
using UGame.Quartz.Repository;
using System.Drawing.Printing;
using Xxyy.MQ.Xxyy;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UGame.Quartz.Service.Services.SReport.OperHourWorker;
using Xxyy.DAL;
using UGame.Quartz.Service.Services.SReport.OperDayWorker;
using UGame.Quartz.Service.Services.MQConsumers;

namespace UGame.Quartz.Service.Services.BasicReport
{
    internal interface ISRHourWorker
    {
        Task Execute();
    }
    internal class SRHourContext
    {

    }
    /// <summary>
    /// 下注用户数 按照小时统计
    /// </summary>
    public class SRHourEngine
    {
        private List<ISRHourWorker> _workers;
        private OperatorDayContext _context;
        /// <summary>
        /// 每页条数
        /// </summary>
        protected const int PAGESIZE = 1000000;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public SRHourEngine(MQMsg.SROperatorPerHourMsg msg)
        {
            _context = new OperatorDayContext(msg.ReportDate, msg.OperatorId);
            //this.Init();
        }

        public async Task Init()
        {
            await this.InitContextData();
            _workers = new List<ISRHourWorker>
            {
                new SrUserBettingHourJob(_context)
            };
        }

        /// <summary>
        /// 初始化context上下文
        /// </summary>
        /// <returns></returns>
        private async Task InitContextData()
        {
            this._context.ProviderOrderEos = await this.InitDayProviderOrders()??new List<S_provider_orderEO>();
        }

       

        private async Task<List<S_provider_orderEO>> InitDayProviderOrders()
        {
            (var operatorId, var startDate, var endDate) = GetUtcTimeByLocalTime();

            var providerOrderMo = new S_provider_orderMO();
            providerOrderMo.UseReadConnectionString = true;
            var pageCount = await providerOrderMo.GetPageCountAsync(PAGESIZE, $" ResponseTime>=@startDate and ResponseTime<@endDate and OperatorID=@OperatorID and ReqMark!=4 and UserKind=1 and Status =2 and CurrencyType=9", values: new object[] { startDate, endDate, operatorId });
            if (pageCount == 0) return null;

            var providerOrders = new List<S_provider_orderEO>();
            List<S_provider_orderEO> temp;
            for (var page = 1; page <= pageCount; page++)
            {
                temp = await providerOrderMo.GetPagerListAsync(PAGESIZE, page, "ResponseTime>=@startDate and ResponseTime<@endDate and OperatorID=@OperatorID and ReqMark!=4 and UserKind=1 and Status =2 and CurrencyType=9", "OrderId", startDate, endDate, operatorId);
                if (null != temp && temp.Any())
                    providerOrders.AddRange(temp);
                await Task.Delay(200);
            }
            return providerOrders;
        }

        private (string, DateTime, DateTime) GetUtcTimeByLocalTime()
        {
            var operatorId = this._context.OperatorId;
            var endDate = this._context.ReportDate.ToUtcTime(operatorId);
            var startDate = this._context.ReportDate.AddHours(-1).ToUtcTime(operatorId);
            return (operatorId, startDate, endDate);
        }
        
        public async Task Execute()
        {
            await this.Init();

            foreach (var worker in _workers)
            {
                await worker.Execute();
            }
        }
    }
}
