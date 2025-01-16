using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UGame.Quartz.Service.Services.LoseCashBack;
using UGame.Quartz.Service.Services.VipWeekReward;

namespace UGame.Quartz.WebAPI.Controllers
{
    public class VipWeekRewardController : QuartzControllerBase
    {
        VipWeekRewardService _svc;

        public VipWeekRewardController(VipWeekRewardService svc)
        {
            _svc = svc;
        }

        /// <summary>
        /// 发放vip周奖励
        /// </summary>
        [HttpPost]
        [AllowAnonymous]
        public async Task<VipWeekRewardDto> GrantReward(VipWeekRewardIpo ipo)
        {
            return await _svc.Execute(ipo);
        }

        [HttpGet]
        [AllowAnonymous]
        public string Check() => "OK";

        /// <summary>
        /// vip升级奖励每日发放
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<VipUpRewardDto> VipUpReward(VipUpRewardIpo ipo)
        {
            return await _svc.VipUpExecute(ipo);
        }

    }
}
