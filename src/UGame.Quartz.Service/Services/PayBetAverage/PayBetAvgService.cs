using Newtonsoft.Json;
using SqlSugar;
using TinyFx;
using TinyFx.Data.SqlSugar;
using TinyFx.Logging;
using Xxyy.DAL;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.PayBetAverage;

public class PayBetAvgService
{
    /// <summary>
    /// 统计周期开始时间
    /// 注册用户单充/复充-人均下注次数
    /// 单日用户单充/复充-人均下注次数
    /// </summary>
    /// <param name="beginTime"></param>
    /// <returns></returns>
    public async Task ExcuteAsync(DateTime dayId)
    {
        dayId = DateTime.UtcNow.Date.AddDays(-3);
        var allOperatorId = await DbUtil.GetRepository<S_operatorPO>().AsQueryable()
            .Where(_ => _.Status == 1).Select(_ => _.OperatorID).ToListAsync();

        var providerMinDay = DbUtil.GetRepository<S_provider_orderPO>().AsQueryable().Min(_ => _.RecDate);

        if (dayId == default) { dayId = DateTime.UtcNow.Date.AddDays(-3); }

        while (dayId != default && dayId <= DateTime.UtcNow.Date.AddDays(-3))
        {
            foreach (var operatorId in allOperatorId)
            {
                #region 已跑过的数据不再重复执行

                var srOperDay = await DbUtil.GetRepository<Sr_oper_dayPO>().AsQueryable()
                    .Where(_ => _.DayID == dayId && _.OperatorID == operatorId).FirstAsync();

                if (srOperDay == null || srOperDay.RSPBet > 0 || srOperDay.RMPBet > 0 || srOperDay.PSPBet > 0 || srOperDay.PMPBet > 0) { continue; }

                #endregion

                #region 注册用户

                var result = new PayBetAvgResult() { DayId = dayId, OperatorId = operatorId };
                var payBetAvgIpo = new AvgDataIpo { DayId = dayId, OperatorId = operatorId, MinDay = providerMinDay };

                var registUsers = await DbUtil.GetRepository<S_userPO>().AsQueryable()
                    .Where(_ => _.OperatorID == operatorId && _.RegistDate.Value.ToString("yy-MM-dd") == dayId.ToString("yy-MM-dd"))
                    .Select(_ => _.UserID)
                    .ToListAsync();

                payBetAvgIpo.RegUsers = await GetPayUserByDate(operatorId, dayId, dayId.AddDays(3), registUsers);

                #endregion

                #region 充值用户

                //获取两天充值用户和充值日期
                payBetAvgIpo.PayUsers = await GetPayUserByDate(operatorId, dayId, dayId.AddDays(2), null);

                #endregion

                await OperDayData(payBetAvgIpo);

                await ChannelDayData(payBetAvgIpo);
            }
            dayId = dayId.AddDays(1);
        }
    }

