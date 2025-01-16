using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UGame.Quartz.Service.Common;

namespace UGame.Quartz.Service.Services.Activity.InviteNewuser
{
    public class InviteNewuserIpo
    {
        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 国家编码
        /// </summary>
        public string CountryId { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// 活动是否有效，活动事件数据
        /// </summary>
        [JsonIgnore]
        public (bool IsValid, ActivityListEventEntity activityEntity) Activity { get; set; }
    }

    public class InviteNewuserDto
    {
        /// <summary>
        /// 服务器时间
        /// </summary>
        public DateTime Now { get; set; }
        /// <summary>
        /// 数据查询区间，开始时间
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// 数据查询区间，截止时间
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 获得bonus奖励的明细
        /// </summary>
        public List<InviteItem> Items { get; set; } = new List<InviteItem>();
    }

    public class InviteItem
    {
        public string pUserId { get; set; }

        public int UserCount { get; set; }

        public decimal Bonus { get; set;}

    }
}
