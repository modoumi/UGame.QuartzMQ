using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.Quartz.Dal;

namespace Xxyy.Quartz.BLL.Services.BasicReport.OperDayWorker
{
    public class SrOperDay_BankFeeJob : BasicReportJobBase<SrOperDay_BankFeeJob>
    {
        private readonly BasicReportContext _context;

        //private readonly Sr_oper_dayEO _eo;
        private readonly Dictionary<string, Sr_oper_dayEO> _dict;
        private readonly Sr_oper_bank_paytype_dayMO _operBankPaytypeDayMo = new();
        public SrOperDay_BankFeeJob(BasicReportContext context, Dictionary<string,Sr_oper_dayEO> dict)
        {
            this._context = context;
            //_eo = eo ?? throw new ArgumentNullException("eo不能为空！");
            _dict = dict?? throw new ArgumentNullException("dict不能为空！");
        }

        public override async Task Execute()
        {
            await HandleOperBankUserDay();
        }

        /// <summary>
        /// 统计运营商每天充值的用户数，提现的用户数以及充值手续费，提现手续费等
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task HandleOperBankUserDay()
        {
            var startDate = _context.ReportDate.Date;
            var operatorId = _context.OperatorId;

            var pageCount = await _operBankPaytypeDayMo.GetPageCountAsync(PAGESIZE, $"DayID=@startDate and OperatorID=@OperatorID", values: new object[] { startDate,operatorId });
            if (pageCount == 0) return;
            List<Sr_oper_bank_paytype_dayEO> pageList = null;
            for (var page = 1; page <= pageCount; page++)
            {
                pageList = await _operBankPaytypeDayMo.GetPagerListAsync(PAGESIZE, page, $"DayID=@DayID and OperatorID=@OperatorID", "RecDate", values: new object[] { startDate,operatorId });
                if (pageList == null || pageList.Count == 0) continue;
                V_s_operatorEO operatorEO = null;
                foreach (var item in pageList)
                {
                    if (!_dict.ContainsKey(item.OperatorID))
                    {
                        operatorEO = DbCacheUtil.GetOperator(item.OperatorID);
                        var eo = new Sr_oper_dayEO
                        {
                            DayID = startDate,
                            OperatorID = item.OperatorID,
                            CountryID = operatorEO.CountryID,
                            CurrencyID = operatorEO.CurrencyID,
                            PayOwnFee = item.PayOwnFee,
                            PayUserFee = item.PayUserFee,
                            CashOwnFee = item.CashOwnFee,
                            CashUserFee = item.CashUserFee
                        };
                        _dict.Add(item.OperatorID, eo);
                    }
                    else
                    {
                        var eo = _dict[item.OperatorID];
                        eo.PayOwnFee += item.PayOwnFee;
                        eo.PayUserFee += item.PayUserFee;
                        eo.CashOwnFee += item.CashOwnFee;
                        eo.CashUserFee += item.CashUserFee;
                    }
                }
            }
        }
    }
}
