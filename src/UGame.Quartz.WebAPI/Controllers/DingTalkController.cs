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

namespace UGame.Quartz.WebAPI.Controllers
{
    public class DingTalkController : QuartzControllerBase
    {

        DingTalkService _dingTalkService = new();

        private IConfiguration _configuration;

        private ApiAccessFilterOption _ceshiOption;

        public DingTalkController(IConfiguration configuration, IOptions<ApiAccessFilterOption> options)
        { 
            _configuration = configuration;
            _ceshiOption = options.Value;
        }

        /// <summary>
        /// 20分钟统计
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<DingTalkApiResult> Summary20Minutes([FromBody] DingTalkIpo ipo)
        {
            try
            {
                var request = new DingTalkIpo()
                {
                    operatorId = ipo.operatorId,
                    timeNow = DateTime.UtcNow.AddHours(-6),
                    AddHour = 6
                };

                return await _dingTalkService.LoadDingTalkMinute(request);
            }
            catch (Exception ex)
            {
                return new DingTalkApiResult() { message = ex.Message };
            }
        }

        /// <summary>
        /// 1小时统计
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DingTalkApiResult> Summary1Hour([FromBody] DingTalkIpo ipo)
        {
            try
            {
                var request = new DingTalkIpo()
                {
                    operatorId = ipo.operatorId,
                    timeNow = DateTime.UtcNow.AddHours(-6),
                    AddHour = 6
                };
                return await _dingTalkService.LoadDingTalkHour(request);
            }
            catch (Exception ex)
            {
                return new DingTalkApiResult() { message = ex.Message };
            }
        }


        /// <summary>
        /// 巴西1小时统计
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DingTalkApiResult> BraSummary1Hour([FromBody] DingTalkIpo ipo)
        {
            try
            {
                var request = new DingTalkIpo()
                {
                    operatorId = ipo.operatorId,
                    timeNow = DateTime.UtcNow.AddHours(-3),
                    AddHour = 3
                };

                return await _dingTalkService.LoadDingTalkHour(request); 
            }
            catch (Exception ex)
            {
                return new DingTalkApiResult() { message = ex.Message + ex.StackTrace };
            }
        }
        /// <summary>
        /// 巴西20分钟统计
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<DingTalkApiResult> BraSummary20Minutes([FromBody] DingTalkIpo ipo)
        {
            try
            {
                var request = new DingTalkIpo()
                {
                    operatorId = ipo.operatorId,
                    timeNow = DateTime.UtcNow.AddHours(-3),
                    AddHour = 3
                };
                return await _dingTalkService.LoadDingTalkMinute(request);
            }
            catch (Exception ex)
            {
                LogUtil.Error("BraSummary20Minutes", ex.ToString());
                return new DingTalkApiResult() { message = ex.ToString() };
            }
        }
    }


    public class ApiAccessFilterOption
    { 
        public string DefaultFilterName { get; set; }

        public List<Filter> Filters { get; set; }
    }

    public class Filter
    { 
        public string Name { get; set; }

        public bool Enabled { get; set; }

        public string AllowIps { get; set; }
    }

}
