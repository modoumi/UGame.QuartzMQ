using EasyNetQ;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Configuration;
using TinyFx.Data.MySql;
using TinyFx.Logging;
using TinyFx.Net;
using TinyFx.Reflection;
using TinyFx.Text;
using UGame.Quartz.Service.Common;
using UGame.Quartz.Service.Common.SqlSink;
using Xxyy.Common;
using Xxyy.DAL;
using UGame.Quartz.Repository;
using static System.Collections.Specialized.BitVector32;

namespace UGame.Quartz.Service.Services.DingTalk
{


    public class DingTalkService
    {

        S_provider_orderMO _providerOrderMo = new();

        S_appMO _appMo = new();

        S_operatorMO _operatorMO = new();

        Src_push_configMO _pushConfigMo = new();

        Src_push_messageMO _pushMessageMo = new();

        //S_user_dayMO userDayMo = new();

        DingTalkSqlSink dingTalkSqlSink = new();

        private QuartzOptionsSection _options;


        public DingTalkService()
        {
            _options = ConfigUtil.GetSection<QuartzOptionsSection>();
        }

        /// <summary>
        /// 每天统计一次的数据
        /// </summary>
        /// <returns></returns>
        public async Task<DingTalkApiResult> LoadDingTalkDay(DingTalkIpo ipo)
        {
            DingTalkApiResult result = new DingTalkApiResult();

            var operatorEo = _operatorMO.GetSingle("OperatorID = @OperatorID", ipo.operatorId);
            if (operatorEo == null)
            {
                LogUtil.Error($"LoadDingTalkMinute，s_operator不存在{ipo.operatorId}");
                result.condition = ipo;
                result.message = $"LoadDingTalkMinute，s_operator不存在{ipo.operatorId}";
                return result;
            }
            ipo.operatorEo = operatorEo;
            ipo.pushConfigEo = _pushConfigMo.GetSingle("OperatorID = @OperatorID", ipo.operatorId);
            if (ipo.pushConfigEo == null)
            {
                LogUtil.Error($"LoadDingTalkMinute，src_push_config不存在{ipo.operatorId}");
                result.condition = ipo;
                result.message = $"LoadDingTalkMinute，src_push_config不存在{ipo.operatorId}";
                return result;
            }

            result.condition = ipo;

            //每小时注册用户数量
            await WriteRegisterUsers(ipo);

            //每小时下注用户数量
            await WriteBetUsers(ipo);

            //平台前20分钟净输赢
            await WritePlatformWinAndLoss(ipo);

            //净盈利游戏top
            ipo.profitOrLoss = true;
            await WriteTopAppProfitOrLoss(ipo);
            //净亏损游戏top
            ipo.profitOrLoss = false;
            await WriteTopAppProfitOrLoss(ipo);

            //净盈利用户top
            ipo.profitOrLoss = true;
            await WriteTopUserProfitOrLoss(ipo);
            //净亏损用户top
            ipo.profitOrLoss = false;
            await WriteTopUserProfitOrLoss(ipo);

            //用户最近20分钟充值总额
            ipo.depositOrWithdraw = true;
            await WriteSumUserDepositOrWithdraw(ipo);
            //用户最近20分钟充值总额
            ipo.depositOrWithdraw = false;
            await WriteSumUserDepositOrWithdraw(ipo);
            //用户充值数量
            await WritePayUserNum(ipo);

            //累计送出bonus
            await WriteDaySendBonus(ipo);

            ////bonus实际转化为真金的数额
            //await WriteBonusToCash(ipo);

            //所有用户bonus存量
            await WriteSumUserBonus(ipo);

            //真金下注top
            await WriteTopAppBetCash(ipo);

            //最近20分钟app活动度排行
            await WriteTopAppPV(ipo);

            //写库
            //await WritePushMessageToDB(ipo);

            ipo.startTime = ipo.startTime.ToLocalTime(ipo.operatorId); // Convert.ToDateTime(ipo.startTime.ToString("yyyy-MM-dd HH:mm:00")).AddHours(-ipo.AddHour);
            ipo.endTime = ipo.endTime.ToLocalTime(ipo.operatorId); //Convert.ToDateTime(ipo.endTime.ToString("yyyy-MM-dd HH:mm:00")).AddHours(-ipo.AddHour);

            await SendDingTalk(ipo);


            result.condition = ipo;
            result.success = true;
            return result;
        }

