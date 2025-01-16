using TinyFx.Data;

namespace UGame.Quartz.Service.Services.BasicReport
{
    /// <summary>
    /// 运营商每日
    /// </summary>
    public class OperBankUserDayDo : IRowMapper<OperBankUserDayDo>
    {
        public DateTime DayId { get; set; }
        public string OperatorId { get; set; }
        public int PayUsers { get; set; }
        public int CashUsers { get; set; }
        public decimal PayOwnFee { get; set; }
        public decimal PayUserFee { get; set; }
        public decimal CashOwnFee { get; set; }
        public decimal CashUserFee { get; set; }

        public OperBankUserDayDo MapRow(System.Data.IDataReader reader)
        {
            return new OperBankUserDayDo
            {
                DayId = reader.ToDateTime("DayID"),
                OperatorId = reader.ToString("OperatorID"),
                PayUsers = reader.ToInt32("PayUsers"),
                PayOwnFee = reader.ToDecimal("PayOwnFee"),
                PayUserFee = reader.ToDecimal("PayUserFee"),
                CashUsers = reader.ToInt32("CashUsers"),
                CashOwnFee = reader.ToDecimal("CashOwnFee"),
                CashUserFee = reader.ToDecimal("CashUserFee")
            };
        }
    }
}
