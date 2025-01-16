using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using TinyFx;
using TinyFx.Logging;
using UGame.Quartz.Service.Services.PayReport;

namespace UGame.Quartz.WebAPI.Controllers
{
    /// <summary>
    /// 支付报表接口
    /// </summary>
    public class PayReportController : QuartzControllerBase
    {
        private readonly PayReportService _payReportSvc = new();

        /// <summary>
        /// 支付报表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task PayReport(PayReportIpo ipo)
        {
            LogUtil.Info("0.{0},收到报表请求ipo:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(ipo));
            try
            {
                await _payReportSvc.Execute(ipo);
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "_payReportSvc.PayReport异常！ipo:{0}", SerializerUtil.SerializeJsonNet(ipo));
            }
        }
    }
}