        /// <summary>
        /// 每隔20分中统计一次的数据
        /// </summary>
        /// <returns></returns>
        public async Task<DingTalkApiResult> LoadDingTalkMinute(DingTalkIpo ipo)
        {
            DingTalkApiResult result = new DingTalkApiResult();

            var operatorEo = _operatorMO.GetSingle("OperatorID = @OperatorID", ipo.operatorId);
            if (operatorEo == null)
            {
                LogUtil.Error($"LoadDingTalkMinute，s_operator不存在{ipo.operatorId}");
                result.condition = ipo;
                result.message = $"LoadDingTalkMinute，s_operator不存在{ipo.operatorId}";
                return result;
            }
            ipo.operatorEo = operatorEo;
            ipo.pushConfigEo = _pushConfigMo.GetSingle("OperatorID = @OperatorID", ipo.operatorId);
            if (operatorEo == null)
            {
                LogUtil.Error($"LoadDingTalkMinute，src_push_config不存在{ipo.operatorId}");
                result.condition = ipo;
                result.message = $"LoadDingTalkMinute，src_push_config不存在{ipo.operatorId}";
                return result;
            }

            if ((ipo.timeNow.Hour >= ipo.pushConfigEo.ResetTime.Hour && ipo.timeNow.Minute > 0) || ipo.timeNow.Hour > ipo.pushConfigEo.ResetTime.Hour)
                ipo.newDay = true;

            if (!ipo.newDay)
            {
                ipo.startTime = Convert.ToDateTime(ipo.timeNow.AddDays(-1).ToString($"yyyy-MM-dd {ipo.pushConfigEo.ResetTime.Hour}:00:00")).AddHours(ipo.AddHour);
            }
            else
            {
                ipo.startTime = Convert.ToDateTime(ipo.timeNow.ToString($"yyyy-MM-dd {ipo.pushConfigEo.ResetTime.Hour}:00:00")).AddHours(ipo.AddHour);
            }
            ipo.endTime = ipo.timeNow.AddHours(ipo.AddHour);


            result.condition = ipo;
            //ipo.startTime = new DateTime(2023, 07, 02, 03, 00, 00);
            //ipo.endTime = new DateTime(2023, 07, 03, 03, 00, 00);

            //大厅幸运轮盘活动
            //await WriteActivityRoulette(ipo);

            //平台前20分钟净输赢
            await WritePlatformWinAndLoss(ipo);

            //净盈利游戏top
            ipo.profitOrLoss = true;
            await WriteTopAppProfitOrLoss(ipo);
            //净亏损游戏top
            ipo.profitOrLoss = false;
            await WriteTopAppProfitOrLoss(ipo);

            //净盈利用户top
            ipo.profitOrLoss = true;
            await WriteTopUserProfitOrLoss(ipo);
            //净亏损用户top
            ipo.profitOrLoss = false;
            await WriteTopUserProfitOrLoss(ipo);

            //用户最近20分钟充值总额
            ipo.depositOrWithdraw = true;
            await WriteSumUserDepositOrWithdraw(ipo);
            //用户最近20分钟充值总额
            ipo.depositOrWithdraw = false;
            await WriteSumUserDepositOrWithdraw(ipo);
            //用户充值数量
            await WritePayUserNum(ipo);

            //累计送出bonus
            await WriteDaySendBonus(ipo);

            ////bonus实际转化为真金的数额
            //await WriteBonusToCash(ipo);

            //所有用户bonus存量
            await WriteSumUserBonus(ipo);

            //真金下注top
            await WriteTopAppBetCash(ipo);

            //最近20分钟app活动度排行
            await WriteTopAppPV(ipo);

            //写库
            //await WritePushMessageToDB(ipo);

            ipo.startTime = Convert.ToDateTime(ipo.startTime.ToString("yyyy-MM-dd HH:mm:00")).AddHours(-ipo.AddHour);
            ipo.endTime = Convert.ToDateTime(ipo.endTime.ToString("yyyy-MM-dd HH:mm:00")).AddHours(-ipo.AddHour);

            await SendDingTalk(ipo);


            result.condition = ipo;
            result.success = true;
            return result;
        }

