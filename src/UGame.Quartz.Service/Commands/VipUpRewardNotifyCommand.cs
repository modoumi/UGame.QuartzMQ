using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.Quartz.Service.Commands.Base;
using UGame.Quartz.Service.Common;

namespace UGame.Quartz.Service.Commands
{
    /// <summary>
    /// vip升级奖励每日发放
    /// </summary>
    public class VipUpRewardNotifyCommand : RewardNotifyCommandBase
    {
        public VipUpRewardNotifyCommand()
        {
            RewardFlagId = (int)ActivityType.Vip;
            IsSendNotify = false;
            IsSendNotifyEmail = true;
            RewardSourceTable = "sc_vip_reward_detail";
            SenderId = "Quartz.VipUpReward";
        }
    }
}
