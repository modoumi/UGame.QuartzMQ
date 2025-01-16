using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using TinyFx.Reflection;
using UGame.Quartz.Service.MQMsg;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Quartz;
using UGame.Quartz.Service.Services.MQConsumers;
using UGame.Quartz.Repository;
using Sf_promoter_user_dayMO = UGame.Quartz.Repository.Sf_promoter_user_dayMO;

namespace UGame.Quartz.Service.Services.BasicReport
{
    public class ReportService
    {
        private ILogger<ReportService> _logger;
        private readonly Sf_promoter_user_dayMO _sfPromoteruserDayMo = new();
        //private readonly S_operatorMO _operatorMo = new();
        //private readonly Sr_user_dayMO _userDayMo = new();
        //private readonly Sr_oper_dayMO _operDayMo= new();
        ///// <summary>
        ///// 批量插入的条数
        ///// </summary>
        //protected const int BATCHCOUNT = 2000;

        public ReportService()
        {
            _logger = LogUtil.CreateLogger<ReportService>();
        }

        /// <summary>
        /// 每日基础统计
        /// </summary>
        /// <param name="reportDate">指定的日期（如不指定默认为）</param>
        /// <returns></returns>
        public async Task SrDay(SrPerDayIpo ipo)
        {
            var msg = new SROperatorPerDayMsg
            {
                OperatorId = ipo.OperatorId,
                StartDate=ipo.StartDate,
                EndDate=ipo.EndDate
            };
            await MQUtil.PublishAsync(msg);
        }

        /// <summary>
        /// 获取运营商指定某天的最大dayId
        /// </summary>
        /// <returns></returns>
        private async Task<DateTime?> GetMaxDayId(string operatorId)
        {
            var operatorMaxDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_sfPromoteruserDayMo.TableName} where OperatorID=@OperatorID order by DayID desc limit 1", operatorId);
            return operatorMaxDayId;
        }

        /// <summary>
        /// 每日小时数据统计
        /// </summary>
        /// <returns></returns>
        public async Task SrHour(SrPerHourIpo ipo)
        {
            var dateTime = DateTime.UtcNow.ToLocalTime(ipo.OperatorId);
            //可以通过参数指定日期进行覆盖
            var msg = new SROperatorPerHourMsg
            {
                ReportDate = ipo.reportDate == null ? dateTime.Date.AddHours(dateTime.Hour) : ipo.reportDate.Value.Date.AddHours(ipo.reportDate.Value.Hour),
                OperatorId = ipo.OperatorId
            };
            await MQUtil.PublishAsync(msg);

        }
    }
}
