using Microsoft.AspNetCore.Mvc;
using UGame.Quartz.Service.Services.PayBetAverage;

namespace UGame.Quartz.WebAPI.Controllers;

public class PayBetAvgController : QuartzControllerBase
{
    private readonly PayBetAvgService _payBetAvgService = new();


    /// <summary>
    /// 统计周期>开始时间 充值下注人均次数
    /// 注册用户单充/复充-人均下注次数
    /// 单日用户单充/复充-人均下注次数
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task PayBetAverage(PayBetAvgIpo ipo)
    {
        await _payBetAvgService.ExcuteAsync(ipo.BeginTime);
    }
}
