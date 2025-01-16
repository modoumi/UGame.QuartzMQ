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
using Xxyy.Quartz.Dal;
using UGame.Quartz.Service.Services.Monitor;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Ocsp;
using System.Net;
using UGame.Quartz.Service.Common;
using System.Security.Cryptography;
using System.Web;
using static System.Net.WebRequestMethods;
using Xxyy.Common;
using EasyNetQ;
using Microsoft.Extensions.Primitives;

namespace UGame.Quartz.WebAPI.Controllers
{
    public class MonitorController : QuartzControllerBase
    {

        Service.Services.Monitor.Monitor _monitor = new();

        private IConfiguration _configuration;

      

        public MonitorController(IConfiguration configuration)
        { 
            _configuration = configuration;
     
        }

        /// <summary>
        /// 1小时统计
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<DingTalkApiResult> Monitor(string countryId="BRA")
        {
            Dictionary<string,string> currentDictionary=new Dictionary<string,string>();

            Dictionary<string, string> bankDictionary = new Dictionary<string, string>();
            //var dateUtcNow2 = DateTime.Parse("2023-12-15 08:01:00").ToUniversalTime().AddMinutes(-30);

            var dateUtcNow2 = DateTime.UtcNow.AddMinutes(-30);

            var todayUtcStart =  new DateTime(dateUtcNow2.Year, dateUtcNow2.Month, dateUtcNow2.Day, dateUtcNow2.Hour, dateUtcNow2.Minute>=30? 30:00, 00) ;
            var todayUtcEnd =  new DateTime(dateUtcNow2.Year, dateUtcNow2.Month, dateUtcNow2.Day, dateUtcNow2.Hour, dateUtcNow2.Minute >= 30 ? 59 : 29, dateUtcNow2.Minute >= 30 ? 59 : 29);

            try
            {
                currentDictionary= _monitor.MonitorCurrencyChange(countryId, todayUtcStart, todayUtcEnd);
            }
            catch (Exception e)
            {
               
            }

            try
            {
                bankDictionary = _monitor.MonitorBank(countryId, todayUtcStart, todayUtcEnd);
            }
            catch (Exception e)
            {
             
            }

            try
            {
                if (currentDictionary.Count > 0 || bankDictionary.Count > 0)
                {
                    StringBuilder message = new StringBuilder();
                    //message.Append("**活动异常**");
                    //
                    message.Append("<font color=#FF0000>**====告警通知====**</font>");
                    message.Append("\n\n");
                    message.Append("----------------"); //下划线
                    message.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                                           //message.Append("## Your Message Content\n\n>");

                    //message.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                    foreach (KeyValuePair<string, string> tmp in currentDictionary)
                    {
                        message.Append("**" + tmp.Key + ":** " + tmp.Value);
                        message.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                    }
                    foreach (KeyValuePair<string, string> tmp in bankDictionary)
                    {
                        message.Append("**" + tmp.Key + ":** " + tmp.Value);
                        message.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                    }
                    //message.Append("**查询时间段UTC:** " + todayUtcStart.ToString("MM-dd") + " " + todayUtcStart.ToString("HH:mm:ss") + "至" + todayUtcEnd.ToString("HH:mm:ss"));
                    //message.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                    //message.Append("**查询时间段当地:** " + todayUtcStart.ToLocalTimeByCountryId(countryId).ToString("MM-dd") + " " + todayUtcStart.ToLocalTimeByCountryId(countryId).ToString("HH:mm:ss") + "至" + todayUtcEnd.ToLocalTimeByCountryId(countryId).ToString("HH:mm:ss"));
                    //message.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                    message.Append("**查询时间段北京:** " + todayUtcStart.AddHours(8).ToString("MM-dd") + " " + todayUtcStart.AddHours(8).ToString("HH:mm:ss") + "至" + todayUtcEnd.AddHours(8).ToString("HH:mm:ss"));

                    DingDing.Send("SEC78f1f608f1d4639e5c7707a7ae016ca359fda433d2dbc6a73ffb50acffdc7cf8", "6e3405d8402af5fa5f24f311a95db34743ceca4efa5790c913aca146c6f5351f", message.ToString());

                }

                if (currentDictionary.ContainsKey("活动总赠送金额") || bankDictionary.ContainsKey("直接提现订单"))
                {
                    StringBuilder message1 = new StringBuilder();
                    //message.Append("**活动异常**");
                    //
                    message1.Append("<font color=#FF0000>**====告警通知====**</font>");
                    message1.Append("\n\n");
                    message1.Append("----------------"); //下划线
                    message1.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                                            //message.Append("## Your Message Content\n\n>");

                    //message.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                    foreach (KeyValuePair<string, string> tmp in currentDictionary)
                    {
                        if (tmp.Key.Contains("活动总赠送金额"))
                        {
                            message1.Append("**" + tmp.Key + ":** " + tmp.Value);
                            message1.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                        }

                    }
                    foreach (KeyValuePair<string, string> tmp in bankDictionary)
                    {
                        if (tmp.Key.Contains("直接提现订单"))
                        {
                            message1.Append("**" + tmp.Key + ":** " + tmp.Value);
                            message1.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                        }
                    }
                    //message1.Append("**查询时间段UTC:** " + todayUtcStart.ToString("MM-dd") + " " + todayUtcStart.ToString("HH:mm:ss") + "至" + todayUtcEnd.ToString("HH:mm:ss"));
                    //message1.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                    //message1.Append("**查询时间段当地:** " + todayUtcStart.ToLocalTimeByCountryId(countryId).ToString("MM-dd") + " " + todayUtcStart.ToLocalTimeByCountryId(countryId).ToString("HH:mm:ss") + "至" + todayUtcEnd.ToLocalTimeByCountryId(countryId).ToString("HH:mm:ss"));
                    //message1.Append("\n\n");//多个\n只能换一行，加上一个空格即可辅助完成换行
                    message1.Append("**查询时间段北京:** " + todayUtcStart.AddHours(8).ToString("MM-dd") + " " + todayUtcStart.AddHours(8).ToString("HH:mm:ss") + "至" + todayUtcEnd.AddHours(8).ToString("HH:mm:ss"));

                    DingDing.Send("SECa8cbbe061d1e99f30ae466bd19e746b3cbae4889ac8d323cb19c3ecd97fcef6e", "2b1e3330f47d0f803b9d8f23c4b8e60da3e86ca52570ddc686e04dd5fd941788", message1.ToString());
                }
             
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }

        public class DingDing
        {
            public static async void Send(string secret, string access_token,string message)
            {
                using (HttpClient httpClient = new HttpClient())
                {

                    string sign = null;
                    //string secret = "SEC78f1f608f1d4639e5c7707a7ae016ca359fda433d2dbc6a73ffb50acffdc7cf8";

                    TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                    string timeStamp = Convert.ToInt64(ts.TotalMilliseconds).ToString();


                    var encoding = new UTF8Encoding();
                    byte[] signBytes = encoding.GetBytes($"{timeStamp}\n" + secret);
                    byte[] secretByte = encoding.GetBytes(secret);
                    using (var hmacsha256 = new HMACSHA256(secretByte))
                    {
                        byte[] hashmessage = hmacsha256.ComputeHash(signBytes);
                        sign = HttpUtility.UrlEncode(Convert.ToBase64String(hashmessage));
                    }

                    string messageUrl =
                        $"https://oapi.dingtalk.com/robot/send?access_token={access_token}&timestamp={timeStamp}&sign={sign}";
                    string data = "{\"msgtype\": \"actionCard\",\"actionCard\": {\"title\":\"告警通知\",\"text\":\"" + message +
                                  "\"},\"at\":{\"isAtAll\":true}}";

        //            data =
        //                "{\r\n    \"msgtype\": \"markdown\",\r\n    \"markdown\": {\r\n        \"title\": \"Your Message Title\",\r\n        \"text\": \"## Your Message Content\\n\\n> This is centered text\\n\\n> ![image](http://your-image-url.png)\"\r\n    },\r\n    \"at\": {\r\n        \"isAtAll\": true\r\n    }\r\n}";

        //            data =

        //                 @"
        //{
        //    ""msgtype"": ""markdown"",
        //    ""markdown"": {
        //        ""title"": ""Your_Message_Title"",
        //        ""text"": ""# Your_Message_Content \n > <font color=gray>### This is centered text</font>""
        //    },
        //    ""at"": {
        //        ""isAtAll"": true
        //    }
        //}";
                    var response = await httpClient.PostAsync(messageUrl,
                        new StringContent(data, Encoding.UTF8, "application/json"));

                    //if (!response.StatusCode.Equals(HttpStatusCode.OK))
                    //{

                    //}
                }
            }
        }
    }
}
