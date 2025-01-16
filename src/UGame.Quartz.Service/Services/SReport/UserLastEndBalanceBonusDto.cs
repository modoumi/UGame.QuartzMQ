using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.SReport
{
    public class UserLastEndBalanceBonusDto
    {
        public string UserId { get; set; }
        public DateTime? LastTime { get; set; }
        public long EndBalance { get; set; }
        public long EndBonus { get; set; }
    }
}
