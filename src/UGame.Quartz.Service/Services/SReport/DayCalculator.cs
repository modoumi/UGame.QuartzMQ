using System.Data;
using System.Drawing.Printing;
using System.Linq;
using TinyFx.Collections;
using TinyFx.Data.MySql;
using TinyFx.Reflection;
using Xxyy.Common;
using Xxyy.Common.Caching;
using UGame.Quartz.Service.Common;
using UGame.Quartz.Service.Services.SReport;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.BasicReport
{
    public class DayCalculator : ICalculator
    {
        private readonly IDayCalculatorIpo ipo;
        private readonly Xxyy.DAL.S_user_dayMO _sUserDayMo = new();
        private static readonly int[] DAYS = new[] { -1, -3, -7, -14, -20, -30 };
        private static readonly int[] PAYRETENTIONDAYS = new[] { -1,-2, -3,-4,-5,-6,-7, -14, -20, -30 };
        private static readonly int[] BETDAYS = new[] { -1 };
        private static readonly IEnumerable<int> GGRDAYS = Enumerable.Range(-29, 30);
        public DayCalculator(IDayCalculatorIpo ipo)
        {
            _sUserDayMo.UseReadConnectionString = true;
            this.ipo = ipo;
        }

        public async Task<DayCalculatorDto> Execute()
        {
            var cashAuditDict = ipo.CashAuditEos.GroupBy(x => x.Status).ToDictionary(x => x.Key, v => v.Sum(o => o.Amount));
            var operatorEo = DbCacheUtil.GetOperator(ipo.OperatorId);
            var ret = new DayCalculatorDto
            {
                NewUsers = ipo.UserDayEos.Count(x => x.IsNew),
                LoginUsers = ipo.UserDayEos.Count(),
                RegUsers = ipo.UserDayEos.Count(x => x.IsRegister),
                CashUsers = ipo.BankOrderEos.Where(x => x.OrderType == 2).Select(x => x.UserID).Distinct().Count(),
                CashAmount = -ipo.BankOrderEos.Where(x => x.OrderType == 2).Sum(x => x.OrderMoney).MToA(operatorEo.CurrencyID), //ipo.BankOrderEos.Where(x => x.OrderType == 2).Sum(x => x.Amount),
                BonusRecUsers =ipo.CurrencyChangeEos.Where(x=>x.AmountBonus>0).Select(x=>x.UserID).Distinct().Count(),
                BonusAmount=ipo.CurrencyChangeEos.Where(x => x.AmountBonus>0).Sum(x=>x.AmountBonus),
                TotalBalance= 0,//当日用户总账户存量
                BonusRemainAmount = 0,//查询计算
                BonusUnlockAmount=0,
                ActivityDict= ipo.CurrencyChangeEos.Where(x => x.AmountBonus>0&&x.SourceType>=100000&&x.SourceType< 200000).GroupBy(x=>x.SourceType).Select(g=>new { 
                 Key= g.Key,
                 Amount=g.Sum(o=>o.AmountBonus)
                }).ToDictionary(x=>x.Key,x=>x.Amount),
                CashAuditAmount = cashAuditDict.GetValueOrDefault(0,0),
                CashPassAmount= cashAuditDict.GetValueOrDefault(4, 0),
                CashRefuseAmount= cashAuditDict.GetValueOrDefault(2, 0),
                CashFailAmount= cashAuditDict.GetValueOrDefault(5,0),
                PayUsers = ipo.BankOrderEos.Where(x => x.OrderType == 1).Select(x => x.UserID).Distinct().Count(),
                PayAmount = ipo.BankOrderEos.Where(x => x.OrderType == 1).Sum(x => x.Amount),
                BetUsers = ipo.ProviderOrderEos.Where(x => x.ReqMark == 1 || x.ReqMark == 3).Select(x => x.UserID).Distinct().Count(),
                BetAmount = ipo.ProviderOrderEos.Where(x => x.ReqMark != 4).Sum(x => x.PlanBet),
                BetBonus = ipo.ProviderOrderEos.Where(x => x.ReqMark != 4).Sum(x => x.BetBonus),
                WinAmount = ipo.ProviderOrderEos.Where(x => x.ReqMark != 4).Sum(x => x.PlanWin),
                WinBonus = ipo.ProviderOrderEos.Where(x => x.ReqMark != 4).Sum(x => x.WinBonus),
                NewPayUsers = ipo.BankOrderEos.Where(x => x.OrderType == 1 && (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Select(x => x.UserID).Distinct().Count(),
                NewUserPayAmount = ipo.BankOrderEos.Where(x => x.OrderType == 1 && (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.Amount),
                NewCashUsers = ipo.BankOrderEos.Where(x => x.OrderType == 2 && (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Select(x => x.UserID).Distinct().Count(),
                NewUserCashAmount = -ipo.BankOrderEos.Where(x => x.OrderType == 2 && (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.OrderMoney).MToA(operatorEo.CurrencyID), //ipo.BankOrderEos.Where(x => x.OrderType == 2 && (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.Amount),
                CashOwnFee = ipo.BankOrderEos.Where(x => x.OrderType == 2).Sum(x => x.OwnFee),
                CashUserFee = ipo.BankOrderEos.Where(x => x.OrderType == 2).Sum(x => x.UserFee),
                PayOwnFee = ipo.BankOrderEos.Where(x => x.OrderType == 1).Sum(x => x.OwnFee),
                PayUserFee = ipo.BankOrderEos.Where(x => x.OrderType == 1).Sum(x => x.UserFee),
                NewBetUsers = ipo.ProviderOrderEos.Where(x => (x.ReqMark == 1 || x.ReqMark == 3) && (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Select(x => x.UserID).Distinct().Count(),
                DNU_FirstPayAmount = ipo.BankOrderEos.Where(x => x.OrderType == 1 && (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).GroupBy(x => x.UserID).Sum(g => g.OrderBy(x => x.BankCallbackTime).First().Amount),
                DNU_RepayUsers = ipo.BankOrderEos.Where(x => x.OrderType == 1 && (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).GroupBy(x => x.UserID).Count(g => g.Count() > 1),
                NewUserBetAmount = ipo.ProviderOrderEos.Where(x => x.ReqMark != 4).Where(x => (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.PlanBet),
                NewUserBetBonus = ipo.ProviderOrderEos.Where(x => x.ReqMark != 4).Where(x => (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.BetBonus),
                NewUserWinAmount = ipo.ProviderOrderEos.Where(x => x.ReqMark != 4).Where(x => (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x => x.PlanWin),
                NewUserWinBonus=ipo.ProviderOrderEos.Where(x=>x.ReqMark!=4).Where(x => (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false)).Sum(x=>x.WinBonus),
                PayNotBetUsers = ipo.BankOrderEos.Where(x => x.OrderType == 1 && (ipo.GetUserDayEo(x.UserID)?.IsRegister ?? false) && !ipo.ProviderOrderEos.Where(o => o.ReqMark != 4).Any(o => o.UserID == x.UserID)).Select(x => x.UserID).Distinct().Count(),
                DOU_FirstPayUsers = ipo.BankOrderEos.Where(x => x.OrderType == 1).Where(x => {
                    var sUserDayEo = ipo.GetUserDayEo(x.UserID);
                    if (null == sUserDayEo) return false;
                    return sUserDayEo.IsNewPay && !sUserDayEo.IsRegister;
                }).Select(x => x.UserID).Distinct().Count(),
                DOU_FirstPayAmount = ipo.BankOrderEos.Where(x => x.OrderType == 1).Where(x => {
                    var sUserDayEo = ipo.GetUserDayEo(x.UserID);
                    if (null == sUserDayEo) return false;
                    return sUserDayEo.IsNewPay && !sUserDayEo.IsRegister;
                }).GroupBy(x => x.UserID).Sum(g => g.OrderBy(o => o.BankCallbackTime).First().Amount),
                DOU_FirstPayTotalAmount = ipo.BankOrderEos.Where(x => x.OrderType == 1).Where(x => {
                    var sUserDayEo = ipo.GetUserDayEo(x.UserID);
                    if (null == sUserDayEo) return false;
                    return sUserDayEo.IsNewPay && !sUserDayEo.IsRegister;
                }).Sum(o => o.Amount),
                RepeatConsumersD1 = ipo.UserDayEos.Where(u =>
                {
                    if (u.LastLoginTime == null) return false;
                    var days = u.DayID.Subtract(u.LastLoginTime.Value.ToLocalTime(ipo.OperatorId)).TotalDays;
                    return days >= 1;
                }).Select(u => u.UserID).Distinct().Count(),
                RecDate = DateTime.UtcNow
            };
            await this.SetRetentions(ret);
            await this.SetPayRetentions(ret);
            await this.SetBetRetentions(ret);
            await SetGGR(ret);
            return ret;
         }


        /// <summary>
        /// 设置留存率
        /// </summary>
        /// <param name="dayCalculatorDto"></param>
        /// <returns></returns>
        private async Task SetRetentions(DayCalculatorDto dayCalculatorDto)
        {
            var loginUserIds = ipo.UserDayEos.Select(x => x.UserID).Distinct() ?? new List<string>();

            HashSet<string> newUserIds = null;
            foreach (var item in DAYS)
            {
                newUserIds = await GetNewUserIds(ipo.ReportDate.AddDays(item));
                if (newUserIds == null || !newUserIds.Any())
                {
                    continue;
                }
                var retention = newUserIds.Intersect(loginUserIds).Count() / (float)newUserIds.Count();
                ReflectionUtil.SetPropertyValue(dayCalculatorDto,$"RetentionD{-item}",retention);
            }
        }

        /// <summary>
        /// 获取指定日期新增的用户ids数
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="fromMode"></param>
        /// <returns></returns>
        private async Task<HashSet<string>> GetNewUserIds(DateTime startDate)
        {
            string operatorId = ipo.OperatorId;
            var moParams = new List<object> { startDate, operatorId };

            string channelSqlWhere = "";
            //channel分组
            if (ipo.FromMode ==2)
            {
                channelSqlWhere = $" and FromMode=2 and FromId=@FromId ";
                moParams.Add(ipo.GroupKey);
            }
            

            var sqlStr = $"DayID=@DayID and UserKind=1 and OperatorID=@OperatorID and IsNew=1 {channelSqlWhere}";
            var database = new MySqlDatabase();
            database.UseReadConnectionString = true;
            var tb=await database.ExecSqlTableAsync($"select userid from s_user_day where {sqlStr}",values: moParams.ToArray());
            if (null == tb||tb.Rows.Count==0)
                return null;

            var registerUsers = new HashSet<string>();
            foreach (DataRow item in tb.Rows)
            {
                registerUsers.Add(item[0].ToString());
            }
            return registerUsers;
            //var pageCount = await _sUserDayMo.GetPageCountAsync(PAGESIZE, sqlStr, values: moParams.ToArray());
            //if (pageCount == 0) return null;

            //var registerUsers = new HashSet<string>();
            //List<Xxyy.DAL.S_user_dayEO> pageListUserDay = null;
            //for (var page = 1; page <= pageCount; page++)
            //{
            //    pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, sqlStr, values: moParams.ToArray());
            //    if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
            //    foreach (var item in pageListUserDay)
            //    {
            //        registerUsers.Add(item.UserID);
            //    }
            //    await Task.Delay(200);
            //}
            //return registerUsers;
        }

        /// <summary>
        /// 设置充值留存率
        /// </summary>
        /// <param name="dayCalculatorDto"></param>
        /// <returns></returns>
        private async Task SetPayRetentions(DayCalculatorDto dayCalculatorDto)
        {
            var payUserIds = ipo.BankOrderEos.Where(x=>x.OrderType==1).Select(x => x.UserID).Distinct() ?? new List<string>();

            HashSet<string> newPayUserIds = null;
            foreach (var item in PAYRETENTIONDAYS)
            {
                newPayUserIds = await GetNewUserPayIds(ipo.ReportDate.AddDays(item));
                if (newPayUserIds == null || !newPayUserIds.Any())
                {
                    continue;
                }
                var retention = newPayUserIds.Intersect(payUserIds).Count() / (float)newPayUserIds.Count;
                ReflectionUtil.SetPropertyValue(dayCalculatorDto, $"PayRetentionD{-item}",retention);
            }

        }

        /// <summary>
        /// 设置下注留存率
        /// </summary>
        /// <param name="dayCalculatorDto"></param>
        /// <returns></returns>
        private async Task SetBetRetentions(DayCalculatorDto dayCalculatorDto)
        {
            var payUserIds = ipo.UserDayEos.Where(c=>c.HasBet).Select(x => x.UserID).Distinct() ?? new List<string>();

            HashSet<string> newPayUserIds = null;
            foreach (var item in BETDAYS)
            {
                newPayUserIds = await GetNewUserBetIds(ipo.ReportDate.AddDays(item));
                if (newPayUserIds == null || !newPayUserIds.Any())
                {
                    continue;
                }
                var retention = newPayUserIds.Intersect(payUserIds).Count() / (float)newPayUserIds.Count;
                ReflectionUtil.SetPropertyValue(dayCalculatorDto, $"BetD{-item}", retention);
             }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <returns></returns>
        private async Task<HashSet<string>> GetNewUserPayIds(DateTime startDate)
        {
            var moParams = new List<object> { startDate, ipo.OperatorId };

            string channelSqlWhere = "";
            //channel分组
            if (ipo.FromMode == 2)
            {
                channelSqlWhere = $" and FromMode=2 and FromId=@FromId ";
                moParams.Add(ipo.GroupKey);
            }

            var sqlStr = $"DayID=@DayID and UserKind=1 and OperatorID=@OperatorID and IsNew=1 {channelSqlWhere} and HasPay=1";
            var database = new MySqlDatabase();
            database.UseReadConnectionString = true;
            var tb = await database.ExecSqlTableAsync($"select userid from s_user_day where {sqlStr}", values: moParams.ToArray());
            if (null == tb || tb.Rows.Count == 0)
                return null;
            var registerUsers = new HashSet<string>();
            foreach (DataRow row in tb.Rows)
            {
                registerUsers.Add(row[0].ToString());
            }
            //var pageCount = await _sUserDayMo.GetPageCountAsync(PAGESIZE, sqlStr, values: moParams.ToArray());
            //if (pageCount == 0) return null;

            //var registerUsers = new HashSet<string>();
            //List<Xxyy.DAL.S_user_dayEO> pageListUserDay = null;
            //for (var page = 1; page <= pageCount; page++)
            //{
            //    pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, sqlStr, values: moParams.ToArray());
            //    if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
            //    foreach (var item in pageListUserDay)
            //    {
            //        registerUsers.Add(item.UserID);
            //    }
            //    await Task.Delay(200);
            //}
            return registerUsers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <returns></returns>
        private async Task<HashSet<string>> GetNewUserBetIds(DateTime startDate)
        {
            var moParams = new List<object> { startDate, ipo.OperatorId };

            string channelSqlWhere = "";
            //channel分组
            if (ipo.FromMode == 2)
            {
                channelSqlWhere = $" and FromMode=2 and FromId=@FromId ";
                moParams.Add(ipo.GroupKey);
            }

            var sqlStr = $"DayID=@DayID and UserKind=1 and OperatorID=@OperatorID and IsNew=1 {channelSqlWhere} and HasBet=1";
            var database = new MySqlDatabase();
            database.UseReadConnectionString = true;
            var tb = await database.ExecSqlTableAsync($"select userid from s_user_day where {sqlStr}", values: moParams.ToArray());
            if (null == tb || tb.Rows.Count == 0)
                return null;
            var registerUsers = new HashSet<string>();
            foreach (DataRow row in tb.Rows)
            {
                registerUsers.Add(row[0].ToString());
            }
            //var pageCount = await _sUserDayMo.GetPageCountAsync(PAGESIZE, sqlStr, values: moParams.ToArray());
            //if (pageCount == 0) return null;

            //var registerUsers = new HashSet<string>();
            //List<Xxyy.DAL.S_user_dayEO> pageListUserDay = null;
            //for (var page = 1; page <= pageCount; page++)
            //{
            //    pageListUserDay = await _sUserDayMo.GetPagerListAsync(PAGESIZE, page, sqlStr, values: moParams.ToArray());
            //    if (pageListUserDay == null || pageListUserDay.Count == 0) continue;
            //    foreach (var item in pageListUserDay)
            //    {
            //        registerUsers.Add(item.UserID);
            //    }
            //    await Task.Delay(200);
            //}
            return registerUsers;
        }

        /// <summary>
        /// 设置近30天真金GGR
        /// </summary>
        /// <param name="dayCalculatorDto"></param>
        /// <returns></returns>
        private async Task SetGGR(DayCalculatorDto dayCalculatorDto)
        {
            HashSet<string> newUserIds = null;
            foreach (var item in GGRDAYS)
            {
                //获取指定日期新增的用户
                var specialDate = ipo.ReportDate.AddDays(item);
                newUserIds = (specialDate == ipo.ReportDate.Date) ? ipo.UserDayEos.Where(x => x.IsNew).Select(x => x.UserID).ToHashSet() : await GetNewUserIds(specialDate);
                if (newUserIds == null || !newUserIds.Any())
                    continue;
                //计算GGR
                var specialDateGGR = ipo.ProviderOrderEos.Where(x => newUserIds.Contains(x.UserID)).Sum(x => x.PlanBet - x.BetBonus - (x.PlanWin - x.WinBonus));
                ReflectionUtil.SetPropertyValue(dayCalculatorDto, $"DNU_GGR{-item + 1}", specialDateGGR);
            }
        }
    }
}
