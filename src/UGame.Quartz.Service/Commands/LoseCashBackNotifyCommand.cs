//using Lobby.Common.Enum;
using MediatR;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.AutoMapper;
using UGame.Quartz.Service.Commands.Base;
using UGame.Quartz.Service.Common;
//using Xxyy.Common.Caching.Partner;
using Xxyy.MQ.Xxyy;

namespace UGame.Quartz.Service.Commands
{
    /// <summary>
    /// 输返活动奖励发放
    /// </summary>
    public class LoseCashBackNotifyCommand : RewardNotifyCommandBase
    {
        public LoseCashBackNotifyCommand() : base()
        {
            RewardFlagId = (int)ActivityType.LoseCashBack;
            RewardSourceTable = "sa_losecashback_detail";
            SenderId = "Quartz.LoseCashBack";
        }
    }
}
