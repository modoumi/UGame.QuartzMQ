//using OfficeOpenXml.ConditionalFormatting;
//using TinyFx.Net.Email;
//using Xxyy.Common;
//using Xxyy.Common.Caching;
//using Xxyy.DAL;
//using Xxyy.Quartz.Dal;

//namespace UGame.Quartz.Service.Services.BasicReport
//{

//    /// <summary>
//    /// 运营商每日统计job
//    /// </summary>
//    public class SrOperDayJob : BasicReportJobBase<SrOperDayJob>
//    {
//        private readonly S_user_dayMO _sUserDayMo = new();
//        private readonly Sr_user_dayMO _srUserDayMo = new();
//        private readonly Sr_oper_bank_paytype_dayMO _operBankPaytypeDayMo = new();
//        private readonly Sr_oper_dayEO _eo;
//        private readonly S_currency_changeMO _sCurrencyChangeMo = new();
//        public SrOperDayJob(Sr_oper_dayEO operDayEo)
//        {
//            _eo = operDayEo ?? throw new ArgumentNullException("operDayEo不能为空！");
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="context"></param>
//        /// <returns></returns>
//        public override async Task Execute(BasicReportContext context)
//        {
//            //统计运营商每天新注册，新下注，新充值，新提现以及登录的用户数
//            await HandleOperNewUserDay(context);

//            //统计运营商每天下注用户数,下注金额,充值金额,充值用户数,提现用户数，提现金额
//            await HandleOperBetUserDay(context);

//            //统计运营商每天充值的用户数，提现的用户数以及充值手续费，提现手续费等
//            await HandleOperBankUserDay(context);

//            //统计运营商每天的留存率(1天，3天，7天，15天)
//            await HandleOperRetentionRate(context);

//            //统计活动成本
//            await HandleOperCurrencyChangeDay(context);

//            //统计运营商盈利GGR=betamount-winamount-PromotionFeeAmount
//            HandleOperGGR();
//        }

       

//        #region 统计运营商每天新注册，新下注，新充值，新提现以及登录的用户数
//        /// <summary>
//        /// 统计运营商每天新注册，新下注，新充值，新提现以及登录的用户数
//        /// </summary>
//        /// <param name="context"></param>
//        /// <returns></returns>
//        private async Task HandleOperNewUserDay(BasicReportContext context)
//        {
//            var operatorId = context.OperatorId;
//            var startDate = context.ReportDate;

//            var pageCountUserDay = await _sUserDayMo.GetPageCountAsync(PAGESIZE, $"OperatorID='{context.OperatorId}' and UserKind =1 and RecDate='{context.ReportDate}'");
//            if (pageCountUserDay == 0) return;

//            List<S_user_dayEO> pageListUserDay = null;
//            for (var page = 1; page <= pageCountUserDay; page++)
//            {
//                pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, $"OperatorID='{operatorId}' and UserKind =1 and RecDate='{startDate}'", "RecDate");
//                if (pageListUserDay == null || pageListUserDay.Count == 0) continue;

//                foreach (var item in pageListUserDay)
//                {
//                    _eo.LoginUsers += 1;
//                    _eo.NewUsers += item.IsNew ? 1 : 0;
//                    _eo.RegUsers += item.IsRegister ? 1 : 0;
//                    _eo.NewBetUsers += item.IsNewBet ? 1 : 0;
//                    _eo.NewPayUsers += item.IsNewPay ? 1 : 0;
//                    _eo.NewCashUsers += item.IsNewCash ? 1 : 0;
//                }
//                await Task.Delay(200);
//            }
//        }
//        #endregion

//        #region 统计运营商每天下注用户数
//        /// <summary>
//        /// 统计运营商每天下注用户数,下注金额,充值金额,充值用户数
//        /// </summary>
//        /// <param name="context"></param>
//        /// <returns></returns>
//        private async Task HandleOperBetUserDay(BasicReportContext context)
//        {
//            var operatorId = context.OperatorId;
//            var startDate = context.ReportDate;