    /// <summary>
    /// 统计OperatorId更新OperDay数据
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="dayId"></param>
    /// <param name="providerMinDay"></param>
    /// <returns></returns>
    private async Task OperDayData(AvgDataIpo ipo)
    {
        try
        {
            #region 注册用户

            var result = new PayBetAvgResult() { DayId = ipo.DayId, OperatorId = ipo.OperatorId };

            //注册用户单充
            var onePayUsers = ipo.RegUsers.GroupBy(_ => _.UserID)
                .Where(g => g.Count() == 1).Select(g => g.Key).ToList();

            //注册用户-单充-下注次数
            var regOnePayTotalBet = 0;
            if (ipo.DayId >= ipo.MinDay)
            {
                regOnePayTotalBet = await GetUserTotalBet(ipo.OperatorId, onePayUsers, ipo.DayId, ipo.DayId.AddDays(3));
            }
            else
            {
                if (onePayUsers.Count > 0)
                    regOnePayTotalBet = await GetUserListTotalBet(ipo.OperatorId, onePayUsers, ipo.DayId, ipo.DayId.AddDays(3), ipo.MinDay);
            }

            //注册用户-单充-人均-下注                   
            result.RSPBet = onePayUsers.Count == 0 ? 0 :
                (float)Math.Round((float)(regOnePayTotalBet / onePayUsers.Count), 2);


            //注册用户复充
            var regManyPayUsers = GetManyPayUser(ipo.RegUsers.Where(_ => !onePayUsers.Contains(_.UserID)).ToList());

            //注册用户-复充-下注次数
            var regManyPayTotalBet = 0;
            if (ipo.DayId >= ipo.MinDay)
            {
                foreach (var item in regManyPayUsers)
                {
                    regManyPayTotalBet += await DbUtil.GetRepository<S_provider_orderPO>().AsQueryable()
                   .Where(_ => _.OperatorID == ipo.OperatorId && item.UserID == _.UserID
                   && _.PlanBet > 0 && _.RecDate >= item.MinDate && _.RecDate <= item.MaxDate).CountAsync();
                }
            }
            else
            {
                foreach (var item in regManyPayUsers)
                {
                    regManyPayTotalBet = await GetUserTotalBet(ipo.OperatorId, item.UserID, item.MinDate, item.MaxDate.AddMilliseconds(1), ipo.MinDay);
                }
            }

            //注册用户-复充-人均-下注
            result.RMPBet = regManyPayUsers.Count == 0 ? 0 :
                (float)Math.Round((float)regManyPayTotalBet / regManyPayUsers.Count, 2);


            #endregion

            #region 充值用户

            //充值用户-单充人员
            var oneDayPayUsers = ipo.PayUsers
                .Where(_ => _.RecDate.ToString("yy-MM-dd") == ipo.DayId.ToString("yy-MM-dd"));

            //充值用户-单充人员-下注次数
            var oneDayPayUserIds = oneDayPayUsers.Select(_ => _.UserID).ToList();
            var oneDayPayTotalBet = 0;
            if (ipo.DayId >= ipo.MinDay)
            {
                oneDayPayTotalBet = await GetUserTotalBet(ipo.OperatorId, oneDayPayUserIds, ipo.DayId, ipo.DayId.AddDays(1));
            }
            else
            {
                if (oneDayPayUserIds.Count > 0)
                    oneDayPayTotalBet = await GetUserListTotalBet(ipo.OperatorId, oneDayPayUserIds, ipo.DayId, ipo.DayId.AddDays(1), ipo.MinDay);
            }

            //充值用户-单充人员-下注次数
            result.PSPBet = oneDayPayUsers.Count() == 0 ? 0 :
                (float)Math.Round((float)oneDayPayTotalBet / oneDayPayUsers.Count(), 2);


            //次日充值用户
            var twoDayPayUsers = ipo.PayUsers.Where(_ => _.RecDate.ToString("yy-MM-dd") == ipo.DayId.AddDays(1).ToString("yy-MM-dd"));

            //充值用户-复充人员
            var manyPayUserList = twoDayPayUsers.Union(oneDayPayUsers.Where(_ => twoDayPayUsers.Select(_ => _.UserID).Contains(_.UserID))).ToList();

            //充值用户-复充人员-下注次数
            var payManyTotalBet = 0;
            if (ipo.DayId >= ipo.MinDay)
            {
                payManyTotalBet = await GetUserTotalBet(ipo.OperatorId, manyPayUserList.Select(_ => _.UserID).ToList(), ipo.DayId, ipo.DayId.AddDays(2));
            }
            else
            {
                if (manyPayUserList.Select(_ => _.UserID).ToList().Count > 0)
                    payManyTotalBet = await GetUserListTotalBet(ipo.OperatorId, manyPayUserList.Select(_ => _.UserID).ToList(), ipo.DayId, ipo.DayId.AddDays(2), ipo.MinDay);
            }

            //充值用户-复充人员-下注次数
            result.PMPBet = manyPayUserList.Count == 0 ? 0 :
                (float)Math.Round((float)payManyTotalBet / manyPayUserList.Count, 2);

            #endregion

            await UpdateResultAsync(ipo.OperatorId, ipo.DayId, result);
        }
        catch (Exception ex)
        {
            LogUtil.GetContextLogger().AddException(new CustomException($"计算人均下注次数出错" + ex))
             .AddField("OperatorId", $"{ipo.OperatorId}")
             .AddField("DayId", $"{ipo.DayId}");
        }
    }

