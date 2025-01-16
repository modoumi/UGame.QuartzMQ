using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.RegisterUserSms
{
    /// <summary>
    /// 按OperatorId给注册用户发送短信
    /// </summary>
    public class RegisterUserSMSIpo
    {

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OperatorId { get; set; }
    }
}
