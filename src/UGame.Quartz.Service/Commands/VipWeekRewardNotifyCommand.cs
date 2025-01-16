using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.AutoMapper;
using UGame.Quartz.Service.Commands.Base;
using UGame.Quartz.Service.Common;
using Xxyy.MQ.Xxyy;

namespace UGame.Quartz.Service.Commands
{
    /// <summary>
    /// vip周奖励发放
    /// </summary>
    public class VipWeekRewardNotifyCommand : RewardNotifyCommandBase
    {
        public VipWeekRewardNotifyCommand()
        {
            RewardFlagId = (int)ActivityType.VipWeek;
            IsSendNotify = true;
            IsSendNotifyEmail = true;
            RewardSourceTable = "sc_vip_reward_detail";
            SenderId = "Quartz.VipWeekReward";
        }
    }
}
