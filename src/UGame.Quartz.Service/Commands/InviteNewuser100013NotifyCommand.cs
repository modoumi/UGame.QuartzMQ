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
    /// 好友邀请分享月度奖励
    /// </summary>
    public class InviteNewuser100013NotifyCommand : RewardNotifyCommandBase
    {
        public InviteNewuser100013NotifyCommand() : base()
        {
            RewardFlagId = (int)ActivityType.InviteNewUser100013;
            RewardSourceTable = "sa_invite100013_detail";
            SenderId = "Quartz.InviteNewuser";
        }
    }

}