        /// <summary>
        /// 每隔一小时统计一次的数据
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<DingTalkApiResult> LoadDingTalkHour(DingTalkIpo ipo)
        {
            DingTalkApiResult result = new DingTalkApiResult();

            var operatorEo = _operatorMO.GetSingle("OperatorID = @OperatorID", ipo.operatorId);
            if (operatorEo == null)
            {
                LogUtil.Error($"LoadDingTalkMinute，s_operator不存在{ipo.operatorId}");
                result.condition = ipo;
                result.message = $"LoadDingTalkMinute，s_operator不存在{ipo.operatorId}";
                return result;
            }
            ipo.operatorEo = operatorEo;
            ipo.pushConfigEo = _pushConfigMo.GetSingle("OperatorID = @OperatorID", ipo.operatorId);
            if (ipo.pushConfigEo == null)
            {
                LogUtil.Error($"LoadDingTalkMinute，src_push_config不存在{ipo.operatorId}");
                result.condition = ipo;
                result.message = $"LoadDingTalkMinute，src_push_config不存在{ipo.operatorId}";
                return result;
            }

            if ((ipo.timeNow.Hour >= ipo.pushConfigEo.ResetTime.Hour && ipo.timeNow.Minute > 0) || ipo.timeNow.Hour > ipo.pushConfigEo.ResetTime.Hour)
                ipo.newDay = true;

            if (!ipo.newDay)
            {
                ipo.startTime = Convert.ToDateTime(ipo.timeNow.AddDays(-1).ToString($"yyyy-MM-dd {ipo.pushConfigEo.ResetTime.Hour}:00:00")).AddHours(ipo.AddHour);
            }
            else
            {
                ipo.startTime = Convert.ToDateTime(ipo.timeNow.ToString($"yyyy-MM-dd {ipo.pushConfigEo.ResetTime.Hour}:00:00")).AddHours(ipo.AddHour);
            }
            ipo.endTime = ipo.timeNow.AddHours(ipo.AddHour);


            result.condition = ipo;

            //每小时注册用户数量
            await WriteRegisterUsers(ipo);

            //每小时下注用户数量
            await WriteBetUsers(ipo);

            ipo.startTime = Convert.ToDateTime(ipo.startTime.ToString("yyyy-MM-dd HH:mm:00")).AddHours(-ipo.AddHour);
            ipo.endTime = Convert.ToDateTime(ipo.endTime.ToString("yyyy-MM-dd HH:mm:00")).AddHours(-ipo.AddHour);

            await SendDingTalk(ipo);

            result.condition = ipo;
            result.success = true;
            return result;
        }

