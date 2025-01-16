using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Org.BouncyCastle.Bcpg.Sig;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Configuration;
using TinyFx.Data;
using TinyFx.Logging;
using TinyFx.Text;
using UGame.Quartz.Service.Commands;
using UGame.Quartz.Service.Common;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using UGame.Quartz.Service.Services.VipWeekReward;
using UGame.Quartz.Repository;
using ActivityEvent = UGame.Quartz.Service.Common.ActivityEvent;

namespace UGame.Quartz.Service.Services.Activity.InviteNewuser
{
    /// <summary>
    /// 好友邀请分享-100011
    /// </summary>
    public class InviteNewuserService
    {

        private ILogger<InviteNewuserService> _logger;
        private IMediator _mediator;

        /// <summary>
        /// InviteNewuserService
        /// </summary>
        /// <param name="mediator"></param>
        public InviteNewuserService(IMediator mediator)
        {
            _logger = LogUtil.CreateLogger<InviteNewuserService>();
            _mediator = mediator;
        }

        /// <summary>
        /// 好友邀请分享活动，发放月度奖励
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<bool> ExecuteNew(InviteNewuserIpo ipo)
        {
            var activityOperatorEo = await QuartzUtils.GetActivityOperatorSingleAsync(ipo.OperatorId, ipo.CurrencyId, ActivityType.InviteNewUser100013);

            if (activityOperatorEo == null || !activityOperatorEo.Status)
            {
                _logger.LogError($"InviteNewuser/ExecuteNew.活动不存在或已过期.activityOperatorEo:{JsonConvert.SerializeObject(activityOperatorEo)}");
                return false;
            }

            //推广员获得有效推广人数
            Dictionary<string, int> pUserDic = new Dictionary<string, int>();

            var promoterValidQuantityList = await DbSink.MainDb.ExecSqlListAsync<PromoterValidQuantity>("select PUserID,count(*) as ValidQuantity from sa_invite100013_user where POperatorId = @POperatorId and UOperatorId = @UOperatorId and  IsMeetPayLimit = 1 and IsMeetBetLimit = 1 group by PUserID", ipo.OperatorId, ipo.OperatorId);

            if (promoterValidQuantityList == null || !promoterValidQuantityList.Any())
            {
                _logger.LogError($"InviteNewuser/ExecuteNew.不存在满足奖励条件的数据.");
                return false;
            }

            //活动配置
            var inviteConfigEo = await new Sa_invite100013_configMO().GetSingleAsync("OperatorId = @OperatorId and CurrencyId = @CurrencyId", ipo.OperatorId, ipo.CurrencyId);
            if (inviteConfigEo == null)
            {
                _logger.LogError($"InviteNewuser/ExecuteNew.sa_invite100013_config配置不存在.");
                return false;
            }

            //活动有效人数与奖励配置
            var inviteNumConfigEoList = await new Sa_invitenum100013_configMO().GetSortAsync("OperatorId = @OperatorId and CurrencyId = @CurrencyId", "ValidQuantity", ipo.OperatorId, ipo.CurrencyId);

            if (inviteNumConfigEoList == null || !inviteNumConfigEoList.Any())
            {
                _logger.LogError($"InviteNewuser/ExecuteNew.sa_invitenum100013_config配置不存在.");
                return false;
            }

            //邀请人已经发放奖励的明细
            List<Sa_invite100013_detailEO> inviteDetailEoList = null;
            Sa_invite100013_detailEO inviteDetailEo = null;
            //需要发放奖励的明细
            List<Sa_invite100013_detailEO> writeInviteDetailEoList = new List<Sa_invite100013_detailEO>();
            var inviteDetailMo = new Sa_invite100013_detailMO();

            var timeNow = DateTime.UtcNow;
            foreach (var item in promoterValidQuantityList)
            {
                inviteDetailEoList = await inviteDetailMo.GetSortAsync("UserId = @UserId", "Bonus", item.PUserId);
                foreach (var citem in inviteNumConfigEoList)
                {
                    //邀请的有效人数 < 需要的邀请人数
                    if (item.ValidQuantity < citem.ValidQuantity)
                        break;

                    if (inviteDetailEoList.Any(d => d.ConfigID == citem.ConfigID))
                        continue;

                    writeInviteDetailEoList.Add(new Sa_invite100013_detailEO()
                    {
                        DetailID = ObjectId.NewId(),
                        UserID = item.PUserId,
                        ConfigID = citem.ConfigID,
                        OperatorID = ipo.OperatorId,
                        CountryID = ipo.CountryId,
                        CurrencyID = ipo.CurrencyId,
                        Bonus = citem.Bonus,
                        FlowMultip = inviteConfigEo.FlowMultip,
                        ReceiveStatus = false,
                        RecDate = DateTime.UtcNow
                    });
                }
            }

            if (!writeInviteDetailEoList.Any())
                return false;

            TransactionManager tm = new TransactionManager();

            try
            {

                await inviteDetailMo.AddByBatchAsync(writeInviteDetailEoList, writeInviteDetailEoList.Count(), tm);

                tm.Commit();

                foreach (var item in writeInviteDetailEoList)
                {
                    var notifyCommand = new InviteNewuser100013NotifyCommand();
                    notifyCommand.UserId = item.UserID;
                    notifyCommand.OperatorId = item.OperatorID;
                    notifyCommand.CountryId = item.CountryID;
                    notifyCommand.CurrencyId = item.CurrencyID;
                    notifyCommand.RewardAmount = item.Bonus;
                    notifyCommand.FlowMultip = inviteConfigEo.FlowMultip;
                    notifyCommand.RewardSourceId = item.DetailID;
                    notifyCommand.IsSendNotify = activityOperatorEo.IsSendNotify;
                    notifyCommand.IsSendNotifyEmail = activityOperatorEo.IsSendNotifyEmail;
                    await _mediator.Send(notifyCommand);
                }

            }
            catch (Exception ex)
            {
                tm.Rollback();
            }


            return true;
        }

