using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Data.MySql;
using UGame.Quartz.Service.Services.DingTalk;
using Xxyy.Common;
using Xxyy.Common.Caching;

namespace UGame.Quartz.Service.Common.SqlSink
{
    public class DingTalkSqlSink
    {
        private MySqlDatabase _readDb;
        public DingTalkSqlSink()
        {
            _readDb = new MySqlDatabase();
            _readDb.UseReadConnectionString = true;
        }

        #region 查询平台20分钟净输赢

        /// <summary>
        /// 查询平台20分钟净输赢
        /// </summary>
        /// <returns></returns>
        private string SelectPlatformWinAndLossSql()
        {
            return $@"select 
	                        providerOrder.OperatorID,
	                        SUM(PlanBet) as sumBet,
	                        SUM(PlanWin) as sumWin,
	                        SUM(BetBonus) as sumBonusBet,
	                        SUM(WinBonus) as sumBonusWin
                        from s_provider_order as providerOrder
                        where ResponseTime >= @startTime and ResponseTime < @endTime and OperatorID = @OperatorID and ReqMark!=4 
                        and UserKind = 1
                        and `Status` = 2
                        group by providerOrder.OperatorID";
        }

        /// <summary>
        /// 查询平台20分钟净输赢
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<DingTalkDto> SelectPlatformWinAndLoss(DingTalkIpo ipo)
        {
            string sql = SelectPlatformWinAndLossSql();

            return await _readDb.ExecSqlSingleAsync<DingTalkDto>(sql, ipo.startTime, ipo.endTime, ipo.operatorId);
        }

        #endregion

        #region app每20分钟游戏活跃度top

        /// <summary>
        /// app每20分钟游戏活跃度top
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<DingTalkAppPvDto>> WriteTopAppPV(DingTalkIpo ipo)
        {
            return new List<DingTalkAppPvDto>();
            //string sql = @$"   select providerOrder.AppID,
	           //                        count(distinct(userid)) as betUsers
            //                        from s_provider_order as providerOrder
            //                        where ResponseTime >= @StartTime and ResponseTime<@EndTime 
            //                        and providerOrder.OperatorID = @OperatorID
            //                        and ReqMark!=4 and UserKind = 1 and providerOrder.`Status` = 2 group by providerOrder.AppID order by betUsers desc limit {ipo.pushConfigEo.GameTop}
            //";

            //var result= await _readDb.ExecSqlListAsync<DingTalkAppPvDto>(sql.ToString(), ipo.startTime, ipo.endTime, ipo.operatorId);
            //if(result!=null&&result.Any())
            //{
            //    foreach (var item in result)
            //    {
            //        item.AppName = DbCacheUtil.GetApp(item.AppID,false)?.AppName;
            //    }
            //}
            //return result;
        }
        #endregion

        #region app每20分钟真金下注top

        /// <summary>
        /// app每20分钟真金下注top
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<DingTalkBetCashDto>> WriteTopAppBetCash(DingTalkIpo ipo)
        {
            string sql = @$"   select providerOrder.AppID,
	                                    SUM(PlanBet-BetBonus) as sumBet
                                    from s_provider_order as providerOrder
                                    where ResponseTime >= @StartTime and ResponseTime<@EndTime and providerOrder.OperatorID = @OperatorID and ReqMark!=4 and UserKind = 1 and providerOrder.`Status` = 2 group by providerOrder.AppID order by sumBet desc limit {ipo.pushConfigEo.GameTop}
            ";

            var result= await _readDb.ExecSqlListAsync<DingTalkBetCashDto>(sql.ToString(), ipo.startTime, ipo.endTime, ipo.operatorId);
            if(null!=result&&result.Any())
            {
                foreach (var item in result)
                {
                    item.AppName = DbCacheUtil.GetApp(item.AppID,false)?.AppName;
                }
            }
            return result;
        }
        #endregion

        #region app每20分钟净盈利、净亏损top

        /// <summary>
        /// app每20分钟净盈利、净亏损top
        /// </summary>
        /// <returns></returns>
        private StringBuilder SelectTopAppProfitOrLossSql()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($@"
                                    select 
	                                    providerOrder.OperatorID,
	                                    providerOrder.AppID,
	                                    SUM(PlanBet) as sumBet,
	                                    SUM(PlanWin) as sumWin,
	                                    SUM(PlanBet) - SUM(PlanWin) as sumResult,
                                        SUM(BetBonus) as sumBonusBet,
	                                    SUM(WinBonus) as sumBonusWin
                                    from s_provider_order as providerOrder
                                    where ResponseTime >= @StartTime and ResponseTime < @EndTime and OperatorID = @OperatorID and ReqMark!=4 and UserKind = 1 and `Status` = 2 group by providerOrder.OperatorID,providerOrder.AppID
                                    ");

            return stringBuilder;
        }

