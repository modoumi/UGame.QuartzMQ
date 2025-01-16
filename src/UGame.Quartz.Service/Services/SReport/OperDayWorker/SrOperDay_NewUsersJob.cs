using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.Quartz.Dal;

namespace Xxyy.Quartz.BLL.Services.BasicReport.OperDayWorker
{
    /// <summary>
    /// 统计每天新注册，新下注，新充值，新提现以及登录的用户数
    /// </summary>
    public class SrOperDay_NewUsersJob : BasicReportJobBase<SrOperDay_NewUsersJob,Dictionary<string, Sr_oper_dayEO>>
    {
        private readonly S_user_dayMO _sUserDayMo = new();
        private readonly BasicReportContext _context;

        //private readonly Sr_oper_dayEO _eo;
        public SrOperDay_NewUsersJob(BasicReportContext context)
        {
            this._context = context;
        }

        public override async Task<Dictionary<string, Sr_oper_dayEO>> Execute()
        {
            return await HandleOperNewUserDay();
        }

        /// <summary>
        /// 统计每天新注册，新下注，新充值，新提现以及登录的用户数
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task<Dictionary<string, Sr_oper_dayEO>> HandleOperNewUserDay()
        {
            var operatorId = _context.OperatorId;
            var startDate = _context.ReportDate.Date;
            var dict = new Dictionary<string, Sr_oper_dayEO>();
            var pageCountUserDay = await _sUserDayMo.GetPageCountAsync(PAGESIZE, $"DayID=@DayID and OperatorID=@OperatorID and UserKind =1 ",values:new object[] { startDate,operatorId});
            if (pageCountUserDay == 0) return dict;

            List<S_user_dayEO> pageListUserDay = null;
            for (var page = 1; page <= pageCountUserDay; page++)
            {
                pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, $"DayID=@DayID and OperatorID=@OperatorID and UserKind =1", "RecDate",values:new object[] { startDate,operatorId});
                if (pageListUserDay == null || pageListUserDay.Count == 0) continue;

                foreach (var item in pageListUserDay)
                {
                    if (!dict.ContainsKey(item.OperatorID))
                    {
                        var eo=new Sr_oper_dayEO()
                        {
                            DayID=startDate,
                            OperatorID=item.OperatorID,
                            CountryID=item.CountryID,
                            CurrencyID=item.CurrencyID,
                            LoginUsers=1,
                            NewUsers=item.IsNew?1:0,
                            RegUsers=item.IsRegister?1:0,
                            NewBetUsers=item.IsNewBet?1:0,
                            NewPayUsers=item.IsNewPay?1:0,
                            NewCashUsers=item.IsNewCash?1:0
                        };
                        dict.Add(item.OperatorID,eo);
                    }
                    else
                    {
                        var eo = dict[item.OperatorID];
                        eo.LoginUsers += 1;
                        eo.NewUsers += item.IsNew ? 1 : 0;
                        eo.RegUsers += item.IsRegister ? 1 : 0;
                        eo.NewBetUsers += item.IsNewBet ? 1 : 0;
                        eo.NewPayUsers += item.IsNewPay ? 1 : 0;
                        eo.NewCashUsers += item.IsNewCash ? 1 : 0;
                    }
                }
                await Task.Delay(200);
            }
            return dict;
        }
    }
}
