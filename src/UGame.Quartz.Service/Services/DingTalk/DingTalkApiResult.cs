using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.DingTalk
{
    public class DingTalkApiResult
    {
        public bool success { get; set; } = false;

        public string message { get; set; }

        public DingTalkIpo condition { get; set; }
    }
}
