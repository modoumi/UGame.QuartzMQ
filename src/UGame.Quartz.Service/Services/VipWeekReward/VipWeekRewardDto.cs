using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.Quartz.Service.Services.LoseCashBack;

namespace UGame.Quartz.Service.Services.VipWeekReward
{
    public class VipWeekRewardDto
    {

        public string dayId { get; set; }
        public int userCount { get; set; }
        public List<VipWeekRewardDetailInfo> rewardUserList { get; set; } = new List<VipWeekRewardDetailInfo>();

        public List<VipWeekRewardDetailInfo> noBetUserList { get; set; } = new List<VipWeekRewardDetailInfo>();

        public List<VipWeekRewardDetailInfo> noPayUserList { get; set; } = new List<VipWeekRewardDetailInfo>();
    }

    public class VipWeekRewardDetailInfo
    {
        public string userId { get; set; }
        public int vip { get; set; }
        public decimal reward { get; set; }
    }

    /// <summary>
    /// vip升级奖励每日发放dto
    /// </summary>
    public class VipUpRewardDto : VipWeekRewardDto
    { 
        
    }
}
