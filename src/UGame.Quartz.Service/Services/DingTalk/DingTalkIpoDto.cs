using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UGame.Quartz.Service.Common;
using Xxyy.DAL;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.DingTalk
{
    public class DingTalkIpo
    {
        public string operatorId { get; set; }

        public DateTime timeNow { get; set; } = DateTime.UtcNow;

        public DateTime startTime { get; set; }

        
        public DateTime endTime { get; set; }

        public DingTalkReportType ReportType { get; set; } = DingTalkReportType.RealTime;


        public Dictionary<int, string> dic { get; set; } = new Dictionary<int, string>();

        
        public bool newDay { get; set; } = false;

        /// <summary>
        /// true盈利、false亏损
        /// </summary>
        public bool profitOrLoss { get; set; } = true;

        /// <summary>
        /// true充值、false提现
        /// </summary>
        public bool depositOrWithdraw { get; set; } = true;

        public S_operatorEO operatorEo { get; set; }

        public Src_push_configEO pushConfigEo { get; set; }

        public List<Src_push_messageEO> pushMessages { get; set; } = new List<Src_push_messageEO>();

        /// <summary>
        /// 相较于UTC时间相差小时数
        /// </summary>
        public int AddHour { get; set; }
    }
    public class DingTalkBetCashDto
    {
        public string AppID { get; set; }
        public string AppName { get; set; }

        public long SumBet { get; set; }
    }

    public class DingTalkAppPvDto
    {
        public string AppID { get; set; }
        public string AppName { get; set; }

        public long BetUsers { get; set; }
    }

    public class DingTalkDto
    {

        public string OperatorID { get; set; }


        public string CountryID { get; set; }


        public string CurrencyID { get; set; }


        public string AppID { get; set; }

        public string UserID { get; set; }

        /// <summary>
        /// 下注总额（包含bonus）
        /// </summary>
        public long SumBet { get; set; } = 0;
        /// <summary>
        /// 返奖总额（包含bonus）
        /// </summary>
        public long SumWin { get; set; } = 0;
        /// <summary>
        /// 下注总额-返奖总额（包含bonus）
        /// </summary>
        public long SumResult { get; set; } = 0;
        /// <summary>
        /// bonus下注总额
        /// </summary>
        public long SumBonusBet { get; set; } = 0;
        /// <summary>
        /// bonus返奖总额
        /// </summary>
        public long SumBonusWin { get; set; } = 0;
        /// <summary>
        /// bonus下注总额-bonus返奖总额
        /// </summary>
        public long SumBonusResult { get; set; } = 0;

        /// <summary>
        /// 每小时注册用户数量
        /// </summary>
        public int registerUsers { get; set; }

        /// <summary>
        /// 每小时下注用户数量
        /// </summary>
        public long? betUsers { get; set; }

        /// <summary>
        /// 幸运轮盘赠送奖金合计
        /// </summary>
        public long? ActivityRouletteSendBonus { get; set; }


        public List<RegisterUsersDto> Registers { get; set; }


        public List<PayUser> PayUsers { get; set; }

        /// <summary>
        /// 累计送出bonus
        /// </summary>
        public long SumSendBonus { get; set; } = 0;

        /// <summary>
        /// bonus实际转化为真金的数额
        /// </summary>
        public long SumBonusToCash { get; set; } = 0;

        /// <summary>
        /// 所有用户bonus存量
        /// </summary>
        public long SumUserBonus { get; set; } = 0;
    }

    /// <summary>
    /// 注册用户数量
    /// </summary>
    public class RegisterUsersDto
    { 
        /// <summary>
        /// 渠道
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// 注册数量
        /// </summary>
        public int RegisterCount { get; set; }
    }

    /// <summary>
    /// 充值用户
    /// </summary>
    public class PayUser
    { 
        /// <summary>
        /// 
        /// </summary>
        public string FromId { get; set; }

        /// <summary>
        /// 是否当天
        /// </summary>
        public bool IsToday { get; set; }
        /// <summary>
        /// 充值金额
        /// </summary>
        public long PayAmount { get; set; }

        /// <summary>
        /// 充值人数
        /// </summary>
        public int Count { get; set; }
    }
}
