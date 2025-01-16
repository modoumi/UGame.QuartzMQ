using Microsoft.AspNetCore.Mvc;
using UGame.Quartz.Service.Services.Activity.Rebate;
using UGame.Quartz.Service.Services.RebateWater;

namespace UGame.Quartz.WebAPI.Controllers;

public class RebateWaterController : QuartzControllerBase
{
    private RebateService _rebateService = new();
    /// <summary>
    /// 返水统计发放奖励
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<RebateWaterResponse> RebateWaterStatis(RebateWaterRequest request)
        => await _rebateService.RebateWaterStatis(request);
}
