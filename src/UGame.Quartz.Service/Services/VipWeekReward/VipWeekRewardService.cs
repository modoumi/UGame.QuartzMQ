using MediatR;
using Microsoft.Extensions.Logging;
using SqlSugar;
using TinyFx;
using TinyFx.Data;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using TinyFx.Text;
using UGame.Quartz.Service.Commands;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Xxyy;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.VipWeekReward
{
    /// <summary>
    /// vip每周发放奖励服务类
    /// </summary>
    public class VipWeekRewardService
    {
        ILogger<VipWeekRewardService> _logger;
        private Sc_vip_configMO _vipConfigMO = new();
        private Sc_vip_reward_detailMO _vipRewardDetailMO = new();
        private S_userMO _s_UserMO = new();
        private Sb_bank_orderMO _sbbBankMO = new();
        private S_provider_orderMO _s_Provider_OrderMO = new();
        IMediator _mediator;

        public VipWeekRewardService(IMediator mediator)
        {
            _logger = LogUtil.CreateLogger<VipWeekRewardService>();
            _mediator = mediator;
        }


        private async Task<int> GetOperatorTimeZone(string operatorId)
        {
            try
            {
                var operatorEo = await DbUtil.GetRepository<S_operatorPO>().AsQueryable()
                    .Where(d => d.OperatorID.Equals(operatorId)).FirstAsync();

                if (operatorEo == null)
                    throw new CustomException($"s_operator找不到operatorId:{operatorId}");

                var countryEo = await DbUtil.GetRepository<S_countryPO>().AsQueryable()
                    .Where(d => d.CountryID.Equals(operatorEo.CountryID))
                    .FirstAsync();

                return Math.Abs(countryEo.TimeZone);
            }
            catch (Exception ex)
            {
                LogUtil.GetContextLogger().AddException(ex)
                    .AddMessage("Xxyy_Quartz_BLL_Services_VipWeekReward_GetOperatorTimeZone")
                    .AddField("errorMsg", ex.Message);
                return 0;
            }



        }

        public async Task<VipWeekRewardDto> Execute(VipWeekRewardIpo ipo)
        {
            var ret = new VipWeekRewardDto();

            //当前日期
            var _grantDate = (
                    !string.IsNullOrWhiteSpace(ipo.GrantDate) && DateTime.TryParse(ipo.GrantDate, out DateTime grantDate)
                    ) 
                    ? grantDate.Date 
                    : DateTime.UtcNow.ToLocalTime(ipo.OperatorID).Date;

            //当前operator与utc时差绝对值
            var timeZone = await GetOperatorTimeZone(ipo.OperatorID);
            //当前日期所属周的第一天日期
            var weekFirstDay = DateTimeUtil.BeginDayOfWeek(_grantDate);
            //当前日期所属周的最后一天日期
            var weekLastDay =DateTimeUtil.EndDayOfWeek(_grantDate);
            ret.dayId = weekFirstDay.ToString("yyyy-MM-dd");
            //当前operatorId对应的本月第一天时间
            var monthFirstDay = _grantDate.AddDays(1 - _grantDate.Day).Date.AddHours(timeZone);
            //当前operatorId对应的下月第一天时间
            var monthLastDay = _grantDate.AddDays(1 - _grantDate.Day).AddMonths(1).Date.AddHours(timeZone);
            //查询s_provider_order表起始日期
            var searchProviderOrderStartDate = monthLastDay.AddDays(-2);
            //当前OperatorId有周奖励的vip配置
            var weekRewardVipConfigEoList = DbUtil.GetRepository<Sc_vip_configPO>().AsQueryable()
                .Where(d => d.OperatorID.Equals(ipo.OperatorID) && d.WeekReward > 0)
                .OrderBy(d => d.VipGrade)
                .ToList();

            if (weekRewardVipConfigEoList == null || !weekRewardVipConfigEoList.Any())
                return ret;

            //有周奖励的最小vip等级
            var minWeekRewardVip = weekRewardVipConfigEoList.Select(d => d.VipGrade).Min();

            var userList = await DbUtil.GetRepository<S_userPO>().AsQueryable()
                .Where(d => d.OperatorID.Equals(ipo.OperatorID) && d.VIP > minWeekRewardVip && d.Status == 1)
                .ToListAsync();

            var bankOrderRsp = DbUtil.GetRepository<Sb_bank_orderPO>();
            var userDayRsp = DbUtil.GetRepository<Sr_user_dayPO>();
            var providerOrderRsp = DbUtil.GetRepository<S_provider_orderPO>();
            var vipRewardDetailRsp = DbUtil.GetRepository<Sc_vip_reward_detailPO>();

            if (userList == null || !userList.Any())
                return ret;

            var userCount = 0;

            foreach (var user in userList)
            {
                //当前用户本月充值次数
                var userPayCount = await bankOrderRsp.AsQueryable()
                    .Where(d => d.UserID.Equals(user.UserID) && d.RecDate >= monthFirstDay && d.RecDate < monthLastDay && d.OrderType == 1 && d.Status == 2)
                    .Select(d => SqlFunc.AggregateCount(d.OrderID))
                    .CountAsync();

                if (userPayCount == 0)
                {
                    ret.noPayUserList.Add(new VipWeekRewardDetailInfo { userId = user.UserID, vip = user.VIP, reward = 0 });
                    continue;
                }

                //sr_user_day当前用户本月真金下注
                var userCashBetCount = await userDayRsp.AsQueryable()
                    .Where(d => d.DayID >= monthFirstDay.Date && d.DayID < monthLastDay.Date && d.UserID.Equals(user.UserID) && (d.BetAmount - d.BetBonus) > 0)
                    .Select(d => SqlFunc.AggregateCount(d.DayID))
                    .CountAsync();

                if (userCashBetCount == 0)
                {
                    //s_provider_order缓存三天数据，所有不用加时间限制
                    //s_provider_order当前用户是否有真金下注
                    userCashBetCount = await providerOrderRsp.AsQueryable()
                        .Where(d => d.RecDate >= monthFirstDay && d.RecDate < monthLastDay && d.UserID.Equals(user.UserID) && (d.PlanBet - d.BetBonus) > 0)
                        .Select(d => SqlFunc.AggregateCount(d.OrderID))
                        .CountAsync();

                    if (userCashBetCount == 0)
                    {
                        ret.noBetUserList.Add(new VipWeekRewardDetailInfo { userId = user.UserID, vip = user.VIP, reward = 0 });
                        continue;
                    }
                }

                //vip领取奖励表判断本周是否发放过奖励
                var rewardCount = await vipRewardDetailRsp.AsQueryable()
                    .Where(d => d.UserID.Equals(user.UserID) && d.RewardType == 2 && d.RewardDate >= weekFirstDay && d.RewardDate <= weekLastDay)
                    .Select(d => SqlFunc.AggregateCount(d.DetailID))
                    .CountAsync();

                if (rewardCount > 0)
                    continue;

                //找到当前用户vip等级对应的配置
                var curVipConfig = weekRewardVipConfigEoList.Where(d => d.VipGrade == user.VIP && d.WeekReward > 0).FirstOrDefault();
                if (curVipConfig == null) continue;

                //发放奖励
                var tm = new DbTransactionManager();

                try
                {
                    var rewardDetailEo = new Sc_vip_reward_detailPO()
                    {
                        DetailID = ObjectId.NewId(),
                        UserID = user.UserID,
                        OperatorID = user.OperatorID,
                        CountryID = user.CountryID,
                        CurrencyID = user.CurrencyID,
                        VipGrade = user.VIP,
                        RewardAmount = curVipConfig.WeekReward,
                        RewardType = 2,
                        NotifyStatus = 0,
                        ReceiveStatus = 0,
                        RecDate = DateTime.UtcNow,
                        RewardDate = weekFirstDay,
                        UserKind = user.UserKind,
                        FromId = user.FromId,
                        FromMode = user.FromMode
                    };

                    await tm.GetRepository<Sc_vip_reward_detailPO>().InsertAsync(rewardDetailEo);

                    tm.Commit();

                    userCount++;
                    ret.rewardUserList.Add(new VipWeekRewardDetailInfo { userId = user.UserID, vip = user.VIP, reward = curVipConfig.WeekReward.AToM(user.CurrencyID) });

                    //发送邮件通知
                    var notifyCommand = new VipWeekRewardNotifyCommand();
                    notifyCommand.UserId = user.UserID;
                    notifyCommand.OperatorId = user.OperatorID;
                    notifyCommand.CountryId = user.CountryID;
                    notifyCommand.CurrencyId = user.CurrencyID;
                    notifyCommand.RewardAmount = curVipConfig.WeekReward;
                    notifyCommand.FlowMultip = curVipConfig.WeekFlowMultip;
                    notifyCommand.RewardSourceId = rewardDetailEo.DetailID;
                    notifyCommand.AfterNofify = async (string rewardSourceId) =>
                    {
                        return await _vipRewardDetailMO.PutNotifyStatusByPKAsync(rewardSourceId, 1);
                    };
                    await _mediator.Send(notifyCommand);

                }
                catch (Exception)
                {
                    tm.Rollback();
                    throw;
                }
            }


            return ret;
        }

        /// <summary>
        /// vip每周发放奖励业务逻辑
        /// </summary>
        /// <returns></returns>
        [Obsolete("2024-01-24前使用")]
        public async Task<VipWeekRewardDto> ExecuteOld(VipWeekRewardIpo ipo)
        {
            VipWeekRewardDto ret = new VipWeekRewardDto();
            try
            {
                var _grantDate = (!string.IsNullOrWhiteSpace(ipo.GrantDate) && DateTime.TryParse(ipo.GrantDate, out DateTime grantDate)) ? grantDate.Date : DateTime.UtcNow.ToLocalTime(ipo.OperatorID).Date;
                //当前日期所属周的周一日期
                var _monday = _grantDate.AddDays(1 - Convert.ToInt32(_grantDate.DayOfWeek.ToString("d"))).Date;//本周一
                //当前日期所属周的周一日期
                var thisWeeklyFirstDay =DateTimeUtil.BeginDayOfWeek(_grantDate);
                //本月第一天零点
                var monthFirstDay = _grantDate.AddDays(1 - _grantDate.Day).Date;
                var monthFirstDay1 = new DateTime(_grantDate.Year, _grantDate.Month, 1, 0, 0, 0);
                //下个月第一天的零点
                var monthLastDay = _grantDate.AddDays(1 - _grantDate.Day).AddMonths(1).Date;
                var monthLastDay1 = new DateTime(_grantDate.AddMonths(1).Year, _grantDate.AddMonths(1).Month, 1, 0, 0, 0);

                var vipConfigList = await _vipConfigMO.GetAsync("OperatorID=@operatorId", ipo.OperatorID);
                var hasWeekRewardVipList = vipConfigList.Where(v => v.WeekReward > 0).OrderBy(v => v.VipGrade).ToList();//有周奖励的vip等级

                if (hasWeekRewardVipList.Any())
                {
                    var minVip = hasWeekRewardVipList.Select(v => v.VipGrade).Min();//有周奖励的最小vip等级

                    #region 筛选s_user所有大于minVip的正式用户

                    var userList = await _s_UserMO.GetAsync("VIP>=@minVip and Status=1 and OperatorId = @OperatorId", minVip, ipo.OperatorID);

                    userList = userList.Where(d => d.UserID.Equals("65af7e8809238940a25a0177")).ToList();

                    #endregion

                    if (userList.Any())
                    {
                        ret.rewardUserList = new List<VipWeekRewardDetailInfo>();
                        ret.noBetUserList = new List<VipWeekRewardDetailInfo>();
                        ret.noPayUserList = new List<VipWeekRewardDetailInfo>();
                        ret.dayId = _monday.ToString("yyyy-MM-dd");
                        var _userCount = 0;

                        foreach (var user in userList)
                        {
                            #region 筛选本月有没有充值并下注

                            //本月有充值
                            var payList = await _sbbBankMO.GetAsync("UserID=@userId and OrderType = 1 and Status=2 and DATE_SUB(RecDate, INTERVAL 3 HOUR)>=@monthFirstDay and DATE_SUB(RecDate, INTERVAL 3 HOUR)<@monthLastDay", user.UserID, monthFirstDay, monthLastDay);
                            if (payList == null || !payList.Any())
                            {
                                ret.noPayUserList.Add(new VipWeekRewardDetailInfo { userId = user.UserID, vip = user.VIP, reward = 0 });
                                continue;
                            }

                            //本月有真金下注
                            var betList = await _s_Provider_OrderMO.GetAsync("UserID=@userId and (ReqMark=1 or ReqMark=3) and Status=2 and PlanBet-BetBonus>0 and CurrencyType=9 and DATE_SUB(RecDate, INTERVAL 3 HOUR)>=@monthFirstDay and DATE_SUB(RecDate, INTERVAL 3 HOUR)<@monthLastDay", user.UserID, monthFirstDay, monthLastDay);
                            if (betList == null || !betList.Any())
                            {
                                ret.noBetUserList.Add(new VipWeekRewardDetailInfo { userId = user.UserID, vip = user.VIP, reward = 0 });
                                continue;
                            }

                            #endregion

                            #region vip领取奖励表判断本周是否发放过奖励

                            var rewardList = await _vipRewardDetailMO.GetAsync("UserID=@userId and RewardType=2 and RewardDate=@monday", user.UserID, _monday);
                            if (rewardList != null && rewardList.Any()) continue;

                            #endregion

                            #region 满足上述条件，发放奖励，并发邮件
                            TransactionManager tm = new TransactionManager();
                            try
                            {
                                var curVipConfig = hasWeekRewardVipList.Where(v => v.VipGrade == user.VIP).First();
                                if (curVipConfig == null) continue;
                                var rewardDetail = new Sc_vip_reward_detailEO
                                {
                                    DetailID = ObjectId.NewId(),
                                    UserID = user.UserID,
                                    OperatorID = user.OperatorID,
                                    CountryID = user.CountryID,
                                    CurrencyID = user.CurrencyID,
                                    VipGrade = user.VIP,
                                    RewardAmount = curVipConfig.WeekReward,
                                    RewardType = 2,
                                    NotifyStatus = 0,
                                    ReceiveStatus = 0,
                                    RecDate = DateTime.UtcNow,
                                    RewardDate = _monday,
                                    UserKind = user.UserKind,
                                    FromId = user.FromId,
                                    FromMode = user.FromMode
                                };

                                if (await _vipRewardDetailMO.AddAsync(rewardDetail, tm) < 1)
                                    throw new Exception("vip周奖励发放失败");

                                tm.Commit();

                                _userCount++;
                                ret.rewardUserList.Add(new VipWeekRewardDetailInfo { userId = user.UserID, vip = user.VIP, reward = curVipConfig.WeekReward.AToM(user.CurrencyID) });
                            }
                            catch (Exception)
                            {
                                tm.Rollback();
                                throw;
                            }
                            #endregion
                        }

                        ret.userCount = _userCount;

                        #region 发通知

                        var toNotifyUsers = await _vipRewardDetailMO.GetAsync("NotifyStatus=0 and RewardType=2");
                        if (toNotifyUsers != null && toNotifyUsers.Count > 0)
                        {
                            foreach (var _notiUser in toNotifyUsers)
                            {
                                VipWeekRewardNotifyCommand notifyCommand = new VipWeekRewardNotifyCommand();
                                notifyCommand.UserId = _notiUser.UserID;
                                notifyCommand.OperatorId = _notiUser.OperatorID;
                                notifyCommand.CountryId = _notiUser.CountryID;
                                notifyCommand.CurrencyId = _notiUser.CurrencyID;
                                notifyCommand.RewardAmount = _notiUser.RewardAmount;
                                notifyCommand.FlowMultip = _notiUser.FlowMultip;
                                notifyCommand.RewardSourceId = _notiUser.DetailID;
                                notifyCommand.AfterNofify = async (string rewardSourceId) =>
                                {
                                    return await _vipRewardDetailMO.PutNotifyStatusByPKAsync(rewardSourceId, 1);
                                };
                                await _mediator.Send(notifyCommand);
                            }
                        }

                        #endregion
                    }
                }
                return ret;

            }
            catch (Exception ex)
            {
                ret.rewardUserList.Clear();
                ret.noBetUserList.Clear();
                ret.noPayUserList.Clear();
                ret.userCount = 0;
                _logger.LogError(ex, "执行定时任务Vip发放周奖励时，出现异常");
                return ret;
            }
        }


        /// <summary>
        /// vip升级奖励每日发放
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<VipUpRewardDto> VipUpExecute(VipUpRewardIpo ipo)
        {
            //非全量数据
            return await UnAllVipUpData(ipo);
        }

        private async Task<List<string>> GetUserIdsForRedis(DateTime localDate, string operatorId)
        {
            try
            {
                var cache = await DayOperatorUserIdsDCache.Create(localDate.ToString("yyyyMMdd").ToInt32(), operatorId, DayUserIdsType.Bet);
                var userIds = await cache.GetAllAsync();

                if (userIds == null || !userIds.Any())
                    return new List<string>();

                return userIds.ToList();
            }
            catch (Exception)
            {
                return new List<string>();
            }

        }

        /// <summary>
        /// 非全量数据，s_provider.userId group
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<VipUpRewardDto> UnAllVipUpData(VipUpRewardIpo ipo)
        {
            var ret = new VipUpRewardDto();

            //当地日期
            var localDate = ipo.UtcNow.ToLocalTime(ipo.OperatorID).Date;
            //需要统计数据的日期
            var dataDate = localDate.AddDays(-1);

            ret.dayId = ipo.UtcNow.ToString("yyyy-MM-dd");

            if (ipo.UserIds == null || !ipo.UserIds.Any())
                ipo.UserIds = await GetUserIdsForRedis(dataDate, ipo.OperatorID);

            if (ipo.UserIds == null || !ipo.UserIds.Any())
                return ret;

            //ipo.UserIds = ipo.UserIds.Where(d => d.Equals("64f0a195715614cd1cd09a57")).ToList();

            //s_userMo
            var userMo = new S_userMO();
            //sc_vip_configMo
            var vipConfigMo = new Sc_vip_configMO();
            //sc_vip_reward_detailMo
            var vipRewardDetailMo = new Sc_vip_reward_detailMO();
            //vip配置
            var vipConfigEoList = await vipConfigMo.GetSortAsync("OperatorId = @OperatorId", "VipGrade", ipo.OperatorID);
            if (vipConfigEoList == null || !vipConfigEoList.Any())
                return ret;

            var sql = $@"select 
	                        UserID
                        from s_provider_order 
                        where OperatorID = @OperatorId 
                        and RecDate >= @StartTime
                        and RecDate < @EndTime
                        group by UserID;";

            //数据查询区间
            var country = DbCacheUtil.GetCountryByOperatorId(ipo.OperatorID);
            var startTime = ipo.UtcNow.AddDays(-1).ToString($"yyyy-MM-dd {Math.Abs(country.TimeZone)}:00:00");
            var endTime = ipo.UtcNow.ToString($"yyyy-MM-dd {Math.Abs(country.TimeZone)}:00:00");

            var providerOrderUserList = new List<string>();

            if (ipo.UserIds == null || !ipo.UserIds.Any())
            {
                //时间区间内，有下注记录的用户集合
                providerOrderUserList = await DbSink.MainDb.ExecSqlListAsync<string>(sql, ipo.OperatorID, startTime, endTime);
            }
            else
            {
                providerOrderUserList = ipo.UserIds;
            }

            if (providerOrderUserList == null || !providerOrderUserList.Any())
                return ret;
           
            //vip配置需要达到的最小下注值
            var vipBetMinAmount = vipConfigEoList.Min(d => d.BetMinAmount);
            //vip配置需要达到的最小下注值
            var vipBetMaxAmount = vipConfigEoList.Max(d => d.BetMaxAmount);
            //起始页
            var index = 1;
            //页大小
            var limit = 100;
            //总页数
            var totalPage = providerOrderUserList.Count() / limit + (providerOrderUserList.Count() % limit > 0 ? 1 : 0);

            for (int i = index; i <= totalPage; i++)
            {
                var userIds = string.Join("','", providerOrderUserList.Skip((i - 1) * limit).Take(limit).ToList());
                var userEoList = await userMo.GetAsync($"UserId in('{userIds}')");
                if (userEoList == null || !userEoList.Any())
                    continue;

                await VipUpRewardProcess(userEoList, vipConfigEoList, vipBetMinAmount, vipBetMaxAmount, userMo, ipo.UtcNow, vipRewardDetailMo, ret);
            }

            return ret;
        }

        private async Task VipUpRewardProcess(List<S_userEO> userEoList, List<Sc_vip_configEO> vipConfigEoList, long vipBetMinAmount, long vipBetMaxAmount, S_userMO userMo, DateTime utcNow, Sc_vip_reward_detailMO vipRewardDetailMo, VipUpRewardDto dto)
        {
            TransactionManager tm = new TransactionManager();

            try
            {
                //需要写入sc_vip_reward_detail表的数据
                List<Sc_vip_reward_detailEO> vipRewardDetailEoList = new List<Sc_vip_reward_detailEO>();
                var messages = new List<VipUpgradeMsg>();
                foreach (var item in userEoList)
                {
                    var fromVipGrade = item.VIP;
                    var toVipGrade = fromVipGrade;
                    if (item.Point >= vipBetMinAmount)
                    {
                        var currVipConfigEo = vipConfigEoList.Where(d => item.Point >= d.BetMinAmount && item.Point < d.BetMaxAmount).FirstOrDefault();

                        if (item.Point > vipBetMaxAmount)
                        {
                            currVipConfigEo = vipConfigEoList.Where(d => d.BetMinAmount == vipBetMaxAmount).FirstOrDefault();
                        }
                        toVipGrade = currVipConfigEo.VipGrade;
                        if (currVipConfigEo != null && currVipConfigEo.VipGrade > item.VIP)
                        {
                            await userMo.PutVIPByPKAsync(item.UserID, currVipConfigEo.VipGrade, tm);

                            //vip升级奖励金额
                            var rewardBonus = currVipConfigEo.GradeReward;
                            vipRewardDetailEoList.Add(new Sc_vip_reward_detailEO()
                            {
                                DetailID = ObjectId.NewId(),
                                UserID = item.UserID,
                                OperatorID = item.OperatorID,
                                CountryID = item.CountryID,
                                CurrencyID = item.CurrencyID,
                                VipGrade = currVipConfigEo.VipGrade,
                                RewardAmount = currVipConfigEo.GradeReward,
                                RewardType = 1,
                                NotifyStatus = 0,
                                ReceiveStatus = 0,
                                RecDate = utcNow,
                                RewardDate = utcNow.Date,
                                FlowMultip = currVipConfigEo.GradeFlowMultip,
                                UserKind = item.UserKind,
                                FromId = item.FromId,
                                FromMode = item.FromMode
                            });

                            if (currVipConfigEo.VipGrade - item.VIP > 1)
                            {
                                var rewardHistory = await vipRewardDetailMo.GetAsync("UserID = @UserID and VipGrade > @curGrade and VipGrade < @VipGrade and RewardType = 1 ", item.UserID, item.VIP, currVipConfigEo.VipGrade);
                                if (rewardHistory == null || rewardHistory.Count() == 0)
                                {
                                    for (int j = item.VIP + 1; j < currVipConfigEo.VipGrade; j++)
                                    {
                                        var _crossVipConfig = vipConfigEoList.Where(c => c.VipGrade == j).FirstOrDefault();
                                        if (_crossVipConfig != null)
                                        {
                                            rewardBonus += _crossVipConfig.GradeReward;
                                            //依次插入跨过的vip等级奖励领取详情
                                            vipRewardDetailEoList.Add(new Sc_vip_reward_detailEO
                                            {
                                                DetailID = ObjectId.NewId(),
                                                UserID = item.UserID,
                                                OperatorID = item.OperatorID,
                                                CountryID = item.CountryID,
                                                CurrencyID = item.CurrencyID,
                                                VipGrade = j,
                                                RewardAmount = _crossVipConfig.GradeReward,
                                                RewardType = 1,
                                                NotifyStatus = 0,
                                                ReceiveStatus = 0,
                                                RecDate = DateTime.UtcNow,
                                                RewardDate = DateTime.UtcNow.Date,
                                                UserKind = item.UserKind,
                                                FromId = item.FromId,
                                                FromMode = item.FromMode
                                            });
                                        }
                                    }
                                }
                            }
                        }

                        messages.Add(new VipUpgradeMsg
                        {
                            UserId = item.UserID,
                            Point = item.Point,
                            VipFrom = fromVipGrade,
                            VipTo = toVipGrade,
                            UpgradeTime = DateTime.UtcNow
                        });
                    }
                }

                await vipRewardDetailMo.AddByBatchAsync(vipRewardDetailEoList, vipRewardDetailEoList.Count, tm);
                tm.Commit();

                dto.userCount = vipRewardDetailEoList.GroupBy(d => d.UserID).Count();

                //发送通知
                foreach (var item in vipRewardDetailEoList)
                {
                    VipUpRewardNotifyCommand notifyCommand = new VipUpRewardNotifyCommand();
                    notifyCommand.UserId = item.UserID;
                    notifyCommand.OperatorId = item.OperatorID;
                    notifyCommand.CountryId = item.CountryID;
                    notifyCommand.CurrencyId = item.CurrencyID;
                    notifyCommand.RewardAmount = item.RewardAmount;
                    notifyCommand.FlowMultip = item.FlowMultip;
                    notifyCommand.RewardSourceId = item.DetailID;
                    notifyCommand.AfterNofify = async (string rewardSourceId) =>
                    {
                        return await vipRewardDetailMo.PutNotifyStatusByPKAsync(rewardSourceId, 1);
                    };
                    await _mediator.Send(notifyCommand);
                }
                foreach (var message in messages)
                {
                    await MQUtil.PublishAsync(message);
                }
            }
            catch (Exception ex)
            {
                tm.Rollback();
            }
        }
    }
}