        /// <summary>
        /// 大厅幸运轮盘活动赠金
        /// </summary>
        /// <returns></returns>
        private async Task WriteActivityRoulette(DingTalkIpo ipo)
        {
            string sql = $@"select 
	                        SUM(Bonus) as ActivityRouletteSendBonus
                        from sa_roulette_detail as details
                        inner join sa_roulette_user as users
                        on details.UserID = users.UserID
                        where users.UserKind = 1
                        and details.OperatorID = @OperatorID
                        and details.RecDate >= @startTime and details.RecDate < @endTime";

            var ret = await DbSink.MainDb.ExecSqlScalarAsync<long?>(sql, ipo.operatorId, ipo.startTime, ipo.endTime);

            Src_push_messageEO eo = new Src_push_messageEO()
            {
                MessageID = ObjectId.NewId(),
                SummaryTime = ipo.timeNow,
                OperatorID = ipo.operatorId,
                SummaryType = (int)DingTalkMessage.ActivityRoulette,
                CountryId = ipo.operatorEo.CountryID,
                CurrencyID = ipo.operatorEo.CurrencyID,
                RecDate = DateTime.UtcNow
            };

            ipo.pushMessages.Add(eo);

            ipo.dic.Add((int)DingTalkMessage.ActivityRoulette, $"幸运轮盘总计送出：{(!ret.HasValue ? 0 : ret.Value.AToM(ipo.operatorEo.CurrencyID))}");

        }


        /// <summary>
        /// 平台最近20分钟净输赢
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WritePlatformWinAndLoss(DingTalkIpo ipo)
        {
            DingTalkDto ret = (await dingTalkSqlSink.SelectPlatformWinAndLoss(ipo));

            #region 写库

            //Src_push_messageEO eo = new Src_push_messageEO()
            //{
            //    MessageID = Guid.NewGuid().ToString(),
            //    SummaryTime = ipo.timeNow,
            //    OperatorID = ipo.operatorId,
            //    SummaryType = (int)DingTalkMessage.PlatformProfitOrLoss,
            //    CountryId = ipo.operatorEo.CountryID,
            //    CurrencyID = ipo.operatorEo.CurrencyID,
            //    RecDate = DateTime.UtcNow
            //};

            //if (ret != null)
            //{
            //    eo.ProfitAmount = ret.SumBet;
            //    eo.LossAmount = ret.SumWin;
            //    ret.SumResult = ret.SumBet - ret.SumWin;

            //    if (ret.SumResult > 0)
            //        eo.SumProfit = ret.SumResult;
            //    else
            //        eo.SumLoss = ret.SumResult;

            //    eo.RecDate = DateTime.UtcNow;
            //}

            //ipo.pushMessages.Add(eo);

            #endregion

            if (ret != null)
            {
                ret.SumResult = ret.SumBet - ret.SumWin;
                ret.SumBonusResult = ret.SumBonusBet - ret.SumBonusWin;
            }

            var desc = $"平台净输赢金额（真金+bonus）：{(ret == null ? 0 : ret.SumResult.AToM(ipo.operatorEo.CurrencyID))}\n";
            desc += $"平台净输赢金额（真金）：{(ret == null ? 0 : (ret.SumResult - ret.SumBonusResult).AToM(ipo.operatorEo.CurrencyID))}\n";
            desc += $"平台净输赢金额（bonus）：{(ret == null ? 0 : ret.SumBonusResult.AToM(ipo.operatorEo.CurrencyID))}";

            ipo.dic.Add((int)DingTalkMessage.PlatformProfitOrLoss, desc);
        }

        /// <summary>
        /// app最近20分钟活跃度top
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WriteTopAppPV(DingTalkIpo ipo)
        {
            var ret = (await dingTalkSqlSink.WriteTopAppPV(ipo));
         
            string topGameMsg = string.Empty;
            foreach (var item in ret)
            {
                topGameMsg += $"\n{(!string.IsNullOrWhiteSpace(item.AppName) ? item.AppName : item.AppID)}活跃度{item.BetUsers}";
            }
            ipo.dic.Add((int)DingTalkMessage.AppPV, $"游戏活跃度Top{ipo.pushConfigEo.GameTop}{topGameMsg}");
        }

