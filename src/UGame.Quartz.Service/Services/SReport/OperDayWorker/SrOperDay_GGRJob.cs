using Xxyy.Quartz.Dal;

namespace Xxyy.Quartz.BLL.Services.BasicReport.OperDayWorker
{
    /// <summary>
    /// 统计运营商利润-GGR
    /// </summary>
    public class SrOperDay_GGRJob : BasicReportJobBase<SrOperDay_GGRJob>
    {
        private readonly BasicReportContext _context;
        private readonly Dictionary<string, Sr_oper_dayEO> _dict;

        public SrOperDay_GGRJob(BasicReportContext context,Dictionary<string,Sr_oper_dayEO> dict)
        {
            this._context = context;
            this._dict = dict ?? throw new ArgumentNullException($"{nameof(dict)}不能为空");
        }
        public override Task Execute()
        {
            foreach (var item in this._dict)
            {
                item.Value.ProfitAmount = item.Value.BetAmount - item.Value.WinAmount - item.Value.PromotionFeeAmount;
            }
            return Task.CompletedTask;
        }
    }
}
