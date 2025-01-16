using Microsoft.AspNetCore.Mvc;
using UGame.Quartz.Service.Services.Activity.Rebate;
using UGame.Quartz.Service.Services.RebateWater;

namespace UGame.Quartz.WebAPI.Controllers;

public class ActivityController : QuartzControllerBase
{
    private RebateService _rebateService = new();
    /// <summary>
    /// 返水统计发放奖励
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task RebateWaterStatis(RebateWaterRequest request)
        => await _rebateService.RebateWaterStatis(request);
}
