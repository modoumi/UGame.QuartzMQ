//using Lobby.Common.Enum;
//using Lobby.Common.MQ;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using UGame.Quartz.Service.Commands.Base;
using Xxyy.Common;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Commands.Handler.Base
{
    public interface INotifyCommandHandler<ReqT, ResT> : IRequestHandler<ReqT, ResT> where ReqT : INotifyCommand<ResT>
    {
        
    }
}
