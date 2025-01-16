using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UGame.Quartz.Service.Services.LoseCashBack;

namespace UGame.Quartz.WebAPI.Controllers
{
    public class LoseCashBackController : QuartzControllerBase
    {
        LoseCashBackService _svc;

        public LoseCashBackController(LoseCashBackService svc)
        {
            _svc = svc;
        }

        /// <summary>
        /// 发放输返金
        /// </summary>
        [HttpPost]
        [AllowAnonymous]
        public async Task<LoseCashBackDto> GrantRefund(LoseCashBackIpo ipo)
        {
            return await _svc.Execute(ipo);
        }

        [HttpGet]
        [AllowAnonymous]
        public string Check() => "OK";
    }
}
