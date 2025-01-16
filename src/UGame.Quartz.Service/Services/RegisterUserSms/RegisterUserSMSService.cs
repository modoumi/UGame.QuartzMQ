using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TinyFx.Data.SqlSugar;
using TinyFx.DbCaching;
using TinyFx.Logging;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using UGame.Quartz.Service.Services.PayReport;
using UGame.Quartz.Repository;
using Xxyy.SMS;

namespace UGame.Quartz.Service.Services.RegisterUserSms
{
    public class RegisterUserSMSService
    {
        private ILogger<RegisterUserSMSService> _logger;
        public RegisterUserSMSService()
        {
            _logger = LogUtil.CreateLogger<RegisterUserSMSService>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task SendSMS(RegisterUserSMSIpo ipo)
        {
            var countryEo = DbCacheUtil.GetCountryByOperatorId(ipo.OperatorId);
            if (ipo.StartDate == null || ipo.StartDate.Value == DateTime.MinValue)
            {
                ipo.StartDate = DateTime.UtcNow.Date.AddDays(-1);
            }
            ipo.StartDate = ipo.StartDate.Value.Date.AddHours(Math.Abs(countryEo.TimeZone));

            if (ipo.EndDate == null || ipo.EndDate.Value == DateTime.MinValue)
            {
                ipo.EndDate = DateTime.UtcNow.Date;
            }
            ipo.EndDate = ipo.EndDate.Value.Date.AddHours(Math.Abs(countryEo.TimeZone));

            var userMOList = DbSink.GetUserMoList();
            foreach (var userMo in userMOList)
            {
                var userList = await userMo.GetAsync("RegistDate>=@starttime and RegistDate<@endtime and OperatorID=@operatorid", null, ipo.StartDate, ipo.EndDate, ipo.OperatorId);
                if (!userList.Any())
                    continue;

                foreach (var userEo in userList)
                {
                    var mobile = GetMobile(userEo, countryEo);
                    if (string.IsNullOrWhiteSpace(mobile))
                        continue;
                    var req = new XxyySmsContentIpo
                    {
                        Mobile = mobile,
                        AppId = null,
                        Content = "Bem-vindo membro da [forroubet], novos beneficios no site hj, colete em www.forroubet.com",
                        SmsId = "paasoo_2",
                        OperatorId = ipo.OperatorId
                    };
                    var rsp = await XxyySmsUtil.SendContentAsync(req);
                }
            }
        }

        /// <summary>
        /// 获取mobile 如5512345678911
        /// </summary>
        /// <param name="userEo"></param>
        /// <param name="countryEo"></param>
        /// <returns></returns>
        private string GetMobile(Xxyy.DAL.S_userEO userEo, S_countryPO countryEo)
        {
            var userMobile = userEo.Mobile?.Trim();
            if (!string.IsNullOrWhiteSpace(userMobile) && Regex.IsMatch(userMobile, "^(\\d{11})||(\\d{13})$"))
            {
                if (userMobile.StartsWith(countryEo.CallingCode) && userMobile.Length == 13)
                    return userMobile;
                return countryEo.CallingCode + userMobile;
            }

            var userName = userEo.Username?.Trim();
            if (!string.IsNullOrWhiteSpace(userName) && Regex.IsMatch(userMobile, "^(\\d{11})||(\\d{13})$"))
            {
                if (userName.StartsWith(countryEo.CallingCode) && userName.Length == 13)
                    return userName;
                return countryEo.CallingCode + userName;
            }
            return null;
        }
    }
}