        /// <summary>
        /// app最近20分钟真金下注top
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WriteTopAppBetCash(DingTalkIpo ipo)
        {
            //List<DingTalkBetCashDto> ret = (await dingTalkSqlSink.WriteTopAppBetCash(ipo));
            ////List<S_appEO> appEos = null;
            ////if(null!= ret&&ret.Any())
            ////{
            ////    var appids = string.Join("','", ret.Select(x => x.AppID));
            ////    appEos = await _appMo.GetAsync($" appid in ('{appids}')");
            ////}
            
            //string topGameMsg = string.Empty;
            ////S_appEO appEo = null;
            //foreach (var item in ret)
            //{
            //   // appEo = appEos.FirstOrDefault(x=>x.AppID==item.AppID);
            //    topGameMsg += $"\n{(!string.IsNullOrWhiteSpace(item.AppName)? item.AppName : item.AppID)}真金下注{item.SumBet.AToM(ipo.operatorEo.CurrencyID)}";
            //}
            //ipo.dic.Add((int)DingTalkMessage.BetCash, $"真金下注游戏Top{ipo.pushConfigEo.GameTop}{topGameMsg}");
        }

        /// <summary>
        /// app最近20分钟净盈利、净亏损top
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WriteTopAppProfitOrLoss(DingTalkIpo ipo)
        {
            //List<DingTalkDto> ret = (await dingTalkSqlSink.SelectTopAppProfitOrLoss(ipo));

            ////写库
            //Src_push_messageEO eo = null;
            //string topGameMsg = string.Empty;

            //foreach (var item in ret)
            //{
            //    var appEo = _appMo.GetSingle("AppID = @AppID", item.AppID);
            //    if (appEo != null)
            //        topGameMsg += $"\n{appEo.AppName}{(ipo.profitOrLoss ? "盈利" : "亏损")} 全部ggr: {item.SumResult.AToM(ipo.operatorEo.CurrencyID)} 真金ggr:{(item.SumResult - (item.SumBonusBet - item.SumBonusWin)).AToM(ipo.operatorEo.CurrencyID)}";
            //    else
            //        topGameMsg += $"\n{item.AppID}{(ipo.profitOrLoss ? "盈利" : "亏损")} 全部ggr: {item.SumResult.AToM(ipo.operatorEo.CurrencyID)} 真金ggr:{(item.SumResult - (item.SumBonusBet - item.SumBonusWin)).AToM(ipo.operatorEo.CurrencyID)}";
            //}


            //ipo.dic.Add(ipo.profitOrLoss ? (int)DingTalkMessage.AppProfit : (int)DingTalkMessage.AppLoss, $"{(ipo.profitOrLoss ? "盈利" : "亏损")}游戏Top{ipo.pushConfigEo.GameTop}{topGameMsg}");
        }


        /// <summary>
        /// 用户最近20分钟净盈利、净亏损top
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WriteTopUserProfitOrLoss(DingTalkIpo ipo)
        {

            //List<DingTalkDto> ret = (await dingTalkSqlSink.SelectTopUserProfitOrLoss(ipo));

            //string topUserMsg = string.Empty;


            //if (ret != null && ret.Any())
            //{
            //    var userList = await new S_userMO().GetAsync($"UserID in ('{string.Join("','", ret.Select(d => d.UserID).ToList())}')");

            //    foreach (var item in ret)
            //    {
            //        var userEo = userList.Where(d => d.UserID.Equals(item.UserID)).FirstOrDefault();

            //        if (userEo != null)
            //            topUserMsg += $"\n{GetShowUserName(userEo)}{(ipo.profitOrLoss ? "盈利" : "亏损")}{Math.Abs(item.SumResult.AToM(ipo.operatorEo.CurrencyID))}";
            //        else
            //            topUserMsg += $"\n{item.UserID}{(ipo.profitOrLoss ? "盈利" : "亏损")}{Math.Abs(item.SumResult.AToM(ipo.operatorEo.CurrencyID))}";
            //    }
            //}

            //ipo.dic.Add(ipo.profitOrLoss ? (int)DingTalkMessage.UserProfit : (int)DingTalkMessage.UserLoss, $"{(ipo.profitOrLoss ? "盈利" : "亏损")}用户Top{ipo.pushConfigEo.UserTop}{topUserMsg}");
        }

