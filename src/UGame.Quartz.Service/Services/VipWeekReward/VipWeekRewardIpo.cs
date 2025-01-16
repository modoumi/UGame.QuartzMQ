using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.VipWeekReward
{
    /// <summary>
    /// vip每周发放奖励请求体
    /// </summary>
    public class VipWeekRewardIpo
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

    /// <summary>
    /// vip升级奖励每日发放ipo
    /// </summary>
    public class VipUpRewardIpo : VipWeekRewardIpo
    {
        /// <summary>
        /// 当前utc时间
        /// </summary>
        [JsonIgnore]
        public DateTime UtcNow { get; set; } = DateTime.UtcNow;
        [JsonIgnore]
        public DateTime StartTime { get; set; }
        [JsonIgnore]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// vip升级奖励用户id集合，当IsAll=false时生效
        /// </summary>
        public List<string> UserIds { get; set; }
        /// <summary>
        /// 是否全量数据
        /// </summary>
        public bool IsAll { get; set; } = false;
    }

}
