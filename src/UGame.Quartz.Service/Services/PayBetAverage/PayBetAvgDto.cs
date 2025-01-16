namespace UGame.Quartz.Service.Services.PayBetAverage;

/// <summary>
/// 
/// </summary>
public class UserDto
{
    /// <summary>
    /// 用户Id
    /// </summary>
    public string UserID { get; set; }

    /// <summary>
    /// channelId
    /// </summary>
    public string FromId { get; set; }

    public int FromMode { get; set; }

    /// <summary>
    /// 记录时间
    /// </summary>
    public DateTime RecDate { get; set; }
}

/// <summary>
/// 多次充值人员
/// 第一次充值时间
/// 最后一次充值时间
/// </summary>
public class UserPayDto
{
    /// <summary>
    /// 用户Id
    /// </summary>
    public string UserID { get; set; }

    /// <summary>
    /// 最小日期
    /// </summary>
    public DateTime MinDate { get; set; }

    /// <summary>
    /// 最大日期
    /// </summary>
    public DateTime MaxDate { get; set; }
}

/// <summary>
/// 统计结果
/// </summary>
public class PayBetAvgResult
{
    /// <summary>
    /// 统计日期
    /// </summary>
    public DateTime DayId { get; set; }

    /// <summary>
    /// 运营商Id
    /// </summary>
    public string OperatorId { get; set; }

    /// <summary>
    /// 渠道Id
    /// </summary>
    public string ChannelId { get; set; }

    /// <summary>
    /// 注册用户>单充>人均>下注
    /// </summary>
    public float RSPBet { get; set; }

    /// <summary>
    /// 注册用户>复充>人均>下注
    /// </summary>
    public float RMPBet { get; set; }

    /// <summary>
    /// 充值用户>单充>人均>下注
    /// </summary>
    public float PSPBet { get; set; }

    /// <summary>
    /// 充值用户>复充>人均>下注
    /// </summary>
    public float PMPBet { get; set; }
}



