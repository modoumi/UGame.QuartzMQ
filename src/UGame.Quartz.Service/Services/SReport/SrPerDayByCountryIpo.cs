namespace UGame.Quartz.Service.Services.BasicReport
{
    /// <summary>
    /// 每日基础统计ipo按country
    /// </summary>
    public class SrPerDayByCountryIpo
    {

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CountryId { get; set; }
    }
}
