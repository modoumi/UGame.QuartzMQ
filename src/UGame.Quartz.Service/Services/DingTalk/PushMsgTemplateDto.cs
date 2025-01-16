using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.DingTalk
{
    public class PushMsgTemplateDto
    {
        public Dictionary<int, string> content { get; set; } = new Dictionary<int, string>();

    }
}
