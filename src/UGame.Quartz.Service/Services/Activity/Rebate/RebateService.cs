using MediatR;
using SqlSugar;
using System.Data;
using System.Text;
using TinyFx;
using TinyFx.Collections;
using TinyFx.Data;
using TinyFx.Data.MySql;
using TinyFx.Logging;
using TinyFx.Text;
using UGame.Quartz.Service.Commands;
using UGame.Quartz.Service.Common;
using UGame.Quartz.Service.Services.RebateWater;
using Xxyy.Common;
using Xxyy.Common.Caching;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.Activity.Rebate;

public class RebateService
{
    private readonly Sa_rebate_dayMO _rebateDayMo = new();
    private readonly Sa_rebate_user_detailMO _rebateUserDetailMo = new();
    private readonly Sa_rebate_quartz_configMO _quartzConfig = new();
    private readonly L_activity_operatorMO _activityOperatorMo = new();

    public RebateService()
    {
        _rebateDayMo.UseReadConnectionString = true;
        _rebateUserDetailMo.UseReadConnectionString = true;
        _quartzConfig.UseReadConnectionString = true;
        _activityOperatorMo.UseReadConnectionString = true;
    }
    #region 返水
    /// <summary>
    /// 统计返水
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<RebateWaterResponse> RebateWaterStatis(RebateWaterRequest request)
    {
        var result = new RebateWaterResponse();

        try
        {
            var activityId = request.Frequency switch
            {
                2 => (int)ActivityType.RebateWaterWeekly,
                3 => (int)ActivityType.RebateWaterMonthly,
                _ => (int)ActivityType.RebateWater
            };

            var builder = new StringBuilder("(");
            var parameters = new List<object> { activityId };
            for (int i = 0; i < request.OperatorIds.Count; i++)
            {
                if (i > 0) builder.Append(',');
                parameters.Add(request.OperatorIds[i]);
                builder.Append($"@OperatorId{i}");
            };
            builder.Append(")");
            var operatorIds = builder.ToString();

            var quartzConfigInfos = await _quartzConfig.GetAsync($"ActivityID=@ActivityID and OperatorID in {operatorIds}", parameters.ToArray());
            if (quartzConfigInfos == null || quartzConfigInfos.Count == 0)
                return result;
            if (request.OperatorIds == null || request.OperatorIds.Count == 0)
                throw new CustomException("OperatorIds参数不能为null");

            var allOperatorActivities = await _activityOperatorMo.GetAsync($"ActivityID=@ActivityID and Status=1 and OperatorID in {operatorIds}", parameters.ToArray());
            var needAddDetails = new List<Sa_rebate_user_detailEO>();
            var needNotifyList = new List<Sa_rebate_user_detailEO>();
            foreach (var quartzConfigInfo in quartzConfigInfos)
            {
                if (allOperatorActivities == null || allOperatorActivities.Count == 0)
                    continue;

                var operatorActivity = allOperatorActivities.Find(d => d.OperatorID == quartzConfigInfo.OperatorID && d.CurrencyID == quartzConfigInfo.CurrencyID);
                if (operatorActivity == null)
                    continue;

                DateTime dayId = default;
                DateTime beginDate = default;
                DateTime endDate = default;

                //活动配置
                dayId = DateTime.UtcNow.ToLocalTime(quartzConfigInfo.OperatorID).Date;
                builder.Clear();
                builder.Append("OperatorId=@OperatorId and ActivityID=@ActivityID and CurrencyID=@CurrencyID");
                parameters = new List<object> { quartzConfigInfo.OperatorID, activityId, quartzConfigInfo.CurrencyID };

                switch (request.Frequency)
                {
                    case 1:
                        dayId = dayId.AddDays(-1);
                        break;
                    case 2:
                        //发放上周的奖励
                        endDate =DateTimeUtil.BeginDayOfWeek(dayId);
                        beginDate = endDate.AddDays(-7);
                        dayId = beginDate;
                        break;
                    case 3:
                        //发放上个月的奖励
                        endDate =DateTimeUtil.LastDayOfPrdviousMonth(dayId).AddDays(1);
                        beginDate = endDate.AddMonths(-1);
                        dayId = beginDate;
                        break;
                };
                builder.Append(" and DayId=@DayId");
                parameters.Add(dayId);

                //返奖类型 1-bonus 2-真金 3-bonus+真金
                int rewardType = operatorActivity.IsBonus ? 1 : 2;
                var whereSql = builder.ToString();
                var sql = builder.Insert(0, "select distinct UserID from sa_rebate_day where ").ToString();
                //获取当前Operator下所有下注的用户ID
                var database = new MySqlDatabase();
                var userIds = await database.ExecSqlListAsync<string>(sql, parameters.ToArray());
                int bulkCount = 1000;
                builder.Clear();
                var headSql = whereSql + " and UserID IN (";
                builder.Append(headSql);
                int index = 0;
                foreach (var userId in userIds)
                {
                    if (index > 0) builder.Append(',');
                    builder.Append($"'{userId}'");
                    if (index < bulkCount)
                    {
                        index++;
                        continue;
                    }
                    builder.Append(')');
                    sql = builder.ToString();
                    await this.ProcessRebateBatchUsers(dayId, activityId, rewardType, operatorActivity,
                        needAddDetails, needNotifyList, quartzConfigInfo, sql, parameters.ToArray());
                    await this.SaveToDbAndNotifyUser(operatorActivity, needAddDetails, needNotifyList);
                    needAddDetails.Clear();
                    needNotifyList.Clear();
                    builder.Clear();
                    builder.Append(headSql);
                    index = 0;
                }
                if (index > 0)
                {
                    builder.Append(')');
                    sql = builder.ToString();
                    await this.ProcessRebateBatchUsers(dayId, activityId, rewardType, operatorActivity,
                        needAddDetails, needNotifyList, quartzConfigInfo, sql, parameters.ToArray());
                    await this.SaveToDbAndNotifyUser(operatorActivity, needAddDetails, needNotifyList);
                    needAddDetails.Clear();
                    needNotifyList.Clear();
                }
            }
        }
        catch (Exception ex)
        {
            LogUtil.Error(ex);
            result.Success = false;
            result.Message = ex.Message;
        }
        return result;
    }
    private async Task ProcessRebateBatchUsers(DateTime dayId, int activityId, int rewardType, L_activity_operatorEO operatorActivity,
        List<Sa_rebate_user_detailEO> needAddDetails, List<Sa_rebate_user_detailEO> needNotifyList, Sa_rebate_quartz_configEO quartzConfigInfo, string sql, object[] parameters)
    {
        var allUserDailys = await _rebateDayMo.GetAsync(sql, parameters);
        //未下注，自动跳过
        if (allUserDailys == null || allUserDailys.Count == 0)
            return;

        var userDetails = await _rebateUserDetailMo.GetAsync(sql, parameters);
        if (userDetails != null && userDetails.Count > 0)
        {
            foreach (var userDetail in userDetails)
            {
                //用户已经统计过了，说明本次统计是重复执行，有未通知的，再通知一遍
                if (userDetail.NotifyStatus == 0 && (operatorActivity.IsSendNotify || operatorActivity.IsSendNotifyEmail))
                    needNotifyList.Add(userDetail);
                continue;
            }
            //排除已经发过奖励的下注用户
            allUserDailys = allUserDailys.FindAll(f => !userDetails.Exists(t => f.UserID == t.UserID));
        }
        var userIds = allUserDailys.Select(f => f.UserID).Distinct().ToList();
        foreach (var userId in userIds)
        {
            var userDaily = allUserDailys.Find(f => f.UserID == userId);
            if (userDaily == null) continue;
            //每个用户都要统计，发放金额满足最小金额1元，再发放，小于1元不发放
            double expectedRebateAmount = userDaily.EffectiveBetAmount * quartzConfigInfo.RewardRatio;
            if (expectedRebateAmount < quartzConfigInfo.MinAmount)
                continue;

            //不足一元的小数部分舍弃
            var minUnitAmount = 1d.MToA(quartzConfigInfo.CurrencyID);
            var factRebateAmount = (long)expectedRebateAmount / minUnitAmount * minUnitAmount;
            if (factRebateAmount > 0)
            {
                var userDCache = await GlobalUserDCache.Create(userId);
                var newUserDetail = new Sa_rebate_user_detailEO()
                {
                    DayID = dayId,
                    OperatorID = quartzConfigInfo.OperatorID,
                    CurrencyID = quartzConfigInfo.CurrencyID,
                    ActivityID = activityId,
                    CountryID = quartzConfigInfo.CountryID,
                    FlowMultip = quartzConfigInfo.FlowMultip,
                    DetailID = ObjectId.NewId(),
                    FromMode = await userDCache.GetFromModeAsync(),
                    FromId = await userDCache.GetFromIdAsync(),
                    UserKind = (int)await userDCache.GetUserKindAsync(),
                    RecDate = DateTime.UtcNow,
                    NotifyStatus = 1,
                    RebateAmount = factRebateAmount,
                    RebateType = 2,
                    UserID = userId,
                    ReceiveStatus = 0,
                    UpdateTime = DateTime.UtcNow,
                    Level = 0,
                    RewardType = rewardType
                };
                needAddDetails.Add(newUserDetail);
                needNotifyList.Add(newUserDetail);
            }
        }
    }
    private async Task SaveToDbAndNotifyUser(L_activity_operatorEO operatorActivity, List<Sa_rebate_user_detailEO> needAddDetails, List<Sa_rebate_user_detailEO> needNotifyList)
    {
        if (needAddDetails.Count == 0) return;
        var tm = new TransactionManager();
        try
        {
            await _rebateUserDetailMo.AddByBatchAsync(needAddDetails, needAddDetails.Count, tm);
            tm.Commit();
        }
        catch (Exception ex)
        {
            tm.Rollback();
            LogUtil.Error(ex);
        }

        foreach (var notifyUserDetail in needNotifyList)
        {
            #region 发送通知
            IMediator _mediator = DIUtil.GetService<IMediator>();
            var activityType = (ActivityType)operatorActivity.ActivityID;
            RebateWaterNotifyCommand notifyCommand = new RebateWaterNotifyCommand()
            {
                UserId = notifyUserDetail.UserID,
                OperatorId = notifyUserDetail.OperatorID,
                CountryId = notifyUserDetail.CountryID,
                CurrencyId = notifyUserDetail.CurrencyID,
                RewardFlagId = notifyUserDetail.ActivityID,
                SenderId = $"RebateWater.{activityType}",
                RewardAmount = notifyUserDetail.RebateAmount,
                FlowMultip = notifyUserDetail.FlowMultip,
                RewardSourceId = notifyUserDetail.DetailID,
                IsSendNotify = operatorActivity.IsSendNotify,
                IsSendNotifyEmail = operatorActivity.IsSendNotifyEmail,
                IsBonus = operatorActivity.IsBonus
            };
            await _mediator.Send(notifyCommand);
            #endregion
        }
    }
    #endregion
}
