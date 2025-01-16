using System.Reflection;
using Xxyy.DAL;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.BasicReport
{
    public class OperatorDayContext : IDayCalculatorIpo
    {
        public OperatorDayContext(DateTime reportDate,string operatorId)
        {
            this.ReportDate= reportDate;
            this.OperatorId= operatorId;
           
        }
        public OperatorDayContext()
        {
            
        }

       
        /// <summary>
        /// 指定日期
        /// </summary>
        public DateTime ReportDate { get; set; }

        /// <summary>
        /// 运营商编号
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 分组Key
        /// </summary>
        public string GroupKey { get; set; }

        /// <summary>
        /// frommode 0-运营商  1-用户   2-channel
        /// </summary>
        public int FromMode { get; set; }

        /// <summary>
        /// 当日新增的所有用户数
        /// </summary>
        public List<Repository.S_user_dayEO> UserDayEos { get; set; }

        private Dictionary<string, Repository.S_user_dayEO> _userDayDict;
        public Repository.S_user_dayEO GetUserDayEo(string userId)
        {
            if(_userDayDict == null) 
            {
                _userDayDict = UserDayEos?.ToDictionary(x=>x.UserID)??new Dictionary<string, S_user_dayEO>();
            }
            if(!_userDayDict.TryGetValue(userId, out var ret))
                return null;
            return ret;
        }

        /// <summary>
        /// 当日新增的所有下注订单数
        /// </summary>
        public List<S_provider_orderEO> ProviderOrderEos { get; set; }

        /// <summary>
        /// 当日新增的所有currencyChange数
        /// </summary>
        public List<S_currency_changeEO> CurrencyChangeEos { get; set; }

        /// <summary>
        /// 当日新增的所有bankorder数
        /// </summary>
        public List<Sb_bank_orderEO> BankOrderEos { get; set; }

        /// <summary>
        /// 流水需求订单
        /// </summary>
        public List<Xxyy.DAL.S_requireflow_orderEO> RequireFlowOrderEos { get; set; }
        public List<Sc_cash_auditEO> CashAuditEos { get; set; }



    }
}