//            var pageCount = await _srUserDayMo.GetPageCountAsync(PAGESIZE, $"OperatorID='{operatorId}' and DayID='{startDate}'");
//            if (pageCount == 0) return;
//            List<Sr_user_dayEO> pageListUserDay = null;
//            for (var page = 1; page <= pageCount; page++)
//            {
//                pageListUserDay = await _srUserDayMo.GetPagerListAsync(PAGESIZE, page, $"OperatorID='{operatorId}' and RecDate='{startDate}'", "RecDate");
//                if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
//                foreach (var item in pageListUserDay)
//                {
//                    if (item.BetAmount > 0)
//                        _eo.BetUsers += 1;

//                    _eo.BetAmount += item.BetAmount;
//                    _eo.CashAmount += item.CashAmount;

//                    if (item.PayAmount > 0)
//                        _eo.PayUsers += 1;
//                    _eo.PayAmount += item.PayAmount;
//                }
//                await Task.Delay(200);
//            }
//        }
//        #endregion

//        #region 统计运营商每天充值的用户数，提现的用户数以及充值手续费，提现手续费等

//        /// <summary>
//        /// 统计运营商每天充值的用户数，提现的用户数以及充值手续费，提现手续费等
//        /// </summary>
//        /// <param name="context"></param>
//        /// <returns></returns>
//        private async Task HandleOperBankUserDay(BasicReportContext context)
//        {
//            string operatorId = context.OperatorId;
//            DateTime startDate = context.ReportDate;
//            var operBankUserDayModels = await DbSink.MainDb.ExecSqlListAsync<OperBankUserDayDo>($"select DayID,OperatorID,sum(payusers) as PayUsers,sum(cashusers) as CashUsers,sum(payownfee) as PayOwnFee,sum(PayUserFee) as PayUserFee,sum(CashUserfee) as CashUserFee,sum(CashOwnFee) as CashOwnFee from sr_oper_bank_paytype_day where dayid='{startDate}' and OperatorID='{operatorId}' group by DayID,OperatorID");
//            var bankUserDayModel = operBankUserDayModels?.FirstOrDefault();
//            if (bankUserDayModel == null) return;
//            _eo.PayOwnFee = bankUserDayModel.PayOwnFee;
//            _eo.PayUserFee = bankUserDayModel.PayUserFee;
//            _eo.CashOwnFee = bankUserDayModel.CashOwnFee;
//            _eo.CashUserFee= bankUserDayModel.CashUserFee;
//        }
//        #endregion

//        #region 统计运营商每天的留存率(1天，3天，7天，15天)
//        /// <summary>
//        /// 统计运营商每天的留存率(1天，3天，7天，15天)
//        /// </summary>
//        /// <param name="context"></param>
//        /// <returns></returns>
//        private async Task HandleOperRetentionRate(BasicReportContext context)
//        {
//            string operatorId = context.OperatorId;
//            DateTime startDate = context.ReportDate;

//            var loginUsers = await GetYesterdayLoginUsers(operatorId, startDate);
//            if (null == loginUsers || loginUsers.Count == 0) return;
//            //1.1天留存率 （昨天登录的用户数/昨天-1 注册的用户数）
//            var regUsers = await GetRegisterUsers(operatorId, startDate.AddDays(-1));
//            var intersectUsers = loginUsers.Intersect(regUsers);
//            if (regUsers != null && regUsers.Count() != 0)
//                _eo.RetentionD1 = intersectUsers.Count() / regUsers.Count();

//            //2.3天留存率 （昨天登录的用户数/昨天-3 注册的用户数）
//            regUsers = await GetRegisterUsers(operatorId, startDate.AddDays(-3));
//            intersectUsers = loginUsers.Intersect(regUsers);
//            if (regUsers != null && regUsers.Count() != 0)
//                _eo.RetentionD3 = intersectUsers.Count() / regUsers.Count();

//            //2.7天留存率 （昨天登录的用户数/昨天-7 注册的用户数）
//            regUsers = await GetRegisterUsers(operatorId, startDate.AddDays(-7));
//            intersectUsers = loginUsers.Intersect(regUsers);
//            if (regUsers != null && regUsers.Count() != 0)
//                _eo.RetentionD7 = intersectUsers.Count() / regUsers.Count();