    /// <summary>
    /// 统计ChannelId更新ChannelDay数据
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private async Task ChannelDayData(AvgDataIpo ipo)
    {
        try
        {
            var regChannelId = ipo.RegUsers.Where(_ => _.FromMode == 2).GroupBy(_ => _.FromId).Select(g => g.Key).ToList();
            var payChannelId = ipo.PayUsers.Where(_ => _.FromMode == 2).GroupBy(_ => _.FromId).Select(g => g.Key).ToList();

            var allChannelIds = regChannelId.Union(payChannelId).Distinct().ToList();

            foreach (var channelId in allChannelIds)
            {
                var result = new PayBetAvgResult() { DayId = ipo.DayId, OperatorId = ipo.OperatorId, ChannelId = channelId };

                #region 注册用户
                //channelId注册用户单充
                var onePayUsers = ipo.RegUsers.Where(_ => _.FromId == channelId).GroupBy(_ => _.UserID)
               .Where(g => g.Count() == 1).Select(g => g.Key).ToList();

                //注册用户-单充-下注次数
                var regOnePayTotalBet = 0;
                if (ipo.DayId >= ipo.MinDay)
                {
                    regOnePayTotalBet = await GetUserTotalBet(ipo.OperatorId, onePayUsers, ipo.DayId, ipo.DayId.AddDays(3));
                }
                else
                {
                    if (onePayUsers.Count > 0)
                        regOnePayTotalBet = await GetUserListTotalBet(ipo.OperatorId, onePayUsers, ipo.DayId, ipo.DayId.AddDays(3), ipo.MinDay);
                }

                //注册用户-单充-人均-下注                   
                result.RSPBet = onePayUsers.Count == 0 ? 0 : (float)Math.Round((float)(regOnePayTotalBet / onePayUsers.Count), 2);


                //注册用户复充
                var regManyPayUsers = GetManyPayUser(ipo.RegUsers.Where(_ => _.FromId == channelId && !onePayUsers.Contains(_.UserID)).ToList());

                //注册用户-复充-下注次数
                var regManyPayTotalBet = 0;
                if (ipo.DayId >= ipo.MinDay)
                {
                    foreach (var item in regManyPayUsers)
                    {
                        regManyPayTotalBet += await DbUtil.GetRepository<S_provider_orderPO>().AsQueryable()
                       .Where(_ => _.OperatorID == ipo.OperatorId && item.UserID == _.UserID
                       && _.PlanBet > 0 && _.RecDate >= item.MinDate && _.RecDate <= item.MaxDate).CountAsync();
                    }
                }
                else
                {
                    foreach (var item in regManyPayUsers)
                    {
                        regManyPayTotalBet = await GetUserTotalBet(ipo.OperatorId, item.UserID, item.MinDate, item.MaxDate.AddMilliseconds(1), ipo.MinDay);
                    }
                }

                //注册用户-复充-人均-下注
                result.RMPBet = regManyPayUsers.Count == 0 ? 0 : (float)Math.Round((float)regManyPayTotalBet / regManyPayUsers.Count, 2);

                #endregion

                #region 充值用户

                //获取两天充值用户和充值日期
                //var payUsers = await GetPayUserByDate(operatorId, dayId, dayId.AddDays(2), null);

                //充值用户-单充人员
                var oneDayPayUsers = ipo.PayUsers.Where(_ => _.FromId == channelId && _.RecDate.ToString("yy-MM-dd") == ipo.DayId.ToString("yy-MM-dd"));

                //充值用户-单充人员-下注次数
                var oneDayPayTotalBet = 0;
                if (ipo.DayId >= ipo.MinDay)
                {
                    oneDayPayTotalBet = await GetUserTotalBet(ipo.OperatorId, oneDayPayUsers.Select(_ => _.UserID).ToList(), ipo.DayId, ipo.DayId.AddDays(1));
                }
                else
                {
                    if (oneDayPayUsers.Select(_ => _.UserID).ToList().Count > 0)
                        oneDayPayTotalBet = await GetUserListTotalBet(ipo.OperatorId, oneDayPayUsers.Select(_ => _.UserID).ToList(), ipo.DayId, ipo.DayId.AddDays(1), ipo.MinDay);
                }

                //充值用户-单充人员-下注次数
                result.PSPBet = oneDayPayUsers.Count() == 0 ? 0 : (float)Math.Round((float)oneDayPayTotalBet / oneDayPayUsers.Count(), 2);


                //次日充值用户
                var twoDayPayUsers = ipo.PayUsers.Where(_ => _.FromId == channelId && _.RecDate.ToString("yy-MM-dd") == ipo.DayId.AddDays(1).ToString("yy-MM-dd"));

                //充值用户-复充人员
                var manyPayUserList = twoDayPayUsers.Union(oneDayPayUsers.Where(_ => twoDayPayUsers.Select(_ => _.UserID).Contains(_.UserID))).ToList();

                //充值用户-复充人员-下注次数
                var payManyTotalBet = 0;
                if (ipo.DayId >= ipo.MinDay)
                {
                    payManyTotalBet = await GetUserTotalBet(ipo.OperatorId, manyPayUserList.Select(_ => _.UserID).ToList(), ipo.DayId, ipo.DayId.AddDays(2));
                }
                else
                {
                    if (manyPayUserList.Select(_ => _.UserID).ToList().Count > 0)
                        payManyTotalBet = await GetUserListTotalBet(ipo.OperatorId, manyPayUserList.Select(_ => _.UserID).ToList(), ipo.DayId, ipo.DayId.AddDays(2), ipo.MinDay);
                }

                //充值用户-复充人员-下注次数
                result.PMPBet = manyPayUserList.Count == 0 ? 0 : (float)Math.Round((float)payManyTotalBet / manyPayUserList.Count, 2);

                #endregion

                await UpdateResultCHAsync(ipo.OperatorId, ipo.DayId, result);
            }
        }
        catch (Exception ex)
        {
            LogUtil.GetContextLogger().AddException(new CustomException($"计算人均下注次数出错" + ex))
             .AddField("OperatorId", $"{ipo.OperatorId}")
             .AddField("DayId", $"{ipo.DayId}");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="userId"></param>
    /// <param name="beginDate"></param>
    /// <param name="endDate"></param>
    /// <param name="providerMinDay"></param>
    /// <returns></returns>
    private static async Task<int> GetUserTotalBet(string operatorId, string userId, DateTime beginDate, DateTime endDate, DateTime providerMinDay)
    {
        var totalBet = 0;
        var dayId = beginDate;
        while (dayId < endDate && dayId < providerMinDay)
        {
            var tableName = $"s_provider_order_{dayId:yyyyMMdd}";
            var where = $"OperatorID='{operatorId}' and UserId= '{userId}'  and PlanBet>0 and RecDate>='{beginDate:yyyy-MM-dd HH:mm:ss}' and RecDate<'{endDate:yyyy-MM-dd HH:mm:ss}'";
            var selectSql = $"SELECT COUNT(*) FROM {tableName} WHERE {where}";
            totalBet += DbUtil.GetDb().Ado.SqlQuery<int>(selectSql).FirstOrDefault();
            dayId = dayId.AddDays(1);
        }

        while (dayId < endDate && dayId >= providerMinDay)
        {
            totalBet += await DbUtil.GetRepository<S_provider_orderPO>().AsQueryable()
                      .Where(_ => _.OperatorID == operatorId && _.UserID == userId && _.PlanBet > 0 && _.RecDate >= dayId && _.RecDate < endDate)
                      .CountAsync();
            dayId = dayId.AddDays(1);
        }

        return totalBet;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="userId"></param>
    /// <param name="beginDate"></param>
    /// <param name="endDate"></param>
    /// <returns></returns>
    private static async Task<int> GetUserListTotalBet(string operatorId, List<string> userIds, DateTime beginDate, DateTime endDate, DateTime providerMinDay)
    {
        var totalBet = 0;
        var userIdStr = string.Empty;
        foreach (var item in userIds)
        {
            userIdStr += "'" + item + "',";
        }
        userIdStr = userIdStr.Substring(0, userIdStr.LastIndexOf(","));
        var dayId = beginDate;
        while (dayId < endDate && dayId < providerMinDay)
        {
            var tableName = $"s_provider_order_{dayId:yyyyMMdd}";
            var where = $"OperatorID='{operatorId}' and UserId in ({userIdStr})  and PlanBet>0 and RecDate>='{beginDate:yyyy-MM-dd HH:mm:ss}' and RecDate<'{endDate:yyyy-MM-dd HH:mm:ss}'";
            var selectSql = $"SELECT COUNT(*) FROM {tableName} WHERE {where}";
            totalBet += DbUtil.GetDb().Ado.SqlQuery<int>(selectSql).FirstOrDefault();
            dayId = dayId.AddDays(1);
        }

        while (dayId < endDate && dayId >= providerMinDay)
        {
            totalBet += await GetUserTotalBet(operatorId, userIds, dayId, endDate);
            dayId = dayId.AddDays(1);
        }

        return totalBet;
    }

    /// <summary>
    /// 获取用户时间段内下注总次数
    /// </summary>
    /// <returns></returns>
    private static async Task<int> GetUserTotalBet(string operatorId, List<string> userIds, DateTime beginDate, DateTime endDate)
    {
        var totalBet = await DbUtil.GetRepository<S_provider_orderPO>().AsQueryable()
                   .Where(_ => _.OperatorID == operatorId && userIds.Contains(_.UserID)
                   && _.PlanBet > 0 && _.RecDate >= beginDate && _.RecDate < endDate).CountAsync();

        return totalBet;
    }

    /// <summary>
    /// 获取时间段内充值用户
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="beginDate"></param>
    /// <param name="endDate"></param>
    /// <param name="userIds"></param>
    /// <returns></returns>
    private static async Task<List<UserDto>> GetPayUserByDate(string operatorId, DateTime beginDate, DateTime endDate, List<string> userIds = null)
    {
        var allPayUsers = await DbUtil.GetRepository<Sb_bank_orderPO>().AsQueryable()
            .WhereIF(userIds != null, _ => userIds.Contains(_.UserID))
            .Where(_ => _.OperatorID == operatorId && _.OrderType == 1 && _.Status == 2 && _.RecDate >= beginDate && _.RecDate < endDate)
            .Select(_ => new UserDto { UserID = _.UserID, FromId = _.FromId, FromMode = _.FromMode, RecDate = _.RecDate })
            .ToListAsync();

        return allPayUsers;
    }

    /// <summary>
    /// 多次充值用户信息
    /// </summary>
    /// <param name="userDto"></param>
    /// <returns></returns>
    private static List<UserPayDto> GetManyPayUser(List<UserDto> userDto)
    {
        var payUserList = new List<UserPayDto>();
        foreach (var item in userDto)
        {
            if (payUserList.Any(_ => _.UserID == item.UserID)) continue;

            var userPayDto = new UserPayDto
            {
                UserID = item.UserID,
                MinDate = userDto.Where(_ => item.UserID == _.UserID).Min(_ => _.RecDate),
                MaxDate = userDto.Where(_ => item.UserID == _.UserID).Max(_ => _.RecDate)
            };
            payUserList.Add(userPayDto);
        }
        return payUserList;
    }

    /// <summary>
    /// 更新结果集
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="beginTime"></param>
    /// <param name="result"></param>
    /// <returns></returns>
    private static async Task UpdateResultAsync(string operatorId, DateTime dayId, PayBetAvgResult result)
    {
        #region 填充Sr_Oper_Day表中字段

        var srOperDay = await DbUtil.GetRepository<Sr_oper_dayPO>().AsQueryable()
            .Where(_ => _.OperatorID == operatorId && _.DayID == dayId)
            .FirstAsync();

        if (srOperDay != default && result != default)
        {
            await DbUtil.UpdateAsync<Sr_oper_dayPO>(it => new Sr_oper_dayPO
            {
                RSPBet = result.RSPBet,
                RMPBet = result.RMPBet,
                PSPBet = result.PSPBet,
                PMPBet = result.PMPBet,
            }, it => it.OperatorID == operatorId && it.DayID == dayId);
        }

        #endregion
    }

    /// <summary>
    /// 更新channelId结果
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="dayId"></param>
    /// <param name="result"></param>
    /// <returns></returns>
    private static async Task UpdateResultCHAsync(string operatorId, DateTime dayId, PayBetAvgResult result)
    {
        #region 填充Sr_channel_day表中字段

        var srChannelDay = await DbUtil.GetRepository<Sr_channel_dayPO>().AsQueryable()
            .Where(_ => _.OperatorID == operatorId && _.DayID == dayId && _.ChannelID == result.ChannelId)
            .FirstAsync();

        if (srChannelDay != default)
        {
            await DbUtil.UpdateAsync<Sr_channel_dayPO>(it => new Sr_channel_dayPO
            {
                RSPBet = result.RSPBet,
                RMPBet = result.RMPBet,
                PSPBet = result.PSPBet,
                PMPBet = result.PMPBet,
            }, it => it.OperatorID == operatorId && it.DayID == dayId && it.ChannelID == result.ChannelId);
        }

        #endregion
    }
}
