using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using UGame.Quartz.Service.Services.Activity.InviteNewuser;
using UGame.Quartz.Service.Services.VipWeekReward;

namespace UGame.Quartz.WebAPI.Controllers
{
    /// <summary>
    /// InviteNewuserController
    /// </summary>
    public class InviteNewuserController : QuartzControllerBase
    {
        private InviteNewuserService _svc;

        public InviteNewuserController(InviteNewuserService svc)
        {
            _svc = svc;
        }

        /// <summary>
        /// 好友邀请分享活动，发放月度奖励,100011
        /// </summary>
        [HttpPost]
        [AllowAnonymous]
        public async Task<InviteNewuserDto> Execute(InviteNewuserIpo ipo)
        {
            return await _svc.Execute(ipo);
        }

        /// <summary>
        /// 好友邀请分享活动，100013
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<bool> ExecuteNew(InviteNewuserIpo ipo)
        {
            return await _svc.ExecuteNew(ipo);
        }
    }
}
