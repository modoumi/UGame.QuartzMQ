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
using UGame.Quartz.Service.Services.SReport;
using UGame.Quartz.Service.Services.SReport.AppProviderJobs;
using UGame.Quartz.Service.Services.SReport.OperDayWorker;
using UGame.Quartz.Service.Services.SReport.PromoterWorker;
using Xxyy.Quartz.DAL;
using S_user_dayPO = Xxyy.DAL.S_user_dayPO;

namespace UGame.Quartz.WebAPI.Controllers
{
    public class SReportController : QuartzControllerBase
    {
        private ReportService _reportSvc = new();

        /// <summary>
        /// 执行基础数据统计
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task PerDay(SrPerDayIpo ipo)
        {
            LogUtil.Info("0.{0},收到报表请求ipo:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(ipo));
            try
            {
                await _reportSvc.SrDay(ipo);
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "执行_basicSvc.srday异常！ipo:{0}", SerializerUtil.SerializeJsonNet(ipo));
            }
        }

        /// <summary>
        /// 执行基础数据统计按countryid
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> PerDayByCountry(SrPerDayByCountryIpo ipo)
        {
            if (string.IsNullOrWhiteSpace(ipo.CountryId)) return BadRequest($"参数countryid不能为空！{nameof(ipo.CountryId)}");

            LogUtil.Info("0.{0},收到报表请求ipo:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(ipo));
            try
            {
                var operatorEos = await new Xxyy.DAL.S_operatorMO().GetAsync("CountryID=@countryId and Status=@Status", ipo.CountryId, 1);
                foreach (var item in operatorEos)
                {
                    await _reportSvc.SrDay(new SrPerDayIpo
                    {
                        StartDate = ipo.StartDate,
                        EndDate = ipo.EndDate,
                        OperatorId = item.OperatorID
                    });
                }
                return Ok("报表请求已入队");
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "执行_basicSvc.srday异常！ipo:{0}", SerializerUtil.SerializeJsonNet(ipo));
            }
            return BadRequest();
        }

