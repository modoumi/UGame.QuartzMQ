namespace UGame.Quartz.Service.Services.PayBetAverage;

public class PayBetAvgIpo
{
    public DateTime BeginTime { get; set; }
}

/// <summary>
/// 
/// </summary>
public class AvgDataIpo
{
    public string OperatorId { get; set; }

    public DateTime DayId { get; set; }

    public DateTime MinDay { get; set; }

    public List<UserDto> RegUsers { get; set; }

    public List<UserDto> PayUsers { get; set; }
}
