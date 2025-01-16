using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Quartz.Service.Services.Sb
{
    public class ReachLimitTransIpo
    {
        public string vendor_id { get; set; }
        public string start_Time { get; set; }
    }



    public class TransHistoryItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string actionDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal stake { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal odds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string winlostAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string winlostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string operationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal creditAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal debitAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string inRetry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reachRetryLimit { get; set; }
    }

    public class TxnsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int betType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string winlostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long txId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string refId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string licenseeTxId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal stake { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal odds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TransHistoryItem> transHistory { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public List<TxnsItem> Txns { get; set; }
    }

    public class ReachLimitTransDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int error_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Data Data { get; set; }
    }
}
