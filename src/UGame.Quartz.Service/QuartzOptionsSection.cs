using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.Common;

namespace UGame.Quartz.Service
{
    public class QuartzOptionsSection : AppSectionBase
    {
        #region 环境变量可配置

        private const string ENV_DingTalkUrl = "ENV_DingTalkUrl";
        private const string ENV_DingTalkOperatorDaySumUrl = "ENV_DingTalkOperatorDaySumUrl";

        /// <summary>
        /// 优先级：环境变量ENV_MarqueeLangKey > 配置文件
        /// </summary>
        public string DingTalkUrl { get; set; }
        public string DingTalkOperatorDaySumUrl { get; set; }

        #endregion

        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);

            // MarqueeLangKey
            var dingTalkUrl = Environment.GetEnvironmentVariable(ENV_DingTalkUrl);
            if (!string.IsNullOrEmpty(dingTalkUrl))
                DingTalkUrl = dingTalkUrl;

            var dingTalkOperatorDaySumUrl = Environment.GetEnvironmentVariable(ENV_DingTalkOperatorDaySumUrl);
            if (!string.IsNullOrEmpty(dingTalkOperatorDaySumUrl))
                DingTalkOperatorDaySumUrl = dingTalkOperatorDaySumUrl;
        }
    }
}
