//using Lobby.Common.Enum;
//using Lobby.Common.MQ;
using MediatR;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.AutoMapper;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using UGame.Quartz.Service.Commands.Base;
using Xxyy.Common;
using Xxyy.MQ.Xxyy;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Commands.Handler.Base
{
    public abstract class RewardNotifyCommandHandlerBase<T> : INotifyCommandHandler<T, int> where T : RewardNotifyCommandBase
    {
        protected ILogger<RewardNotifyCommandHandlerBase<T>> _logger;
        protected Sa_notify_templateMO _saNotifyTempMo = new();

        public RewardNotifyCommandHandlerBase()
        {
            _logger = LogUtil.CreateLogger<RewardNotifyCommandHandlerBase<T>>();
        }

        public virtual async Task<int> Handle(T request, CancellationToken cancellationToken)
        {
            var notifyMsg = request.Map<NotifyRewardMsg>();
            MQUtil.Publish(notifyMsg);
            //有回调
            if (request.AfterNofify != null)
            {
                //更新通知状态
                return await request.AfterNofify(request.RewardSourceId);
            }

            return 1;
        }
    }
}