        /// <summary>
        /// 用户最近20分钟充值、提现总额
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WriteSumUserDepositOrWithdraw(DingTalkIpo ipo)
        {
            DingTalkDto ret = (await dingTalkSqlSink.SelectSumUserDepositOrWithdraw(ipo));

            Src_push_messageEO eo = new Src_push_messageEO()
            {
                MessageID = ObjectId.NewId(),
                SummaryTime = ipo.timeNow,
                OperatorID = ipo.operatorId,
                SummaryType = ipo.depositOrWithdraw ? (int)DingTalkMessage.SumUserDeposit : (int)DingTalkMessage.SumUserWithDraw,
                CountryId = ipo.operatorEo.CountryID,
                CurrencyID = ipo.operatorEo.CurrencyID,
                RecDate = DateTime.UtcNow
            };

            if (ret != null)
            {
                if (ipo.depositOrWithdraw)
                    eo.SumProfit = ret.SumResult;
                else
                    eo.SumLoss = ret.SumResult;
            }

            ipo.pushMessages.Add(eo);

            ipo.dic.Add(ipo.depositOrWithdraw ? (int)DingTalkMessage.SumUserDeposit : (int)DingTalkMessage.SumUserWithDraw, $"用户{(ipo.depositOrWithdraw ? "充值" : "提款")}总额：{(ipo.depositOrWithdraw ? eo.SumProfit.AToM(ipo.operatorEo.CurrencyID) : eo.SumLoss.AToM(ipo.operatorEo.CurrencyID))}");
        }

        /// <summary>
        /// 每小时注册用户数量
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WriteRegisterUsers(DingTalkIpo ipo)
        {
            DingTalkDto ret = (await dingTalkSqlSink.SelectRegisterUsers(ipo));

            //Src_push_messageEO eo = new Src_push_messageEO()
            //{
            //    MessageID = Guid.NewGuid().ToString(),
            //    SummaryTime = ipo.timeNow,
            //    OperatorID = ipo.operatorId,
            //    SummaryType = (int)DingTalkMessage.RegisterUsers,
            //    CountryId = ipo.operatorEo.CountryID,
            //    CurrencyID = ipo.operatorEo.CurrencyID,
            //    RecDate = DateTime.UtcNow
            //};

            //if (ret != null)
            //    eo.RegisterUsers = ret.registerUsers;

            //ipo.pushMessages.Add(eo);

            //ipo.dic.Add((int)DingTalkMessage.RegisterUsers, $"用户注册数量：{eo.RegisterUsers}");

            if (ret != null && ret.Registers != null && ret.Registers.Any())
            {
                string values = $"用户注册数量：{ret.Registers.Sum(d => d.RegisterCount)}";

                foreach (var item in ret.Registers)
                {
                    values += $"\n渠道：{item.Channel}，注册数量：{item.RegisterCount}";
                }

                ipo.dic.Add((int)DingTalkMessage.RegisterUsers, values);
            }
            else
            {
                ipo.dic.Add((int)DingTalkMessage.RegisterUsers, $"用户注册数量：0");
            }

        }

        private async Task WriteBetUsers(DingTalkIpo ipo)
        {
            DingTalkDto ret = (await dingTalkSqlSink.SelectBetUsers(ipo));

            Src_push_messageEO eo = new Src_push_messageEO()
            {
                MessageID = ObjectId.NewId(),
                SummaryTime = ipo.timeNow,
                OperatorID = ipo.operatorId,
                SummaryType = (int)DingTalkMessage.BetUsers,
                CountryId = ipo.operatorEo.CountryID,
                CurrencyID = ipo.operatorEo.CurrencyID,
                RecDate = DateTime.UtcNow
            };

            if (ret != null && ret.betUsers.HasValue)
                eo.BetUsers = (long)ret.betUsers;

            ipo.pushMessages.Add(eo);

            ipo.dic.Add((int)DingTalkMessage.BetUsers, $"用户下注数量：{eo.BetUsers.AToM(ipo.operatorEo.CurrencyID)}");
        }

