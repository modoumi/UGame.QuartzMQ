using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.AutoMapper;
using Xxyy.MQ.Xxyy;

namespace UGame.Quartz.Service.Commands.Base
{
    /// <summary>
    /// 奖励通知基类
    /// </summary>
    public abstract class RewardNotifyCommandBase : INotifyCommand<int>, IMapTo<NotifyRewardMsg>
    {
        public string UserId { get; set; }

        public string OperatorId { get; set; }

        public string CountryId { get; set; }

        public string CurrencyId { get; set; }

        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        public bool IsSendNotify { get; set; }

        /// <summary>
        /// 是否发送站内邮件通知
        /// </summary>
        public bool IsSendNotifyEmail { get; set; }

        /// <summary>
        /// 奖励金额
        /// </summary>
        public long RewardAmount { get; set; }

        /// <summary>
        /// 奖励需要完成的流水倍数
        /// </summary>
        public float FlowMultip { get; set; }

        /// <summary>
        /// 奖励原始表
        /// </summary>
        public string RewardSourceTable { get; set; }

        /// <summary>
        /// 奖励原始ID
        /// </summary>
        public string RewardSourceId { get; set; }

        /// <summary>
        /// 奖励标识ID
        /// </summary>
        public int RewardFlagId { get; set; }

        /// <summary>
        /// 邮件发送标识
        /// </summary>
        public string SenderId { get; set; }

        /// <summary>
        /// 发通知后的回调
        /// </summary>
        public Func<string, Task<int>> AfterNofify { get; set; }

        /// <summary>
        /// 奖励是否为bonus，备用字段
        /// </summary>
        public bool IsBonus { get; set; } = true;

        public void MapTo(NotifyRewardMsg destination)
        {

        }
    }
}