        /// <summary>
        /// app每20分钟净盈利、净亏损top
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<DingTalkDto>> SelectTopAppProfitOrLoss(DingTalkIpo ipo)
        {
            StringBuilder sql = SelectTopAppProfitOrLossSql();
            if (ipo.profitOrLoss)
                sql.Append(" having sumResult > 0 order by sumResult desc ");
            //sql.Append(" where result.sumResult > 0 order by result.sumResult desc ");
            else
                sql.Append(" having sumResult < 0 order by sumResult ");
            //sql.Append(" where result.sumResult < 0 order by result.sumResult ");

            sql.Append($"limit {ipo.pushConfigEo.GameTop}");


            return await _readDb.ExecSqlListAsync<DingTalkDto>(sql.ToString(), ipo.startTime, ipo.endTime, ipo.operatorId);
        }

        #endregion


        #region 用户每20分钟净盈利、净亏损top

        /// <summary>
        /// 用户每20分钟净盈利、净亏损top
        /// </summary>
        /// <returns></returns>
        private StringBuilder SelectTopUserProfitOrLossSql()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($@"
	                                    select 
		                                    providerOrder.OperatorID,
		                                    providerOrder.UserID,
		                                    SUM(PlanBet) as sumBet,
		                                    SUM(PlanWin) as sumWin,
		                                    (SUM(PlanBet) - SUM(PlanWin)) as sumResult
	                                    from s_provider_order as providerOrder
	                                    where ResponseTime >= @StartTime and ResponseTime < @EndTime and OperatorID = @OperatorID and ReqMark!=4 and UserKind = 1 and `Status` = 2 group by providerOrder.OperatorID,providerOrder.UserID
                                    ");

            return stringBuilder;
        }

        /// <summary>
        /// 用户每20分钟净盈利、净亏损top
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<List<DingTalkDto>> SelectTopUserProfitOrLoss(DingTalkIpo ipo)
        {
            StringBuilder sql = SelectTopUserProfitOrLossSql();
            if (ipo.profitOrLoss)
                sql.Append(" having sumResult < 0 order by sumResult asc ");
            //sql.Append(" where result.sumResult > 0 order by result.sumResult desc ");
            else
                sql.Append(" having sumResult > 0 order by sumResult desc ");
            //sql.Append(" where result.sumResult < 0 order by result.sumResult ");

            sql.Append($" limit {ipo.pushConfigEo.UserTop}");


            return await _readDb.ExecSqlListAsync<DingTalkDto>(sql.ToString(), ipo.startTime, ipo.endTime, ipo.operatorId);
        }

        #endregion


        #region 用户每20分钟提现、存款总额

        /// <summary>
        /// 用户每20分钟提现、存款总额
        /// </summary>
        /// <returns></returns>
        private StringBuilder SelectSumUserDepositOrWithdrawSql()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($@"select 
	                                    bankOrder.OperatorID,
	                                    SUM(bankOrder.Amount) as sumResult
                                    from sb_bank_order as bankOrder
                                    where bankOrder.OperatorID = @OperatorID
                                    and bankOrder.`Status` = 2
                                    and bankOrder.OrderType = @OrderType
                                    and bankOrder.UserKind = 1
                                    and bankOrder.BankCallbackTime >= @StartTime and bankOrder.BankCallbackTime < @EndTime
                                    group by bankOrder.OperatorID,bankOrder.CurrencyID");
            return stringBuilder;
        }

        public async Task<DingTalkDto> SelectSumUserDepositOrWithdraw(DingTalkIpo ipo)
        {
            StringBuilder sql = SelectSumUserDepositOrWithdrawSql();

            return await _readDb.ExecSqlSingleAsync<DingTalkDto>(sql.ToString(), ipo.operatorId, ipo.depositOrWithdraw ? 1 : 2, ipo.startTime, ipo.endTime);
        }

        #endregion


        #region 每小时注册用户数量

        /// <summary>
        /// 每小时注册用户数量sql
        /// </summary>
        /// <returns></returns>
        private string SelectRegisterUsersSql()
        {
            return $@"select 
	                        OperatorID,
	                        Count(*) as registerUsers
                        from s_user_day
                        where OperatorID = @OperatorID
                        and UserKind = 1
                        and RegistDate >= @StartTime and RegistDate < @EndTime
                        group by OperatorID;";
        }

        /// <summary>
        /// 每小时注册用户数量
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<DingTalkDto> SelectRegisterUsers(DingTalkIpo ipo)
        {
            //string sql = SelectRegisterUsersSql();

            //return await _readDb.ExecSqlSingleAsync<DingTalkDto>(sql, ipo.operatorId, ipo.startTime, ipo.endTime);

            string sql = $@"select FromId as Channel, count(*) as RegisterCount from s_user
                            where OperatorID = @OperatorID
                            and UserKind = 1
                            and FromMode=2 
                            and RegistDate >= @StartTime and RegistDate < @EndTime
                            group by FromId";
            var ret = new DingTalkDto();
            ret.Registers = await _readDb.ExecSqlListAsync<RegisterUsersDto>(sql, ipo.operatorId, ipo.startTime, ipo.endTime);
            return ret;
        }

