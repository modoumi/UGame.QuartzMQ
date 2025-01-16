using Microsoft.AspNetCore.Mvc;
using UGame.Quartz.Service.Services.MarketingNotice;

namespace UGame.Quartz.WebAPI.Controllers;

public class MarketingNoticeController : QuartzControllerBase
{
    private MarketingNoticeService marketingNoticeService = new();
    /// <summary>
    /// 提醒用户充值
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task NotifyDeposit(MarketingNoticeIpo request)
        => await marketingNoticeService.NotifyDeposit(request.OperatorIds);
}