        /// <summary>
        /// 小时数据统计
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task PerHours(SrPerHourIpo ipo)
        {
            LogUtil.Info("0.{0},收到报表请求ipo:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(ipo));
            try
            {
                await _reportSvc.SrHour(ipo);
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "执行_basicSvc.srdHours异常！ipo:{0}", SerializerUtil.SerializeJsonNet(ipo));
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public string Check() => "OK";

        [HttpPost, AllowAnonymous]
        public async Task Test(SrPerDayIpo ipo)
        {
            //var message = new MQ.Quartz.SROperatorPerDayMsg
            //{
            //    DayId = ipo.reportDate.Value,
            //    OperatorId = ipo.OperatorId
            //};
            var message = new SROperatorPerDayMsg
            {
                // DayId = ipo.reportDate.Value,
                OperatorId = ipo.OperatorId,
                StartDate = ipo.StartDate,
                EndDate = ipo.EndDate
            };
            try
            {

                await new SRDayEngine(message).Execute(ipo.OperatorId);

                LogUtil.Info("SROperatorPerDayMQSub.{0},after engine.execute执行完成！param:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(message));
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "SROperatorPerDayMQSub消费者执行异常！msg:{0}", SerializerUtil.SerializeJsonNet(message));
            }
        }

        /// <summary>
        /// 执行基础数据统计按countryid
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> TestBetD(SrPerDayByCountryIpo ipo)
        {
            if (string.IsNullOrWhiteSpace(ipo.CountryId)) return BadRequest($"参数countryid不能为空！{nameof(ipo.CountryId)}");

            LogUtil.Info("0.{0},收到报表请求ipo:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(ipo));
            try
            {
                var operatorEos = await new Xxyy.DAL.S_operatorMO().GetAsync("CountryID=@countryId and Status=@Status", ipo.CountryId, 1);
                foreach (var item in operatorEos)
                {
                    for (DateTime dayid = ipo.StartDate.Value; dayid <= ipo.EndDate.Value; dayid = dayid.AddDays(1))
                    {
                        #region operday

                        var InitDayUsers = DbUtil.GetRepository<S_user_dayPO>().AsQueryable().Where(c =>
                            c.DayID == dayid && c.UserKind == 1 && c.OperatorID == item.OperatorID && c.HasBet).Select(c => c.UserID).ToList();
                        var payUserIds = InitDayUsers.Distinct() ?? new List<string>();
                        var newPayUserIds = DbUtil.GetRepository<S_user_dayPO>().AsQueryable().Where(c =>
                            c.DayID == dayid.AddDays(-1) && c.UserKind == 1 && c.OperatorID == item.OperatorID && c.HasBet && c.IsNew).Select(c => c.UserID).ToList();
                        var retention = newPayUserIds.Count == 0 ? 0 : newPayUserIds.Intersect(payUserIds).Count() / (float)newPayUserIds.Count;
                        if (retention > 0)
                        {
                            DbUtil.GetRepository<Sr_oper_dayPO>().AsUpdateable()
                                .SetColumns(it => new Sr_oper_dayPO() { BetD1 = retention })
                                .Where(it => it.DayID == dayid.AddDays(-1) && it.OperatorID == item.OperatorID).ExecuteCommand();
                        }

                        #endregion

                    }
                }

                foreach (var item in operatorEos)
                {
                    for (DateTime dayid = ipo.StartDate.Value; dayid <= ipo.EndDate.Value; dayid = dayid.AddDays(1))
                    {
                        #region sr_channel_day

                        var fromids = DbUtil.GetRepository<S_user_dayPO>().AsQueryable().Where(c =>
                            c.DayID == dayid && c.UserKind == 1 && c.OperatorID == item.OperatorID && c.FromMode == 2 &&
                            c.HasBet).GroupBy(c => c.FromId).Select(a => a.FromId).ToList();
                       
                        foreach (string fromid in fromids)
                        {
                            var InitDayUsers = DbUtil.GetRepository<S_user_dayPO>().AsQueryable().Where(c =>
                                c.DayID == dayid && c.UserKind == 1 && c.OperatorID == item.OperatorID && c.FromMode == 2&&c.FromId== fromid && c.HasBet).Select(c => c.UserID).ToList();

                            var payUserIds = InitDayUsers.Distinct() ?? new List<string>();
                            var newPayUserIds = DbUtil.GetRepository<S_user_dayPO>().AsQueryable().Where(c =>
                                c.DayID == dayid.AddDays(-1) && c.UserKind == 1 && c.OperatorID == item.OperatorID && c.FromMode == 2 && c.FromId == fromid && c.HasBet && c.IsNew).Select(c => c.UserID).ToList();
                            
                            var retention = newPayUserIds.Count == 0 ? 0 : newPayUserIds.Intersect(payUserIds).Count() / (float)newPayUserIds.Count;
                            if (retention > 0)
                            {
                                DbUtil.GetRepository<Sr_channel_dayPO>().AsUpdateable()
                                    .SetColumns(it => new Sr_channel_dayPO() { BetD1 = retention })
                                    .Where(it => it.DayID == dayid.AddDays(-1) && it.OperatorID == item.OperatorID&&it.ChannelID==fromid).ExecuteCommand();
                            }
                        }


                    

                        #endregion

                    }
                }

                return Ok("更新完毕");
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "执行_basicSvc.srday异常！ipo:{0}", SerializerUtil.SerializeJsonNet(ipo));
            }
            return BadRequest();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> SrOperAppDayJob(SrPerDayIpo ipo)
        {
            base.ThrowIfEmpty(ipo.OperatorId, $"operatorId:{ipo.OperatorId}不能为空！");

            var job = new SrOperAppDayJob();
            await base.ExecuteJob(job, ipo.StartDate, ipo.EndDate, ipo.OperatorId);
            return Ok("ok");
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> SrBankPaytypeDayJob(SrPerDayIpo ipo)
        {
            base.ThrowIfEmpty(ipo.OperatorId, $"operatorId:{ipo.OperatorId}不能为空！");

            var job = new SrBankPaytypeDayJob();
            await base.ExecuteJob(job, ipo.StartDate, ipo.EndDate, ipo.OperatorId);
            return Ok("ok");
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> SRUserDayJob(SrPerDayIpo ipo)
        {
            base.ThrowIfEmpty(ipo.OperatorId, $"operatorId:{ipo.OperatorId}不能为空！");

            var job = new SRUserDayJob();
            await base.ExecuteJob(job, ipo.StartDate, ipo.EndDate, ipo.OperatorId);
            return Ok("ok");
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> OperDayJob(SrPerDayIpo ipo)
        {
            base.ThrowIfEmpty(ipo.OperatorId, $"operatorId:{ipo.OperatorId}不能为空！");

            var job = new GroupByOperDayJob();
            await base.ExecuteJob(job, ipo.StartDate, ipo.EndDate, ipo.OperatorId);
            return Ok("ok");
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> ChannelDayJob(SrPerDayIpo ipo)
        {
            base.ThrowIfEmpty(ipo.OperatorId, $"operatorId:{ipo.OperatorId}不能为空！");

            var job = new GroupByChannelDayJob();
            await base.ExecuteJob(job, ipo.StartDate, ipo.EndDate, ipo.OperatorId);
            return Ok("ok");
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> PromoterDayJob(SrPerDayIpo ipo)
        {
            base.ThrowIfEmpty(ipo.OperatorId, $"operatorId:{ipo.OperatorId}不能为空！");

            var job = new SfPromoterPerfDayJob();
            await base.ExecuteJob(job, ipo.StartDate, ipo.EndDate, ipo.OperatorId);
            return Ok("ok");
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> DayJob(SrPerDayIpo ipo)
        {
            base.ThrowIfEmpty(ipo.OperatorId, $"operatorId:{ipo.OperatorId}不能为空！");
            if (ipo.StartDate == null || ipo.StartDate.Value == DateTime.MinValue)
                throw new CustomException($"startDate:{ipo.StartDate}不能为空！");
            if (ipo.EndDate == null || ipo.EndDate.Value == DateTime.MinValue)
                throw new CustomException($"EndDate:{ipo.EndDate}不能为空！");
            if (ipo.StartDate.Value > ipo.EndDate.Value)
                throw new CustomException($"startDate:{ipo.StartDate.Value}不能大于EndDate:{ipo.EndDate}!");

            var message = new SROperatorPerDayMsg
            {
                StartDate = ipo.StartDate.Value.Date,
                EndDate = ipo.EndDate.Value.Date,
                OperatorId = ipo.OperatorId
            };
            try
            {
                await MQUtil.PublishAsync(message);
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "发送消息{0}异常", SerializerUtil.SerializeJsonNet(message));
            }
            return Ok("ok");
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> AppDayJob(SrPerDayIpo ipo)
        {
            if (ipo.EndDate == null || ipo.EndDate.Value == DateTime.MinValue)
                throw new CustomException($"EndDate:{ipo.EndDate}不能为空！");
            if (ipo.StartDate.Value > ipo.EndDate.Value)
                throw new CustomException($"startDate:{ipo.StartDate.Value}不能大于EndDate:{ipo.EndDate}!");

            var job = new SrAppDayJob();
            await base.ExecuteJob(job, ipo.StartDate.Value.Date, ipo.EndDate.Value.Date);
            return Ok("ok");
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> ProvDayJob(SrPerDayIpo ipo)
        {
            if (ipo.EndDate == null || ipo.EndDate.Value == DateTime.MinValue)
                throw new CustomException($"EndDate:{ipo.EndDate}不能为空！");
            if (ipo.StartDate.Value > ipo.EndDate.Value)
                throw new CustomException($"startDate:{ipo.StartDate.Value}不能大于EndDate:{ipo.EndDate}!");

            var job = new SrProvDayJob();
            await base.ExecuteJob(job, ipo.StartDate.Value.Date, ipo.EndDate.Value.Date);
            return Ok("ok");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> AppProvPerDay(SrPerDayIpo ipo)
        {
            var message = new SRAppProvPerDayMsg
            {
                StartDate = ipo.StartDate,
                EndDate = ipo.EndDate
            };
            //await new SrAppProvEngine(message).Execute();

            await MQUtil.PublishAsync(message);
            return Ok("ok");
        }

       }
    }

