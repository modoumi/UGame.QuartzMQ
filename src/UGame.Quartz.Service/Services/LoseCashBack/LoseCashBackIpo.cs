using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.LoseCashBack
{
    /// <summary>
    /// 输返活动请求参数
    /// </summary>
    public class LoseCashBackIpo
    {
        /// <summary>
        /// 发放日期
        /// </summary>
        public string GrantDate { get; set; }

        /// <summary>
        /// 运营商编码
        /// </summary>
        [Required]
        public string OperatorID { get; set; }
    }
}