        /// <summary>
        /// 好友邀请分享活动，发放月度奖励
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<InviteNewuserDto> Execute(InviteNewuserIpo ipo)
        {
            var ret = new InviteNewuserDto();
            var inviteDetailMo = new Sa_invite100011_detailMO();

            //校验好友邀请分享活动是否有效
            if (!await CheckActivity(ipo))
            {
                _logger.LogInformation($"InviteNewuserService.活动已失效.{JsonConvert.SerializeObject(ipo)}");
                return ret;
            }

            //邀请好友数量配置
            var inviteNumConfigList = await new Sa_invitenum100011_configMO().GetSortAsync("OperatorId = @OperatorId and CurrencyId = @CurrencyId", "Bonus", ipo.OperatorId, ipo.CurrencyId);

            //当前时间
            var timeNow = DateTime.UtcNow.ToLocalTime(ipo.OperatorId);
            ret.Now = timeNow;
            //if (!ConfigUtil.IsDebugEnvironment && timeNow.Day != 1 && timeNow.Minute != 0)
            //    return ret;

            //数据查询区间
            var country = DbCacheUtil.GetCountryByOperatorId(ipo.OperatorId);
            var startTime = timeNow.AddMonths(-1).ToString($"yyyy-MM-01 {Math.Abs(country.TimeZone)}:00:00");
            var endTime = timeNow.ToString($"yyyy-MM-01 {Math.Abs(country.TimeZone)}:00:00");

            ret.StartTime = startTime;
            ret.EndTime = endTime;

            //当前用户充值数量
            Dictionary<string, long> userDic = new Dictionary<string, long>();
            //推广员获得有效推广人数
            Dictionary<string, int> pUserDic = new Dictionary<string, int>();

            //符合条件的推广数据
            List<S_user_promoterEO> dbData = new List<S_user_promoterEO>();
            var moList = DbSink.GetUserPromoterMoList();
            foreach (var item in moList)
            {
                dbData.AddRange(await item.GetAsync("OperatorId = @OperatorId and CurrencyId = @CurrencyId and PromoteTime >= @StartTime and PromoteTime < @endTime", ipo.OperatorId, ipo.CurrencyId, startTime, endTime));
            }

            userDic = dbData.GroupBy(d => d.IUserID).ToDictionary(d => d.Key, d => 0L);
            pUserDic = dbData.GroupBy(d => d.PUserID).ToDictionary(d => d.Key, d => 0);

            //充值、提现订单
            var bankOrderMo = new Sb_bank_orderMO();
            var db = DbSink.MainDb;
            //查询用户当月充值总额
            foreach (var item in userDic)
            {
                var sumAmount = db.ExecSqlScalar<long?>($"select SUM(Amount) from sb_bank_order where OrderType = 1 and `Status` = 2 and BankCallbackTime >= @StartTime and BankCallbackTime < @EndTime and UserId = @UserId", startTime, endTime, item.Key);
                if (sumAmount.HasValue && sumAmount.Value >= inviteNumConfigList.FirstOrDefault().PayCondition)
                    userDic[item.Key] = sumAmount.Value;
            }

            userDic = userDic.Where(d => d.Value >= inviteNumConfigList.FirstOrDefault().PayCondition).ToDictionary(d => d.Key,d => d.Value);

            //没有符合充值条件的用户
            if (userDic == null || userDic.Count == 0)
                return ret;

            foreach (var item in dbData)
            {
                if (userDic.ContainsKey(item.IUserID))
                    pUserDic[item.PUserID] += 1;
            }

            pUserDic = pUserDic.Where(d => d.Value > 0).ToDictionary(d => d.Key, d => d.Value);

            //没有符合邀请数量条件的推广人
            if (pUserDic == null || pUserDic.Count == 0)
                return ret;

            //写库数据
            var inviteDetailList = new List<Sa_invite100011_detailEO>();
            var recDate = DateTime.UtcNow;
            foreach (var item in pUserDic)
            {
                var inviteNumConfig = inviteNumConfigList.Where(d => item.Value > d.UserNumStart && item.Value <= d.UserNumEnd).FirstOrDefault();
                if (inviteNumConfig != null)
                {
                    var pUserDCache = await GlobalUserDCache.Create(item.Key);

                    var inviteDetailEo = await inviteDetailMo.GetSingleAsync("PUserID = @PUserID and RewardType = 2 and MonthDate = @MonthDate", item.Key, Convert.ToDateTime(startTime).Date);
                    if (inviteDetailEo != null)
                        continue;

                    inviteDetailList.Add(new Sa_invite100011_detailEO()
                    {
                        DetailID = Guid.NewGuid().ToString(),
                        OperatorID = ipo.OperatorId,
                        CountryId = country.CountryID,
                        CurrencyID = ipo.CurrencyId,
                        RewardType = 2,
                        PUserID = item.Key,
                        PUserKind = (int)await pUserDCache.GetUserKindAsync(),
                        Bonus = inviteNumConfig.Bonus,
                        FlowMultip = inviteNumConfig.FlowMultip,
                        RecDate = recDate,
                        ValidUserCount = item.Value,
                        MonthDate = Convert.ToDateTime(startTime).Date,
                        ReceiveStatus = false
                    });
                    ret.Items.Add(new InviteItem() { 
                        pUserId = item.Key,
                        UserCount = item.Value,
                        Bonus = inviteNumConfig.Bonus
                    });
                }
            }

            if (inviteDetailList == null || !inviteDetailList.Any())
            {
                _logger.LogInformation($"InviteNewuserService.没有符合条件的数据.{JsonConvert.SerializeObject(inviteDetailList)}");
                return ret;
            }

            TransactionManager tm = new TransactionManager();

            try
            {

                //写库、发通知
                foreach (var item in inviteDetailList)
                {
                    await inviteDetailMo.AddAsync(item, tm);
                }

                tm.Commit();

                #region 发通知

                foreach (var item in inviteDetailList)
                {
                    var notifyCommand = new InviteNewuserNotifyCommand();
                    notifyCommand.UserId = item.PUserID;
                    notifyCommand.OperatorId = item.OperatorID;
                    notifyCommand.CountryId = item.CountryId;
                    notifyCommand.CurrencyId = item.CurrencyID;
                    notifyCommand.RewardAmount = item.Bonus;
                    notifyCommand.FlowMultip = item.FlowMultip;
                    notifyCommand.RewardSourceId = item.DetailID;
                    notifyCommand.IsSendNotify = ipo.Activity.activityEntity.IsSendNotify;
                    notifyCommand.IsSendNotifyEmail = ipo.Activity.activityEntity.IsSendNotifyEmail;
                    await _mediator.Send(notifyCommand);
                }

                #endregion

            }
            catch (Exception ex)
            {
                _logger.LogError($"InviteNewuserService.error:{ex.Message}");
            }



            return ret;
        }

        /// <summary>
        /// 校验好友邀请分享活动是否有效
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task<bool> CheckActivity(InviteNewuserIpo ipo)
        { 
            ipo.Activity = await QuartzUtils.GetActivityIsOpen(ipo.OperatorId, ipo.CurrencyId, ActivityType.InvitationNewUser100011, System.Diagnostics.ActivityEvent.Pay);

            if (!ipo.Activity.IsValid)
                return false;

            return true;
        }

    }

    /// <summary>
    /// 推广员对应的有效数量人数
    /// </summary>
    public class PromoterValidQuantity
    { 
        /// <summary>
        /// 推广员用户编码
        /// </summary>
        public string PUserId { get; set; }

        /// <summary>
        /// 推广员有效邀请用户数量
        /// </summary>
        public int ValidQuantity { get; set; }
    }

}
