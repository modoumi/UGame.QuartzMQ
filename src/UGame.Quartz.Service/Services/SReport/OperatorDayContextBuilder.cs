using System.Drawing.Printing;
using Xxyy.Common;
using Xxyy.DAL;
using Xxyy.MQ.Xxyy;
using UGame.Quartz.Repository;
using Xxyy.Sharding;

namespace UGame.Quartz.Service.Services.BasicReport
{
    /// <summary>
    /// 
    /// </summary>
    public class OperatorDayContextBuilder
    {
        public string OperatorId { get; set; }

        /// <summary>
        /// 运营商当地时间
        /// </summary>
        public DateTime ReportDate { get; set; }
        /// <summary>
        /// 每页条数
        /// </summary>
        protected const int PAGESIZE = 1000000;
        public OperatorDayContextBuilder(string operatorId, DateTime dayId)
        {
            this.OperatorId = operatorId;
            this.ReportDate = dayId;
        }

        /// <summary>
        /// 初始化context上下文
        /// </summary>
        /// <returns></returns>
        public async Task<OperatorDayContext> InitContextData()
        {
            var context=new OperatorDayContext(this.ReportDate,this.OperatorId);
            context.UserDayEos = await this.InitDayUsers() ?? new List<Repository.S_user_dayEO>();
            context.ProviderOrderEos = await this.InitDayProviderOrders() ?? new List<S_provider_orderEO>();
            context.BankOrderEos = await this.InitDayBankOrders() ?? new List<Sb_bank_orderEO>();
            context.CurrencyChangeEos = await this.InitDayCurrencyChanges() ?? new List<S_currency_changeEO>();
            context.RequireFlowOrderEos = new List<Xxyy.DAL.S_requireflow_orderEO>();// await this.InitRequireFlowOrders() ?? new List<DAL.S_requireflow_orderEO>();
            context.CashAuditEos = await this.InitCashAuditEos() ?? new List<Sc_cash_auditEO>();
            return context;
        }

        /// <summary>
        /// 当日审批的提现待审订单
        /// </summary>
        /// <returns></returns>
        private async Task<List<Sc_cash_auditEO>> InitCashAuditEos()
        {
            (var operatorId, var startDate, var endDate) = GetUtcTimeByLocalTime();
            var cashAuditMo = new Sc_cash_auditMO();
            cashAuditMo.UseReadConnectionString = true;

            var pageCount = await cashAuditMo.GetPageCountAsync(PAGESIZE, $" OperatorID=@OperatorID and UserKind=1 and IsAudit=1 and ((AuditTime>=@startDate and AuditTime<@endDate) or (ApplyTime>=@startDate1 and ApplyTime<@endDate1))", values: new object[] { operatorId,startDate, endDate, startDate, endDate });
            if (pageCount == 0) return null;

            var cashAuditEos = new List<Sc_cash_auditEO>();
            List<Sc_cash_auditEO> temp;
            for (var page = 1; page <= pageCount; page++)
            {
                temp = await cashAuditMo.GetPagerListAsync(PAGESIZE, page, " OperatorID=@OperatorID and UserKind=1 and IsAudit=1 and ((AuditTime>=@startDate and AuditTime<@endDate) or (ApplyTime>=@startDate1 and ApplyTime<@endDate1))", "CashAuditID", operatorId, startDate, endDate,startDate, endDate);
                if (null != temp && temp.Any())
                    cashAuditEos.AddRange(temp);
                    //cashAuditEos = cashAuditEos.Concat(temp);
                await Task.Delay(200);
            }
            return cashAuditEos;
        }


        private async Task<List<S_currency_changeEO>> InitDayCurrencyChanges()
        {
            (var operatorId, var startDate, var endDate) = GetUtcTimeByLocalTime();
            var currencyChangeMo = new S_currency_changeMO();
            currencyChangeMo.UseReadConnectionString = true;

            var pageCount = await currencyChangeMo.GetPageCountAsync(PAGESIZE, $" DealTime>=@startDate and DealTime<@endDate and OperatorID=@OperatorID and UserKind=1 and Status=2", values: new object[] { startDate, endDate, operatorId });
            if (pageCount == 0) return null;

            var currencyChanges = new List<S_currency_changeEO>();
            List<S_currency_changeEO> temp;
            for (var page = 1; page <= pageCount; page++)
            {
                temp = await currencyChangeMo.GetPagerListAsync(PAGESIZE, page, "DealTime>=@startDate and DealTime<@endDate and OperatorID=@OperatorID and UserKind=1 and Status=2", "ChangeID", startDate, endDate, operatorId);
                if (null != temp && temp.Any())
                    currencyChanges.AddRange(temp);
                    //currencyChanges = currencyChanges.Concat(temp);
                await Task.Delay(200);
            }
            return currencyChanges;
        }

