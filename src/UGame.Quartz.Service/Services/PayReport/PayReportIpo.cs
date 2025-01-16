using System.ComponentModel.DataAnnotations;

namespace UGame.Quartz.Service.Services.PayReport
{
    public class PayReportIpo
    {
        /// <summary>
        /// 统计日期
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// 运营商编码
        /// </summary>
        [Required]
        public string OperatorID { get; set; }
    }
}
