using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UGame.Quartz.Service.Services.CurrencyChange;
using UGame.Quartz.Service.Services.VipWeekReward;

namespace UGame.Quartz.WebAPI.Controllers
{
    public class RepairCurChangeController : QuartzControllerBase
    {
        CurrencyChangeRepairService _svc = new();

        /// <summary>
        /// 修复lobby升级common之前的数据
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<CurRepairDto> RepairUpgradeBefore(int repariCount = 1)
        {
            return new CurRepairDto();
            //return await _svc.RepairUpgradeBefore(repariCount);
        }

        /// <summary>
        /// 修复lobby升级common之后的数据
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<CurRepairDto> RepairUpgradeAfter(int repariCount = 1)
        {
            return new CurRepairDto();
            //return await _svc.RepairUpgradeAfter(repariCount);
        }

        /// <summary>
        /// 修复提现审核拒绝的数据
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<CurRepairDto> RepairAuditRejected(int repariCount = 1)
        {
            return new CurRepairDto();
            //return await _svc.RepairAuditRejected(repariCount);
        }

        [HttpGet]
        [AllowAnonymous]
        public string Check() => "OK";
    }
}
