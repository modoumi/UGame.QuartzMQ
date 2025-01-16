using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Common
{
    public enum DingTalkMessage
    {
        /// <summary>
        /// 幸运轮盘活动
        /// </summary>
        ActivityRoulette = 0,

        /// <summary>
        /// 平台净输赢金额
        /// </summary>
        PlatformProfitOrLoss = 100,

        /// <summary>
        /// 累计送出bonus
        /// </summary>
        DaySendBonus = 200,

        /// <summary>
        /// bonus实际转化为真金的数额
        /// </summary>
        BonusToCash = 300,

        /// <summary>
        /// 所有用户bonus存量
        /// </summary>
        SumUserBonus = 400,

        /// <summary>
        /// 用户最近20分钟充值总额
        /// </summary>
        SumUserDeposit = 500,

        /// <summary>
        /// 用户最近20分钟提现总额
        /// </summary>
        SumUserWithDraw = 600,

        /// <summary>
        /// 充值用户数量 
        /// </summary>
        PayUsers = 700,

        /// <summary>
        /// app最近20分钟净盈利top
        /// </summary>
        AppProfit = 800,

        /// <summary>
        /// app最近20分钟净亏损top 
        /// </summary>
        AppLoss = 900,

        /// <summary>
        /// 用户最近20分钟净盈利top
        /// </summary>
        UserProfit = 1000,

        /// <summary>
        /// 用户最近20分钟净亏损top
        /// </summary>
        UserLoss = 1100,

        /// <summary>
        /// 最近一小时注册用户数量
        /// </summary>
        RegisterUsers = 1200,

        /// <summary>
        /// 最近一小时下注用户数量
        /// </summary>
        BetUsers = 1300,
        /// <summary>
        /// app最近20分钟真金下注top 
        /// </summary>
        BetCash = 1400,
        /// <summary>
        /// app最近20分钟活跃度top 
        /// </summary>
        AppPV = 1500,
        /// <summary>
        /// 平台每日消息
        /// </summary>
        OperatorDaySum=1600
    }
}