        private async Task WritePayUserNum(DingTalkIpo ipo)
        {
            DingTalkDto ret = await dingTalkSqlSink.SelectPayUsers(ipo);

            if (ret != null && ret.PayUsers != null && ret.PayUsers.Any())
            {
                string values = $"用户充值数量：{ret.PayUsers.Sum(x=>x.Count)}";
                var todayUserCountDict = ret.PayUsers.ToDictionary(x=>x.IsToday);
                values += $"\n当天注册充值用户数量：{(todayUserCountDict.ContainsKey(true)?todayUserCountDict[true].Count: 0)}，充值金额：{(todayUserCountDict.ContainsKey(true)?todayUserCountDict[true].PayAmount.AToM(ipo.operatorEo.CurrencyID) : 0)}";
                values += $"\n非当天注册充值用户数量：{(todayUserCountDict.ContainsKey(false)?todayUserCountDict[false].Count:0)}，充值金额：{(todayUserCountDict.ContainsKey(false)?todayUserCountDict[false].PayAmount.AToM(ipo.operatorEo.CurrencyID) : 0)}";
                values += $"\n";
                
                ret= await dingTalkSqlSink.SelectFromIdPayUsers(ipo);
                if (ret != null && ret.PayUsers != null && ret.PayUsers.Any())
                {
                    foreach (var item in ret.PayUsers.GroupBy(x=>x.FromId))
                    {
                        values += $"\n渠道：{item.Key},充值数量：{item.Sum(x=>x.Count)},充值金额:{item.Sum(x=>x.PayAmount).AToM(ipo.operatorEo.CurrencyID)}";

                        var todayFromIdPayUserDict = item.ToDictionary(x => x.IsToday);
                        values += $"\n当天注册充值用户数量：{(todayFromIdPayUserDict.ContainsKey(true)? todayFromIdPayUserDict[true].Count:0)}，充值金额：{(todayFromIdPayUserDict.ContainsKey(true)? todayFromIdPayUserDict[true].PayAmount.AToM(ipo.operatorEo.CurrencyID):0)}";

                        values += $"\n非当天注册充值用户数量：{(todayFromIdPayUserDict.ContainsKey(false)? todayFromIdPayUserDict[false].Count: 0)}，充值金额：{(todayFromIdPayUserDict.ContainsKey(false)? todayFromIdPayUserDict[false].PayAmount.AToM(ipo.operatorEo.CurrencyID):0)}";
                    }
                }
                ipo.dic.Add((int)DingTalkMessage.PayUsers, values);
            }
            else
            {
                ipo.dic.Add((int)DingTalkMessage.PayUsers, $"用户充值数量：0");
            }

        }

        /// <summary>
        /// 每日bonus送出数量
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WriteDaySendBonus(DingTalkIpo ipo)
        {
            DingTalkDto ret = await dingTalkSqlSink.SelectDaySendBonus(ipo);

            var desc = $"累计送出bonus：{(ret == null ? 0 : ret.SumSendBonus.AToM(ipo.operatorEo.CurrencyID))}";

            ipo.dic.Add((int)DingTalkMessage.DaySendBonus, desc);
        }

        /// <summary>
        /// bonus实际转化为真金的数额
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WriteBonusToCash(DingTalkIpo ipo)
        {
            DingTalkDto ret = await dingTalkSqlSink.SelectBonusToCash(ipo);

            var desc = $"bonus实际转化为真金的数额：{(ret == null ? 0 : ret.SumBonusToCash.AToM(ipo.operatorEo.CurrencyID))}";

            ipo.dic.Add((int)DingTalkMessage.BonusToCash, desc);
        }

