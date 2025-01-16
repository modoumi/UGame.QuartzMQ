using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.DingTalk
{
    public class DingTalkReq
    {
        public string msgtype { get; set; } = "text";
        public DingTalkText text { get; set; } = new DingTalkText();
    }

    public class DingTalkText
    {
        public string content { get; set; } = "";
    }
}