        private async Task<List<S_provider_orderEO>> InitDayProviderOrders()
        {
            (var operatorId, var startDate, var endDate) = GetUtcTimeByLocalTime();
            var providerOrderMo = new S_provider_orderMO();
            providerOrderMo.UseReadConnectionString = true;

            var dataTables = await new SProviderOrderService().GetTableNames(new ProviderOrderFilter
            {
                BeginUtcDate = startDate,
                EndUtcDate = endDate,
                OperatorIds = new List<string> { operatorId }
            });
            dataTables.Add("s_sb_order");

            var providerOrders = new List<S_provider_orderEO>();
            foreach (var datatable in dataTables)
            {
                providerOrderMo.TableName = datatable;
                var pageCount = await providerOrderMo.GetPageCountAsync(PAGESIZE,
                    $" ResponseTime>=@startDate and ResponseTime<@endDate and OperatorID=@OperatorID and ReqMark!=4 and UserKind=1 and Status =2 and CurrencyType=9" + (datatable == "s_sb_order" ? " and IsFree=0" : ""),
                    values: new object[] { startDate, endDate, operatorId });
                if (pageCount == 0) continue;

                List<S_provider_orderEO> temp;
                for (var page = 1; page <= pageCount; page++)
                {
                    temp = await providerOrderMo.GetPagerListAsync(PAGESIZE, page,
                        "ResponseTime>=@startDate and ResponseTime<@endDate and OperatorID=@OperatorID  and ReqMark!=4 and UserKind=1 and Status =2 and CurrencyType=9" + (datatable == "s_sb_order" ? " and IsFree=0" : ""),
                        "OrderId", startDate, endDate, operatorId);
                    if (null != temp && temp.Any())
                        providerOrders.AddRange(temp);
                    await Task.Delay(1000);
                }
            }
             
            return providerOrders;
        }

        private (string, DateTime, DateTime) GetUtcTimeByLocalTime()
        {
            var operatorId = this.OperatorId;
            var startDate = this.ReportDate.Date.ToUtcTime(operatorId);
            var endDate = this.ReportDate.Date.AddDays(1).ToUtcTime(operatorId);
            return (operatorId, startDate, endDate);
        }
        private async Task<List<Sb_bank_orderEO>> InitDayBankOrders()
        {
            (var operatorId, var startDate, var endDate) = GetUtcTimeByLocalTime();

            var _sbBankOrderMo = new Sb_bank_orderMO();
            _sbBankOrderMo.UseReadConnectionString = true;

            var pageCount = await _sbBankOrderMo.GetPageCountAsync(PAGESIZE, $"BankCallbackTime>=@startdate and BankCallbackTime<@enddate and OperatorID=@OperatorID and UserKind=1 and Status =2", values: new object[] { startDate, endDate, operatorId });

            var bankOrders = new List<Sb_bank_orderEO>();
            IEnumerable<Sb_bank_orderEO> temp;
            for (var page = 1; page <= pageCount; page++)
            {
                temp = await _sbBankOrderMo.GetPagerListAsync(PAGESIZE, page, "BankCallbackTime>=@startdate and BankCallbackTime<@enddate and OperatorID=@OperatorID and UserKind=1 and Status =2", "OrderId", startDate, endDate, operatorId);
                if (null != temp && temp.Any())
                    bankOrders.AddRange(temp);
                    //bankOrders = bankOrders.Concat(temp);
                await Task.Delay(200);
            }
            return bankOrders;
        }

        private async Task<List<Repository.S_user_dayEO>> InitDayUsers()
        {
            var sUserDayMo = new Repository.S_user_dayMO();
            sUserDayMo.UseReadConnectionString = true;
            var dayid = this.ReportDate.Date;

            //var updateRows = await DbSink.MainDb.ExecSqlNonQueryAsync("update s_user_day a,s_user u set a.frommode=u.frommode,a.fromid=u.fromid where a.userid=u.userid and (a.fromid is null or a.fromid='') ;update sc_cash_audit a ,s_user u set a.fromid=u.fromid,a.frommode=u.frommode where a.userid=u.userid and (a.fromid is null or a.fromid='');");

            var pageCount = await sUserDayMo.GetPageCountAsync(PAGESIZE, $"DayID=@dayid and OperatorId=@operatorid and UserKind=1", values: new object[] { dayid, this.OperatorId });
            if (pageCount == 0) return null;

            var result = new List<Repository.S_user_dayEO>();
            IEnumerable<Repository.S_user_dayEO> temp;
            for (var page = 1; page <= pageCount; page++)
            {
                temp = await sUserDayMo.GetPagerListAsync(PAGESIZE, page, "DayID=@dayid and OperatorId=@operatorid and UserKind=1", "RecDate", dayid, this.OperatorId);
                if (null != temp && temp.Any())
                    result.AddRange(temp);
                    //result = result.Concat(temp);

                await Task.Delay(200);
            }
            return result;
        }

        public virtual DateTime GetStartDate()
        {
            return DateTime.MinValue;
        }

        public virtual DateTime GetEndDate()
        {
            return DateTime.MinValue;
        }
    }
}
