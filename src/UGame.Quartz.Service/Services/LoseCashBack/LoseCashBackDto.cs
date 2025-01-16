using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.LoseCashBack
{
    public class LoseCashBackDto
    {
        public string dayId { get; set; }
        public int userCount { get; set; }
        public List<CashBackDetailInfo> userList { get; set; }
    }

    public class CashBackDetailInfo
    {
        public string userId { get; set; }
        public decimal loseBack { get; set; }
    }
}
