using EasyNetQ;
using MediatR;
using Microsoft.Extensions.Logging;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using TinyFx.Text;
using UGame.Quartz.Service.Commands;
using UGame.Quartz.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.DAL;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.LoseCashBack
{
    /// <summary>
    /// 输返活动服务类
    /// </summary>
    public class LoseCashBackService
    {
        ILogger<LoseCashBackService> _logger;
        Repository.S_user_dayMO _sUserDayMo = new();
        Sa_losecashback_configMO _saLoseCashBackMo = new();
        Sa_losecashback_detailMO _saLoseCashBackDetailMo = new();
        IMediator _mediator;

        public LoseCashBackService(IMediator mediator)
        {
            _logger = LogUtil.CreateLogger<LoseCashBackService>();
            _mediator = mediator;
        }

        /// <summary>
        /// 输返活动业务逻辑
        /// </summary>
        public async Task<LoseCashBackDto> Execute(LoseCashBackIpo ipo)
        {
            TransactionManager tm = new TransactionManager();
            LoseCashBackDto ret = new LoseCashBackDto();
            int _userCount = 0;
            var _userList = new List<CashBackDetailInfo>();
            ret.userList = _userList;

            var currencyId = string.Empty;

            try
            {

                var _tmpDayId = (!string.IsNullOrWhiteSpace(ipo.GrantDate) && DateTime.TryParse(ipo.GrantDate, out DateTime tmpGrantDate)) ? tmpGrantDate.Date : DateTime.UtcNow.ToLocalTime(ipo.OperatorID).Date;
                var dayID = _tmpDayId.AddDays(-1);
                ret.dayId = dayID.ToString("yyyy-MM-dd");
                var operatorInfo = DbCacheUtil.GetOperator(ipo.OperatorID);

                var rangeMinConfigList = await _saLoseCashBackMo.GetTopSortAsync("OperatorID=@OperatorID", 1, "RangeMin asc", ipo.OperatorID);
                if (rangeMinConfigList == null || rangeMinConfigList.Count() == 0)
                {
                    _logger.LogError($"运营商id:{ipo.OperatorID}，货币类型:{operatorInfo.CurrencyID}，尚未配置输返活动相关参数。");
                    return ret;
                }

                currencyId = operatorInfo.CurrencyID;

                //输返活动是否有效
                var activity = await QuartzUtils.GetActivityIsOpen(ipo.OperatorID, currencyId, ActivityType.LoseCashBack, ActivityEvent.LoseCashBack);

                if (!activity.IsValid)
                    return ret;

                var rangeMin = rangeMinConfigList[0].RangeMin;//可以参加输返活动的最小亏损金额

                var userDayList = await _sUserDayMo.GetAsync($"DayID=@DayID and OperatorID=@OperatorID and (TotalWinAmount-TotalWinBonus)-(TotalBetAmount-TotalBetBonus)<0  and (TotalBetAmount-TotalBetBonus)-(TotalWinAmount-TotalWinBonus)>=@rangeMin", dayID, ipo.OperatorID, rangeMin);
                if (userDayList != null && userDayList.Count > 0)
                {
                    foreach (var userDay in userDayList)
                    {
                        var refundRecord = await _saLoseCashBackDetailMo.GetAsync($"UserID=@UserID and DayID=@DayID", userDay.UserID, dayID);
                        if (refundRecord != null && refundRecord.Any()) continue;//该用户已参加当天的输返活动

                        var currencyChangeService = new CurrencyChangeService(userDay.UserID);
                        var _lossCashAmount = (userDay.TotalBetAmount - userDay.TotalBetBonus) - (userDay.TotalWinAmount - userDay.TotalWinBonus);
                        var refundConfigs = await _saLoseCashBackMo.GetAsync($"OperatorID=@OperatorID and RangeMin <= @BetAmount and  RangeMax>@BetAmount", ipo.OperatorID, _lossCashAmount);
                        if (refundConfigs == null || refundConfigs.Count != 1)
                        {
                            _logger.LogError($"运营商id:{ipo.OperatorID}，货币类型:{operatorInfo.CurrencyID}，输返活动相关配置参数有误。");
                            continue;
                        }

                        var refundConfig = refundConfigs[0];
                        //var allLost = Math.Abs(userDay.TotalWinAmount - userDay.TotalBetAmount);//总输额度
                        //var bonusLost = Math.Abs(userDay.TotalWinBonus - userDay.TotalBetBonus);//bonus输的额度
                        //if (allLost <= bonusLost) { continue; }
                        var tmpFund = (long)(_lossCashAmount * refundConfig.RefundMultiple);
                        var refund = tmpFund >= refundConfig.RefundMax ? refundConfig.RefundMax : tmpFund;

                        //1.新增sa_losecashback_detail
                        var cashBackDetail = new Sa_losecashback_detailEO()
                        {
                            DetailID = ObjectId.NewId(),
                            UserID = userDay.UserID,
                            OperatorID = ipo.OperatorID,
                            CountryID = operatorInfo.CountryID,
                            CurrencyID = operatorInfo.CurrencyID,
                            RefundAmount = refund,
                            NotifyStatus = 0,
                            RecDate = DateTime.UtcNow,
                            DayID = dayID,
                            ReceiveStatus = 0,
                            FlowMultip = refundConfig.FlowMultip
                        };

                        if (await _saLoseCashBackDetailMo.AddAsync(cashBackDetail, tm) < 1)
                            throw new Exception("执行定时任务输返活动，新增返金详情失败");

                        _userCount++;
                        _userList.Add(new CashBackDetailInfo { userId = userDay.UserID, loseBack = refund.AToM(userDay.CurrencyID) });

                    }

                    tm.Commit();

                    #region 发通知
                    var toNotifyUsers = await _saLoseCashBackDetailMo.GetAsync("NotifyStatus=0");
                    if (toNotifyUsers != null && toNotifyUsers.Count > 0)
                    {
                        foreach (var _notiUser in toNotifyUsers)
                        {
                            LoseCashBackNotifyCommand notifyCommand = new LoseCashBackNotifyCommand();
                            notifyCommand.UserId = _notiUser.UserID;
                            notifyCommand.OperatorId = _notiUser.OperatorID;
                            notifyCommand.CountryId = _notiUser.CountryID;
                            notifyCommand.CurrencyId = _notiUser.CurrencyID;
                            notifyCommand.RewardAmount = _notiUser.RefundAmount;
                            notifyCommand.FlowMultip = _notiUser.FlowMultip;
                            notifyCommand.RewardSourceId = _notiUser.DetailID;
                            notifyCommand.IsSendNotify = activity.activityEntity.IsSendNotify;
                            notifyCommand.IsSendNotifyEmail = activity.activityEntity.IsSendNotifyEmail;
                            notifyCommand.AfterNofify = async (string rewardSourceId) =>
                            {
                                return await _saLoseCashBackDetailMo.PutNotifyStatusByPKAsync(rewardSourceId, 1);
                            };
                            await _mediator.Send(notifyCommand);
                        }
                    }
                    #endregion

                }

                ret.userCount = _userCount;
                return ret;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                _userList.Clear();
                ret.userList.Clear();
                ret.userCount = 0;
                _logger.LogError(ex, "执行定时任务输返活动时，出现异常");
                return ret;
            }
        }




        /// <summary>
        /// 获取当前活动是否有效
        /// </summary>
        /// <param name="operatorId">运营商编码</param>
        /// <param name="currencyId">货币编码</param>
        /// <param name="activityType">活动类型</param>
        /// <param name="activityEvent">事件类型</param>
        /// <returns></returns>
        //public static async Task<(bool IsValid, ActivityListEventEntity activityEntity)> GetActivityIsOpen(string operatorId, string currencyId, ActivityType activityType, ActivityEvent activityEvent)
        //{
        //    (bool IsValid, ActivityListEventEntity activityEntity) ret = (false, null);

        //    var sql = $@"select
	       //             l_activity_operator.ActivityID,
	       //             l_activity_operator.OperatorID,
	       //             l_activity_operator.CurrencyID,
	       //             l_activity_operator.CountryID,
	       //             l_activity_operator.BeginDate,
	       //             l_activity_operator.EndDate,
	       //             l_activity_operator.OrderNum,
	       //             l_activity_operator.`Status`,
	       //             l_activity_operator.IsSendNotify,
	       //             l_activity_operator.IsSendNotifyEmail,
	       //             l_activity_event_operator.ActivityEventId as EventId
        //            from l_activity_operator
        //            inner join l_activity_event_operator
        //            on l_activity_operator.OperatorID = l_activity_event_operator.OperatorID and l_activity_operator.ActivityID = l_activity_event_operator.ActivityID
        //            where l_activity_operator.`Status` = 1
        //            and l_activity_operator.OperatorID = '{operatorId}'
        //            and l_activity_operator.CurrencyID = '{currencyId}'
        //            and '{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}' BETWEEN l_activity_operator.BeginDate and l_activity_operator.EndDate
        //            and l_activity_event_operator.`Status` = 1
        //            order by l_activity_operator.OrderNum";

        //    var list = await DbSink.MainDb.ExecSqlListAsync<ActivityListEventEntity>(sql);

        //    if (list == null || !list.Any())
        //        return ret;

        //    ret.activityEntity = list.Where(d => d.Status && d.ActivityID == (int)activityType && d.EventId == (int)activityEvent).FirstOrDefault();

        //    if (ret.activityEntity != null)
        //        ret.IsValid = true;

        //    return ret;

        //}

    }


    //public class ActivityListEventEntity
    //{
    //    public int ActivityID { get; set; }
    //    public string OperatorId { get; set; }
    //    public string CurrencyId { get; set; }
    //    public string Name { get; set; }
    //    public string CountryId { get; set; }
    //    public DateTime BeginDate { get; set; }
    //    public DateTime EndDate { get; set; }
    //    public int OrderNum { get; set; }
    //    public bool Status { get; set; }
    //    public int EventId { get; set; }
    //    /// <summary>
    //    /// 是否发送弹框通知
    //    /// </summary>
    //    public bool IsSendNotify { get; set; }
    //    /// <summary>
    //    /// 是否发送站内邮箱通知
    //    /// </summary>
    //    public bool IsSendNotifyEmail { get; set; }
    //}

}