        /// <summary>
        /// 所有用户bonus存量
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        private async Task WriteSumUserBonus(DingTalkIpo ipo)
        {
            DingTalkDto ret = await dingTalkSqlSink.SelectSumUserBonus(ipo);

            var desc = $"所有用户账户留存bonus总额：{(ret == null ? 0 : ret.SumUserBonus.AToM(ipo.operatorEo.CurrencyID))}";

            ipo.dic.Add((int)DingTalkMessage.SumUserBonus, desc);
        }



        private async Task WritePushMessageToDB(DingTalkIpo ipo)
        {
            if (ipo != null && ipo.pushMessages != null && ipo.pushMessages.Any())
            {
                foreach (var item in ipo.pushMessages)
                    _pushMessageMo.Add(item);
            }
        }


        /// <summary>
        /// 发送消息到钉钉
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<bool> SendDingTalk(DingTalkIpo ipo)
        {

            DingTalkReq req = new DingTalkReq();
            var operatorName = GetOperatorName(ipo.operatorId);
            req.text.content = $"[ING]\n";
            req.text.content += $"{operatorName}平台[{ipo.operatorId}]\n";
            req.text.content += $"北京时间:{DateTime.UtcNow.AddHours(8).ToString("yyyy年MM月dd日 HH时")}\n";
            req.text.content += $"{operatorName}时间:{GetLocalDatetime(ipo.operatorId)}\n";
            req.text.content += $"UTC时间:{DateTime.UtcNow.ToString("yyyy年MM月dd日 HH时")}\n";
            req.text.content += $"\n数据统计区间（{operatorName}时间）:\n{ipo.startTime.ToString("yyyy年MM月dd日 HH时mm分ss秒")}-{ipo.endTime.ToString("yyyy年MM月dd日 HH时mm分ss秒")}\n";

            ipo.dic = ipo.dic.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);

            foreach (var item in ipo.dic.Values)
            {
                req.text.content += "\n" + item + "\n";
            }

            using (HttpClient httpClient = new HttpClient())
            {
                var url = ipo.ReportType!= DingTalkReportType.EveryDay? _options.DingTalkUrl:_options.DingTalkOperatorDaySumUrl;

                var response = await httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(req), Encoding.UTF8, "application/json"));

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                    return false;

                return true;
            };
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private async Task<bool> SendEmail(string content)
        {
            try
            {
                var client = new SmtpClientEx("operate");
                client.SendTo("operate", "subject", content);
                return true;
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, $"Quartz发送邮件失败,content:{content},error:{ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 获取运营商对应的国家名称
        /// </summary>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        private string GetOperatorName(string operatorId)
        {
            var operatorEo = QuartzUtils.GetOperator(operatorId);
            if (operatorEo != null)
            {
                var countryEo = QuartzUtils.GetCountry(operatorEo.CountryID);
                if (countryEo != null)
                    return countryEo.Name;
            }

            return operatorId;
        }

        private string GetLocalDatetime(string operatorId)
        {
            var ret = string.Empty;
            switch(operatorId) {
                case "own_lobby_mex":
                    ret = DateTime.UtcNow.AddHours(-6).ToString("yyyy年MM月dd日 HH时");
                    break;
                case "own_lobby_bra":
                case "own_lobby_bra1":
                case "own_lobby_bra2":
                    ret = DateTime.UtcNow.AddHours(-3).ToString("yyyy年MM月dd日 HH时");
                    break;
                default:
                    ret = DateTime.UtcNow.ToString("yyyy年MM月dd日 HH时");
                    break;
            }
            return ret;
        }

        private string GetShowUserName(S_userEO user)
        {
            if (user == null)
                return string.Empty;

            if (!string.IsNullOrWhiteSpace(user.Mobile))
                return user.Mobile;

            if (!string.IsNullOrWhiteSpace(user.Username))
                return user.Username;

            return user.UserID;
        }

    }
}
