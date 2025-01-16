using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Common
{
    /// <summary>
    /// 活动事件枚举，对应l_activity_event.EventID
    /// </summary>
    public enum ActivityEvent
    {
        /// <summary>
        /// 充值
        /// </summary>
        Pay = 1,

        /// <summary>
        /// 提现
        /// </summary>
        Cash = 2,

        /// <summary>
        /// 下注
        /// </summary>
        Bet = 3,

        /// <summary>
        /// 返奖
        /// </summary>
        Win = 4,

        /// <summary>
        /// 注册
        /// </summary>
        Register = 5,

        /// <summary>
        /// 签到
        /// </summary>
        SignIn = 6,

        /// <summary>
        /// 绑定手机
        /// </summary>
        BindMobile = 7,

        /// <summary>
        /// 输返
        /// </summary>
        LoseCashBack = 8
    }
}
