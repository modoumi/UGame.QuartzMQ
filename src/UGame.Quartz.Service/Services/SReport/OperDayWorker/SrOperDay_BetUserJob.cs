using Xxyy.Quartz.Dal;

namespace Xxyy.Quartz.BLL.Services.BasicReport.OperDayWorker
{
    public class SrOperDay_BetUserJob : BasicReportJobBase<SrOperDay_BetUserJob>
    {
        private readonly Sr_user_dayMO _srUserDayMo = new();
        private readonly BasicReportContext _context;
        private readonly Dictionary<string, Sr_oper_dayEO> _dict;

        //private readonly Sr_oper_dayEO _eo;
        public SrOperDay_BetUserJob(BasicReportContext context, Dictionary<string,Sr_oper_dayEO> dict)
        {
            this._context = context;
            this._dict = dict ?? throw new ArgumentNullException("dict不能为空！"); ;
            //_eo = eo ?? throw new ArgumentNullException("eo不能为空！");
        }
        public override async Task Execute()
        {
            await HandleOperBetUserDay();
        }

        /// 统计运营商每天下注用户数,下注金额,充值金额,充值用户数
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task HandleOperBetUserDay()
        {
            var operatorId = _context.OperatorId;
            var startDate = _context.ReportDate.Date;

            var pageCount = await _srUserDayMo.GetPageCountAsync(PAGESIZE, $"DayID=@DayID and OperatorID=@OperatorID",values:new object[] { startDate,operatorId});
            if (pageCount == 0) return;
            List<Sr_user_dayEO> pageListUserDay = null;
            for (var page = 1; page <= pageCount; page++)
            {
                pageListUserDay = await _srUserDayMo.GetPagerListAsync(PAGESIZE, page, $"DayID=@DayID and OperatorID=@OperatorID", "RecDate",values:new object[] { startDate, operatorId });
                if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
                foreach (var item in pageListUserDay)
                {
                    if(!_dict.ContainsKey(item.OperatorID))
                    {
                        var eo = new Sr_oper_dayEO { 
                         DayID=startDate,
                         OperatorID=item.OperatorID,
                         CountryID=item.CountryID,
                         CurrencyID=item.CurrencyID,
                         BetUsers=item.BetAmount>0?1:0,
                         BetAmount=item.BetAmount,
                         CashAmount=item.CashAmount,
                         PayUsers=item.PayAmount>0?1:0,
                         PayAmount=item.PayAmount,
                         WinAmount=item.WinAmount
                        };
                        _dict.Add(item.OperatorID,eo);
                    }
                    else
                    {
                        var eo = _dict[item.OperatorID];
                        if (item.BetAmount > 0)
                            eo.BetUsers += 1;

                        eo.BetAmount += item.BetAmount;
                        eo.CashAmount += item.CashAmount;

                        if (item.PayAmount > 0)
                            eo.PayUsers += 1;
                        eo.PayAmount += item.PayAmount;
                        eo.WinAmount += item.WinAmount;
                    }
                }
                await Task.Delay(200);
            }
        }
    }
}
