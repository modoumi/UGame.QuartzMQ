using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Configuration;
using System.Text;
using TinyFx.Configuration;
using TinyFx.Logging;
using UGame.Quartz.Service;
using UGame.Quartz.Service.Services.DingTalk;
using UGame.Quartz.Service.Services.RegisterUserSms;
using Xxyy.Quartz.Dal;

namespace UGame.Quartz.WebAPI.Controllers
{
    public class RegisterUserSmsController : QuartzControllerBase
    {
        RegisterUserSMSService _registerUserService = new();

        public RegisterUserSmsController()
        { 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SendSms([FromBody] RegisterUserSMSIpo ipo)
        {
            await _registerUserService.SendSMS(ipo);
            return Ok();
        }
    }
}
