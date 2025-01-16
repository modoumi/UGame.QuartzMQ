using Xxyy.Common;
using Xxyy.DAL;
using Xxyy.Quartz.Dal;

namespace Xxyy.Quartz.BLL.Services.BasicReport.OperDayWorker
{
    /// <summary>
    /// 统计活动成本
    /// </summary>
    public class SrOperDay_CurrencyChangeJob : BasicReportJobBase<SrOperDay_CurrencyChangeJob>
    {
        private readonly S_currency_changeMO _sCurrencyChangeMo = new();
        private readonly BasicReportContext _context;
        private readonly Dictionary<string, Sr_oper_dayEO> dict;


        public SrOperDay_CurrencyChangeJob(BasicReportContext context,Dictionary<string,Sr_oper_dayEO> dict)
        {
            this._context = context;
            this.dict = dict ?? throw new ArgumentNullException("dict不能为空！");
        }

        public override async Task Execute()
        {
            await HandleOperCurrentChangeDay();
        }

        /// <summary>
        /// 统计活动成本
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task HandleOperCurrentChangeDay()
        {
            //var operatorId = context.OperatorId;
            var startDate = _context.ReportDate.Date.ToUtcTime(this._context.OperatorId);
            var endDate = _context.ReportDate.Date.AddDays(1).ToUtcTime(this._context.OperatorId);
            long pageCount = 0;
            List<S_currency_changeEO> pageList = null;
            foreach (var srOperDay in this.dict)
            {
                pageCount = await _sCurrencyChangeMo.GetPageCountAsync(PAGESIZE, $" DealTime>=@startDate and DealTime<@endDate and OperatorID=@OperatorID and SourceType>100000 and SourceType<200000 and UserKind=1 and Status=2 and CurrencyType=9",values:new object[] { startDate,endDate,srOperDay.Key});
                if (pageCount == 0) continue;

                for (var page = 1; page <= pageCount; page++)
                {
                    pageList = await _sCurrencyChangeMo.GetPagerListAsync(PAGESIZE, page, $"DealTime>=@startDate and DealTime<@endDate and OperatorID=@OperatorID and SourceType>100000 and SourceType<200000 and UserKind=1 and Status=2 and CurrencyType=9", "RecDate",values:new object[] { startDate,endDate,srOperDay.Key});
                    if (pageList == null || pageList.Count == 0) continue;
                    foreach (var item in pageList)
                    {
                        srOperDay.Value.PromotionFeeAmount += item.Amount;
                    }
                    await Task.Delay(200);
                }
            }
        }
    }
}
