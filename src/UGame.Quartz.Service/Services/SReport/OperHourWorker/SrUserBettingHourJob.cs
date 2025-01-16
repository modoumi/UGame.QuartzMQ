using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using TinyFx;
using Xxyy.Common.Caching;
using Xxyy.MQ.Quartz;
using UGame.Quartz.Service.Services.BasicReport.OperDayWorker;
using UGame.Quartz.Repository;
using Microsoft.Extensions.Logging;
using TinyFx.Data;
using TinyFx.Extensions.AutoMapper;
using Xxyy.DAL;
using Xxyy.Common;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using TinyFx.Reflection;
using System.Numerics;
using UGame.Quartz.Service.Services.BasicReport;

namespace UGame.Quartz.Service.Services.SReport.OperHourWorker
{
    public class SrUserBettingHourJob:ISRHourWorker
    {
        private readonly OperatorDayContext _context;
        private readonly Sr_user_betting_hourMO _userBettingHourMo = new();
        private ILogger<SrUserBettingHourJob> _logger;
        private const int BATCHCOUNT = Int32.MaxValue;
        public SrUserBettingHourJob(OperatorDayContext context)
        {
            _logger = LogUtil.CreateLogger<SrUserBettingHourJob>();
            _context = context;
        }

        public async Task Execute()
        {
            var tm = new TransactionManager();
            try
            {
                //获取需要插入的数据
                var res1 = _context.ProviderOrderEos.GroupBy(a => a.UserID).Select(a => new Sr_user_betting_hourEO
                {
                    
                    UserCount = a.Count()
                });
                //清空旧数据
                var rows = await _userBettingHourMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm, _context.ReportDate, _context.OperatorId);
                if (res1.Count() == 0)
                {
                    //添加
                    rows = await _userBettingHourMo.AddAsync(new Sr_user_betting_hourEO(){DayId = _context.ReportDate ,OperatorID = _context.OperatorId,UserCount = 0});
                }
                else
                {
                    //添加
                    rows = await _userBettingHourMo.AddAsync(new Sr_user_betting_hourEO() { DayId = _context.ReportDate, OperatorID = _context.OperatorId, UserCount = res1.FirstOrDefault()?.UserCount }, tm);
                }
            
                tm.Commit();
                _logger.LogInformation("SrUserBettingHourJob 处理成功!dayid:{0},operatorid:{1}",_context.ReportDate,_context.OperatorId);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                _logger.LogError(ex, "SrUserBettingHourJob 处理出错：date-{0},operatorId:{1} ,ex:{2}", _context.ReportDate,_context.OperatorId,ex.ToString());
            }
        }
    }
}