        #endregion

        #region 每小时下注用户数量

        private string SelectBetUsersSql()
        {
            return $@"select 
	                        SUM(PlanBet) as betUsers
                        from s_provider_order
                        where ResponseTime >= @StartTime and ResponseTime < @EndTime and OperatorID = @OperatorID  and ReqMark!=4 and UserKind = 1 and `Status` = 2";
        }

        public async Task<DingTalkDto> SelectBetUsers(DingTalkIpo ipo)
        {
            string sql = SelectBetUsersSql();
            return await _readDb.ExecSqlSingleAsync<DingTalkDto>(sql, ipo.startTime, ipo.endTime, ipo.operatorId);
        }

        #endregion

        #region 用户充值数量

        public async Task<DingTalkDto> SelectPayUsers(DingTalkIpo ipo)
        {
            string sql = $@"

select 
	(case when RegistDate>=@StartTime and RegistDate<@EndTime then 1 else 0 end) isToday,
	SUM(bankOrder.Amount) as payAmount,
			count(distinct(userid)) as count
	from sb_bank_order as bankOrder where bankOrder.BankCallbackTime >= @StartTime and bankOrder.BankCallbackTime < @EndTime
	and OperatorID = @OperatorID and bankOrder.UserKind = 1 and bankOrder.`Status` = 2 and bankOrder.OrderType = 1 
	group by isToday
";
            var ret = new DingTalkDto();
            ret.PayUsers = await _readDb.ExecSqlListAsync<PayUser>(sql, ipo.startTime, ipo.endTime, ipo.operatorId);
            return ret;
        }

        public async Task<DingTalkDto> SelectFromIdPayUsers(DingTalkIpo ipo)
        {
            string sql = $@"
select 
	bankOrder.FromId,
	(case when RegistDate>=@StartTime and RegistDate<@EndTime then 1 else 0 end) isToday,
	SUM(bankOrder.Amount) as payAmount,
			count(distinct(userid)) as count
	from sb_bank_order as bankOrder where bankOrder.BankCallbackTime >= @StartTime and bankOrder.BankCallbackTime < @EndTime
	and OperatorID = @OperatorID and bankOrder.UserKind = 1 and bankOrder.`Status` = 2 and bankOrder.OrderType = 1 and frommode=2
	group by FromId,isToday
";
            var ret = new DingTalkDto();
            ret.PayUsers = await _readDb.ExecSqlListAsync<PayUser>(sql, ipo.startTime, ipo.endTime, ipo.operatorId);
            return ret;
        }

        #endregion


        #region 累计送出bonus

        /// <summary>
        /// 查询累计送出bonus
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<DingTalkDto> SelectDaySendBonus(DingTalkIpo ipo)
        {
            string sql = $@"select
	                            SUM(OrderAmount) as SumSendBonus
                            from s_requireflow_order
                            where RecDate >= @StartTime and RecDate < @EndTime and OperatorID = @OperatorID
                            and IsBonus = 1";

            var ret = new DingTalkDto();

            var SumSendBonus = await _readDb.ExecSqlScalarAsync<long?>(sql, ipo.startTime, ipo.endTime, ipo.operatorId);

            if(SumSendBonus.HasValue)
                ret.SumSendBonus = SumSendBonus.Value;

            return ret;
        }

        #endregion

        #region bonus实际转化为真金的数额

        /// <summary>
        /// bonus实际转化为真金的数额
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<DingTalkDto> SelectBonusToCash(DingTalkIpo ipo)
        {
            string sql = $@"select
	                            SUM(OrderRemain) as SumBonusToCash
                            from s_requireflow_order
                            where OperatorID = @OperatorID
                            and IsBonus = 1
                            and `Status` = 1
                            and RecDate >= @StartTime and RecDate < @EndTime";

            var ret = new DingTalkDto();

            var SumBonusToCash = await _readDb.ExecSqlScalarAsync<long?>(sql, ipo.operatorId, ipo.startTime, ipo.endTime);

            if(SumBonusToCash.HasValue)
                ret.SumBonusToCash = SumBonusToCash.Value;

            return ret;
        }

        #endregion

        #region 所有用户bonus存量

        /// <summary>
        /// 所有用户bonus存量
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<DingTalkDto> SelectSumUserBonus(DingTalkIpo ipo)
        {
            string sql = $@"select 
	                            Sum(Bonus) as SumUserBonus
                            from s_user 
                            where UserKind = 1
                            and OperatorID = @OperatorID";

            var ret = await _readDb.ExecSqlSingleAsync<DingTalkDto>(sql, ipo.operatorId);
            return ret;
        }

        #endregion

    }
}
