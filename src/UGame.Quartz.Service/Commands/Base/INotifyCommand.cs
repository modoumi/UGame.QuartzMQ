using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Commands.Base
{
    /// <summary>
    /// 通知
    /// </summary>
    public interface INotifyCommand<T> : IRequest<T>
    {
        string UserId { get; }

        string OperatorId { get; }

        string CountryId { get; }

        string CurrencyId { get; }

        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        bool IsSendNotify { get; }

        /// <summary>
        /// 是否发送站内邮箱通知
        /// </summary>
        bool IsSendNotifyEmail { get; }

        /// <summary>
        /// 发通知后的回调
        /// </summary>
        Func<string, Task<T>> AfterNofify { get; }
    }
}