//            //2.15天留存率 （昨天登录的用户数/昨天-15 注册的用户数）
//            regUsers = await GetRegisterUsers(operatorId, startDate.AddDays(-15));
//            intersectUsers = loginUsers.Intersect(regUsers);
//            if (regUsers != null && regUsers.Count() != 0)
//                _eo.RetentionD15 = intersectUsers.Count() / regUsers.Count();
//        }

//        /// <summary>
//        /// 获取昨天登录的用户数
//        /// </summary>
//        /// <param name="operatorId"></param>
//        /// <param name="startDate"></param>
//        /// <returns></returns>
//        private async Task<HashSet<string>> GetYesterdayLoginUsers(string operatorId, DateTime startDate)
//        {
//            var pageCount = await _sUserDayMo.GetPageCountAsync(PAGESIZE, $"DayID='{startDate}' and UserKind=1 and OperatorID='{operatorId}' and IsLogin=1");
//            if (pageCount == 0) return null;
//            //昨天登录的用户数
//            var loginUsers = new HashSet<string>();
//            List<S_user_dayEO> pageListUserDay = null;
//            for (var page = 1; page <= pageCount; page++)
//            {
//                pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, $"DayID='{startDate}' and UserKind=1 and OperatorID='{operatorId}' and IsLogin=1");
//                if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
//                foreach (var item in pageListUserDay)
//                {
//                    loginUsers.Add(item.UserID);
//                }
//                await Task.Delay(200);
//            }
//            return loginUsers;
//        }

//        /// <summary>
//        /// 获取指定日期注册的用户数
//        /// </summary>
//        /// <param name="operatorId"></param>
//        /// <param name="startDate"></param>
//        /// <returns></returns>
//        private async Task<HashSet<string>> GetRegisterUsers(string operatorId, DateTime startDate)
//        {
//            var pageCount = await _sUserDayMo.GetPageCountAsync(PAGESIZE, $"DayID='{startDate}' and UserKind=1 and OperatorID='{operatorId}' and IsRegister=1");
//            if (pageCount == 0) return null;
//            //昨天登录的用户数
//            var registerUsers = new HashSet<string>();
//            List<S_user_dayEO> pageListUserDay = null;
//            for (var page = 1; page <= pageCount; page++)
//            {
//                pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, $"DayID='{startDate}' and UserKind=1 and OperatorID='{operatorId}' and IsRegister=1");
//                if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
//                foreach (var item in pageListUserDay)
//                {
//                    registerUsers.Add(item.UserID);
//                }
//                await Task.Delay(200);
//            }
//            return registerUsers;
//        }
//        #endregion

//        #region 统计运营商盈利GGR
//        /// <summary>
//        /// 统计运营商盈利GGR
//        /// </summary>
//        /// <returns></returns>
//        private void HandleOperGGR()
//        {
//            this._eo.ProfitAmount = this._eo.BetAmount - this._eo.WinAmount - this._eo.PromotionFeeAmount;
//        }
//        #endregion

//        #region 统计活动成本
//        /// <summary>
//        /// 统计活动成本
//        /// </summary>
//        /// <param name="context"></param>
//        /// <returns></returns>
//        private async Task HandleOperCurrencyChangeDay(BasicReportContext context)
//        {
//            var operatorId = context.OperatorId;
//            var startDate = context.ReportDate;
//            var endDate = context.ReportDate.AddDays(1);

//            var pageCount = await _sCurrencyChangeMo.GetPageCountAsync(PAGESIZE, $"OperatorID='{operatorId}' and RecDate>='{startDate}' and RecDate<'{endDate}'");
//            if (pageCount == 0) return;
//            List<S_currency_changeEO> pageList = null;
//            for (var page = 1; page <= pageCount; page++)
//            {
//                pageList = await _sCurrencyChangeMo.GetPagerListAsync(PAGESIZE, page, $"OperatorID='{operatorId}' and RecDate>='{startDate}' and RecDate<'{endDate}'", "RecDate");
//                if (pageList == null || pageList.Count == 0) continue;
//                foreach (var item in pageList)
//                {
//                    _eo.PromotionFeeAmount += item.Amount;
//                }
//                await Task.Delay(200);
//            }
//        }
//        #endregion
//    }
//}
