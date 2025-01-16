using System.Data;
using TinyFx.Data;

namespace UGame.Quartz.Service.Services.BasicReport
{
    /// <summary>
    /// 银行订单每日统计模型
    /// </summary>
    public class BankOrderDayModel:IRowMapper<BankOrderDayModel>
    {
        /// <summary>
        /// 
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PaytypeId { get; set; }


        /// <summary>
        /// 充值用户数
        /// </summary>
        public int PayUsers { get; set; }

       

        /// <summary>
        /// 
        /// </summary>
        public decimal PayOwnFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal PayUserFee { get; set; }


        /// <summary>
        /// 提款用户数
        /// </summary>
        public int CashUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal CashOwnFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal CashUserFee { get; set; }

        public BankOrderDayModel MapRow(IDataReader reader)
        {
            var ret = new BankOrderDayModel();
            ret.OperatorId = reader.ToString("OperatorID");
            ret.BankId = reader.ToString("BankID");
            ret.PaytypeId = reader.ToInt32("PaytypeID");
            ret.PayUsers = reader.ToInt32("PayUsers");
            ret.PayOwnFee = reader.ToInt32("PayOwnFee");
            ret.PayUserFee = reader.ToInt32("PayUserFee");
            ret.CashUsers = reader.ToInt32("CashUsers");
            ret.CashOwnFee = reader.ToDecimal("CashOwnFee");
            ret.CashUserFee = reader.ToDecimal("CashUserFee");
            return ret;
        }
    }

}
