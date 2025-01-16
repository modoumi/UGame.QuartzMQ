using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using UGame.Quartz.Service.Services.SReport;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Quartz;
using UGame.Quartz.Service.Common;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.BasicReport.UserDayWorker
{
    public class SRUserDayJob : JobBase//ISRDayWorker
    {
        private ILogger<SRUserDayJob> _logger;
        //private readonly OperatorDayContext _context;
        private readonly Sr_user_dayMO _srUserDayMo = new();
        /// <summary>
        /// 批量插入的条数
        /// </summary>
        protected const int BATCHCOUNT = 5000;

        //public SRUserDayJob(OperatorDayContext context)
        //{
        //    _logger = LogUtil.CreateLogger<SRUserDayJob>();
        //    _context = context;
        //}
        public SRUserDayJob()
        {
            _logger = LogUtil.CreateLogger<SRUserDayJob>();
           // _context = context;
        }

        public override async Task Execute(OperatorDayContext _context)
        {
            var startTime = DateTime.UtcNow;

            var tm = new DbTransactionManager();
            try
            {
                _logger.LogInformation("开始执行SRUserDayJob！dayid:{0},operatorid:{1}",_context.ReportDate,_context.OperatorId);
                var userDayDict =await this.HandleSUserDay(_context);
                userDayDict = await this.HandleBetOrder(userDayDict,_context);
                userDayDict=await this.HandleCurrencyChangeDay(userDayDict, _context);
                userDayDict =await HandleCashAuditDay(userDayDict,_context);
                var result =await this.HandleBankUserDay(userDayDict,_context);
                
                var userEndBalanceBonusDict = _context.GetUserLastEndBalanceBonus().ToDictionary(x=>x.UserId);
                if (null != result)
                {
                    foreach (var item in result)
                    {
                        if (!userEndBalanceBonusDict.ContainsKey(item.Key))
                            continue;
                        var userEndBalanceBonus = userEndBalanceBonusDict[item.Key];
                        item.Value.EndBalance = userEndBalanceBonus.EndBalance;
                        item.Value.EndBonus = userEndBalanceBonus.EndBonus;
                    }
                }
                tm.Begin();
                if (result != null && result.Values != null && result.Values.Any())
                {
                    //0.先清理operatorid，和startdate 
                    //await _srUserDayMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm,_context.ReportDate.Date,_context.OperatorId);
                    var db = tm.GetDb<Sr_user_dayPO>();
                    var delRet = await db.Deleteable<Sr_user_dayPO>().Where(x => x.DayID == _context.ReportDate.Date && x.OperatorID == _context.OperatorId).ExecuteCommandAsync();//.DeleteAsync(x=>x.DayID==_context.ReportDate.Date&&x.OperatorID==_context.OperatorId);
                    var rows = await db.Fastest<Sr_user_dayPO>().PageSize(BATCHCOUNT).BulkCopyAsync(result.Values.ToList());

                    //await _srUserDayMo.AddByBatchAsync(result.Values, BATCHCOUNT, tm);
                    tm.Commit();
                }
                else
                {
                    tm.Rollback();
                }
                _logger.LogInformation("sr_user_day处理完成{0},operatorId:{1} => count: {2}", _context.ReportDate, _context.OperatorId, result?.Values?.Count ?? 0);
                var endTime = DateTime.UtcNow;
                await MQUtil.PublishAsync(new SRPerDayMsg
                {
                    DayId = _context.ReportDate,
                    OperatorId=_context.OperatorId,
                    SRStartTime = startTime,
                    SREndTime = endTime,
                    Type = SRPerDayType.SrUserDay
                });

                //LogUtil.Info("after,SRUserDayWorker，{0}!param:{1}", MethodBase.GetCurrentMethod()?.Name);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                _logger.LogError(ex, "sr_user_day处理出错!dayid:{0},operatorid:{1}",_context.ReportDate,_context.OperatorId);
            }

        }

        /// <summary>
        /// 统计运营商下用户每日注册数
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task<Dictionary<string, Sr_user_dayPO>> HandleSUserDay(OperatorDayContext _context)
        {
            var dict = new Dictionary<string, Sr_user_dayPO>();
            if (null == _context.UserDayEos || !_context.UserDayEos.Any()) return dict;

            var recDate = DateTime.UtcNow;
            GlobalUserDCache userDCache = null;
            foreach (var sUserDayEo in _context.UserDayEos)
            {
                if (!dict.ContainsKey(sUserDayEo.UserID))
                {
                    try
                    {
                        userDCache = await GlobalUserDCache.Create(sUserDayEo.UserID);
                    }
                    catch (Exception ex)
                    {
                        LogUtil.Error(ex, "sruserday.HandleSUserDay中获取GlobalUserDCache缓存异常！");
                    }
                    //var userInfoDict = await userDCache?.GetAsync(new List<string> { "RegistDate", "Mobile" });
                    //var registDate = (await userDCache?.GetRegistDateAsync())??DateTime.MinValue;
                    //var mobile = (await userDCache?.GetMobileAsync())??"";
                    dict.Add(sUserDayEo.UserID, new Sr_user_dayPO
                    {
                        DayID = _context.ReportDate.Date,
                        UserID = sUserDayEo.UserID,
                        UserKind = sUserDayEo.UserKind,
                        OperatorID = sUserDayEo.OperatorID,
                        CountryID = sUserDayEo.CountryID,
                        CurrencyID = sUserDayEo.CurrencyID,
                        FromMode = sUserDayEo.FromMode,
                        FromId = sUserDayEo.FromId,
                        IsNew = sUserDayEo.IsNew,
                        IsLogin = sUserDayEo.IsLogin,
                        LoginDays = sUserDayEo.LoginDays,
                        LastLoginTime = sUserDayEo.LastLoginTime ?? DateTime.MinValue,
                        IsRegister = sUserDayEo.IsRegister,
                        RegistDate = (await userDCache?.GetRegistDateAsync()) ?? DateTime.MinValue,//((DateTime?)userInfoDict?.GetValueOrDefault("RegistDate",new TinyFx.Caching.CacheValue<object>(DateTime.MinValue)).Value)??DateTime.MinValue, //sUserDayEo.RegistDate??DateTime.MinValue,
                        IsNewBet = sUserDayEo.IsNewBet,
                        HasBet = sUserDayEo.HasBet,
                        IsNewPay = sUserDayEo.IsNewPay,
                        HasPay = sUserDayEo.HasPay,
                        IsNewCash = sUserDayEo.IsNewCash,
                        HasCash = sUserDayEo.HasCash,
                        BetCount = 0,
                        BetAmount = 0,
                        BetBonus = 0,
                        WinCount = 0,
                        WinAmount = 0,
                        WinBonus = 0,
                        RecDate = recDate,
                        UserIp = sUserDayEo.UserIp,
                        Mobile = (await userDCache?.GetMobileAsync()) ?? "",//(string)userInfoDict?.GetValueOrDefault("Mobile",new TinyFx.Caching.CacheValue<object>("")).Value //await userDCache.GetMobileAsync()
                        Username = (await userDCache?.GetUsernameAsync()) ?? "",
                        Nickname = (await userDCache?.GetNicknameAsync()) ?? ""
                    });
                }
                else
                {
                    this._logger.LogInformation("s_user_day表中userid：{0}重复！", sUserDayEo.UserID);
                }
            }
            return dict;
        }

        
        /// <summary>
        /// 统计运营商下用户每日下注和返奖(BetAmount,WinAmount)
        /// </summary>
        /// <param name="srUserDayDict"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task<Dictionary<string, Sr_user_dayPO>> HandleBetOrder(Dictionary<string, Sr_user_dayPO> srUserDayDict, OperatorDayContext _context)
        {
            if (null == _context.ProviderOrderEos || !_context.ProviderOrderEos.Any()) return srUserDayDict;
            srUserDayDict ??= new();

            var recDate = DateTime.UtcNow;
            GlobalUserDCache userDCache = null;
            foreach (var order in _context.ProviderOrderEos)
            {
                if (!srUserDayDict.ContainsKey(order.UserID))
                {
                    try
                    {
                        userDCache = await GlobalUserDCache.Create(order.UserID);
                    }
                    catch (Exception ex)
                    {
                        LogUtil.Error(ex, "sruserday.HandleBetOrder中获取GlobalUserDCache缓存异常！");
                    }
                    //var userInfoDict = await userDCache?.GetAsync(new List<string> { "RegistDate", "Mobile" });
                    var sUserDayEo = _context.GetUserDayEo(order.UserID);
                    srUserDayDict.Add(order.UserID, new Sr_user_dayPO
                    {
                        DayID = _context.ReportDate.Date,
                        UserID = order.UserID,
                        UserKind = order.UserKind,
                        OperatorID = order.OperatorID,
                        CountryID = order.CountryID,
                        CurrencyID = order.CurrencyID,
                        FromMode = order.FromMode,
                        FromId = order.FromId,
                        IsNew = sUserDayEo?.IsNew ?? false,
                        IsLogin = sUserDayEo?.IsLogin ?? false,
                        LoginDays = sUserDayEo?.LoginDays ?? 0,
                        LastLoginTime = sUserDayEo?.LastLoginTime ?? DateTime.MinValue,
                        IsRegister = sUserDayEo?.IsRegister ?? false,
                        RegistDate = (await userDCache?.GetRegistDateAsync()) ?? DateTime.MinValue,//((DateTime?)userInfoDict?.GetValueOrDefault("RegistDate", new TinyFx.Caching.CacheValue<object>(DateTime.MinValue)).Value) ?? DateTime.MinValue,//sUserDayEo?.RegistDate?? DateTime.MinValue,
                        IsNewBet = sUserDayEo?.IsNewBet ?? false,
                        HasBet = sUserDayEo?.HasBet ?? false,
                        IsNewPay = sUserDayEo?.IsNewPay ?? false,
                        HasPay = sUserDayEo?.HasPay ?? false,
                        IsNewCash = sUserDayEo?.IsNewCash ?? false,
                        HasCash = sUserDayEo?.HasCash ?? false,
                        BetCount = (order.ReqMark == 1 || order.ReqMark == 3) ? 1 : 0,
                        BetAmount = order.PlanBet,
                        BetBonus = order.BetBonus,
                        WinCount = (order.ReqMark == 2 || order.ReqMark == 3) ? 1 : 0,
                        WinAmount = order.PlanWin,
                        WinBonus = order.WinBonus,
                        RecDate = recDate,
                        UserIp = sUserDayEo?.UserIp,
                        Mobile = (await userDCache?.GetMobileAsync()) ?? "",//(string)userInfoDict?.GetValueOrDefault("Mobile", new TinyFx.Caching.CacheValue<object>("")).Value//await (await GlobalUserDCache.Create(order.UserID)).GetMobileAsync()
                        Username = (await userDCache?.GetUsernameAsync()) ?? "",
                        Nickname = (await userDCache?.GetNicknameAsync()) ?? ""
                    });
                }
                else
                {
                    var eo = srUserDayDict[order.UserID];
                    if (order.ReqMark == 1 || order.ReqMark == 3)
                    {
                        eo.BetCount += 1;
                    }
                    eo.BetAmount += order.PlanBet;
                    eo.BetBonus += order.BetBonus;
                    if (order.ReqMark == 2 || order.ReqMark == 3)
                    {
                        eo.WinCount += 1;
                    }
                    eo.WinAmount += order.PlanWin;
                    eo.WinBonus += order.WinBonus;
                }
            }
            return srUserDayDict;
        }


        /// <summary>
        /// 统计运营商下用户每日充值、提现
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task<Dictionary<string, Sr_user_dayPO>> HandleBankUserDay(Dictionary<string,Sr_user_dayPO> srUserDayDict,OperatorDayContext _context)
        {
            if (null == _context.BankOrderEos || !_context.BankOrderEos.Any()) return srUserDayDict;
            srUserDayDict ??= new();
            var operatorEo = DbCacheUtil.GetOperator(_context.OperatorId);
            GlobalUserDCache userDCache = null;
            foreach (var item in _context.BankOrderEos)
            {
                if (!srUserDayDict.ContainsKey(item.UserID))
                {
                    try
                    {
                        userDCache = await GlobalUserDCache.Create(item.UserID);
                    }
                    catch (Exception ex)
                    {
                        LogUtil.Error(ex, "sruserday.HandleBankUserDay中获取GlobalUserDCache缓存异常！");
                    }
                    var sUserDayEo = _context.GetUserDayEo(item.UserID);
                    //var userInfoDict = await userDCache?.GetAsync(new List<string> { "RegistDate", "Mobile" });
                    var eo = new Sr_user_dayPO
                    {
                        DayID = _context.ReportDate.Date,
                        UserID = item.UserID,
                        UserKind=item.UserKind,
                        OperatorID = item.OperatorID,
                        CountryID = operatorEo.CountryID,
                        CurrencyID =item.CurrencyID,
                        FromId = item.FromId,
                        FromMode = item.FromMode,
                        IsNew = sUserDayEo?.IsNew ?? false,
                        IsLogin = sUserDayEo?.IsLogin ?? false,
                        LoginDays = sUserDayEo?.LoginDays ?? 0,
                        LastLoginTime = sUserDayEo?.LastLoginTime ?? DateTime.MinValue,
                        IsRegister = sUserDayEo?.IsRegister ?? false,
                        RegistDate = (await userDCache?.GetRegistDateAsync()) ?? DateTime.MinValue,//((DateTime?)userInfoDict?.GetValueOrDefault("RegistDate", new TinyFx.Caching.CacheValue<object>(DateTime.MinValue)).Value) ?? DateTime.MinValue,
                        IsNewBet = sUserDayEo?.IsNewBet ?? false,
                        HasBet = sUserDayEo?.HasBet ?? false,
                        IsNewPay = sUserDayEo?.IsNewPay ?? false,
                        HasPay = sUserDayEo?.HasPay ?? false,
                        IsNewCash = sUserDayEo?.IsNewCash ?? false,
                        HasCash = sUserDayEo?.HasCash ?? false,
                        PayCount=item.OrderType==1?1:0,
                        PayAmount = item.OrderType == 1 ? item.Amount : 0,
                        CashCount=item.OrderType==2?1:0,
                        CashAmount = item.OrderType == 2 ? item.Amount : 0,
                        PayOwnFee = item.OrderType == 1 ? item.OwnFee : 0,
                        PayUserFee = item.OrderType == 1 ? item.UserFee : 0,
                        CashOwnFee = item.OrderType == 2 ? item.OwnFee : 0,
                        CashUserFee = item.OrderType == 2 ? item.UserFee : 0,
                        UserIp=sUserDayEo?.UserIp,
                        Mobile= (await userDCache?.GetMobileAsync()) ?? "",//(string)userInfoDict?.GetValueOrDefault("Mobile", new TinyFx.Caching.CacheValue<object>("")).Value
                        Username = (await userDCache?.GetUsernameAsync()) ?? "",
                        Nickname = (await userDCache?.GetNicknameAsync()) ?? ""
                    };
                    srUserDayDict.Add(item.UserID, eo);
                }
                else
                {
                    var eo = srUserDayDict[item.UserID];
                    if (item.OrderType == 1)
                    {
                        eo.PayCount += 1;
                    }
                    eo.PayAmount = eo.PayAmount + (item.OrderType == 1 ? item.Amount : 0);
                    if(item.OrderType==2)
                    {
                        eo.CashCount += 1;
                    }
                    eo.CashAmount = eo.CashAmount + (item.OrderType == 2 ? item.Amount : 0);
                    eo.PayUserFee = eo.PayUserFee + (item.OrderType == 1 ? item.UserFee : 0);
                    eo.PayOwnFee = eo.PayOwnFee + (item.OrderType == 1 ? item.OwnFee : 0);
                    eo.CashUserFee = eo.CashUserFee + (item.OrderType == 2 ? item.UserFee : 0);
                    eo.CashOwnFee = eo.CashOwnFee + (item.OrderType == 2 ? item.OwnFee : 0);
                }
            }
            return srUserDayDict;
        }

        /// <summary>
        /// 统计运营商下用户账户变化currencychange
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task<Dictionary<string, Sr_user_dayPO>> HandleCurrencyChangeDay(Dictionary<string, Sr_user_dayPO> srUserDayDict, OperatorDayContext _context)
        {
            if (null == _context.CurrencyChangeEos || !_context.CurrencyChangeEos.Any()) return srUserDayDict;
            srUserDayDict ??= new();
            //var operatorEo = DbCacheUtil.GetOperator(_context.OperatorId);
            GlobalUserDCache userDCache = null;
            foreach (var item in _context.CurrencyChangeEos)
            {
                if (!srUserDayDict.ContainsKey(item.UserID))
                {
                    try
                    {
                        userDCache = await GlobalUserDCache.Create(item.UserID);
                    }
                    catch (Exception ex)
                    {
                        LogUtil.Error(ex, "sruserday.HandleCurrencyChangeDay中获取GlobalUserDCache缓存异常！");
                    }
                    //var userInfoDict = await userDCache?.GetAsync(new List<string> { "RegistDate", "Mobile" });
                    var sUserDayEo = _context.GetUserDayEo(item.UserID); 
                    var eo = new Sr_user_dayPO
                    {
                        DayID = _context.ReportDate.Date,
                        UserID = item.UserID,
                        UserKind = item.UserKind,
                        OperatorID = item.OperatorID,
                        CountryID =item.CountryID, //operatorEo.CountryID,
                        CurrencyID =item.CurrencyID, //operatorEo.CurrencyID,
                        FromId = item.FromId,
                        FromMode = item.FromMode,
                        IsNew = sUserDayEo?.IsNew ?? false,
                        IsLogin = sUserDayEo?.IsLogin ?? false,
                        LoginDays = sUserDayEo?.LoginDays ?? 0,
                        LastLoginTime = sUserDayEo?.LastLoginTime ?? DateTime.MinValue,
                        IsRegister = sUserDayEo?.IsRegister ?? false,
                        RegistDate = (await userDCache?.GetRegistDateAsync()) ?? DateTime.MinValue,//((DateTime?)userInfoDict?.GetValueOrDefault("RegistDate", new TinyFx.Caching.CacheValue<object>(DateTime.MinValue)).Value) ?? DateTime.MinValue,
                        IsNewBet = sUserDayEo?.IsNewBet ?? false,
                        HasBet = sUserDayEo?.HasBet ?? false,
                        IsNewPay = sUserDayEo?.IsNewPay ?? false,
                        HasPay = sUserDayEo?.HasPay ?? false,
                        IsNewCash = sUserDayEo?.IsNewCash ?? false,
                        HasCash = sUserDayEo?.HasCash ?? false,
                        ChangeCount=1,
                        ChangeAmount=item.Amount,
                        ActivityCount= (item.SourceType>= 100000 && item.SourceType< 200000&& item.Amount>0)? 1:0,
                        ActivityAmount= (item.SourceType >= 100000 && item.SourceType < 200000 && item.Amount > 0)?item.Amount:0,
                        UserIp=sUserDayEo?.UserIp,
                        Mobile= (await userDCache?.GetMobileAsync()) ?? "", //(string)userInfoDict?.GetValueOrDefault("Mobile", new TinyFx.Caching.CacheValue<object>("")).Value
                        Username = (await userDCache?.GetUsernameAsync()) ?? "",
                        Nickname = (await userDCache?.GetNicknameAsync()) ?? ""
                    };
                    srUserDayDict.Add(item.UserID, eo);
                }
                else
                {
                    var eo = srUserDayDict[item.UserID];
                    eo.ChangeCount += 1;
                    eo.ChangeAmount += item.Amount;
                    if (item.SourceType >= 100000 && item.SourceType < 200000&&item.Amount>0)
                    {
                        eo.ActivityCount += 1;
                        eo.ActivityAmount += item.Amount;
                    }
                }
            }
            return srUserDayDict;
        }

        /// <summary>
        /// 统计运营商下用户提现待审cashaudit
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task<Dictionary<string, Sr_user_dayPO>> HandleCashAuditDay(Dictionary<string, Sr_user_dayPO> srUserDayDict, OperatorDayContext _context)
        {
            if (null == _context.CashAuditEos || !_context.CashAuditEos.Any()) return srUserDayDict;
            srUserDayDict ??= new();
            //var operatorEo = DbCacheUtil.GetOperator(_context.OperatorId);
            GlobalUserDCache userDCache = null;
            foreach (var item in _context.CashAuditEos.Where(x=>x.Status==0))
            {
                if (!srUserDayDict.ContainsKey(item.UserID))
                {
                    try
                    {
                        userDCache = await GlobalUserDCache.Create(item.UserID);
                    }
                    catch (Exception ex)
                    {
                        LogUtil.Error(ex, "sruserday.HandleCashAuditDay中获取GlobalUserDCache缓存异常！");
                    }
                    //var userInfoDict = await userDCache?.GetAsync(new List<string> { "RegistDate", "Mobile" });
                    var sUserDayEo = _context.GetUserDayEo(item.UserID);
                    var eo = new Sr_user_dayPO
                    {
                        DayID = _context.ReportDate.Date,
                        UserID = item.UserID,
                        UserKind = item.UserKind,
                        OperatorID = item.OperatorID,
                        CountryID = item.CountryID, //operatorEo.CountryID,
                        CurrencyID =item.CurrencyID, //operatorEo.CurrencyID,
                        FromId = item.FromId,
                        FromMode = item.FromMode,
                        IsNew = sUserDayEo?.IsNew ?? false,
                        IsLogin = sUserDayEo?.IsLogin ?? false,
                        LoginDays = sUserDayEo?.LoginDays ?? 0,
                        LastLoginTime = sUserDayEo?.LastLoginTime ?? DateTime.MinValue ,
                        IsRegister = sUserDayEo?.IsRegister ?? false,
                        RegistDate = (await userDCache?.GetRegistDateAsync()) ?? DateTime.MinValue,//((DateTime?)userInfoDict?.GetValueOrDefault("RegistDate", new TinyFx.Caching.CacheValue<object>(DateTime.MinValue)).Value) ?? DateTime.MinValue,
                        IsNewBet = sUserDayEo?.IsNewBet ?? false,
                        HasBet = sUserDayEo?.HasBet ?? false,
                        IsNewPay = sUserDayEo?.IsNewPay ?? false,
                        HasPay = sUserDayEo?.HasPay ?? false,
                        IsNewCash = sUserDayEo?.IsNewCash ?? false,
                        HasCash = sUserDayEo?.HasCash ?? false,
                        CashAuditAmount=item.Amount,
                        UserIp=sUserDayEo?.UserIp,
                        Mobile= (await userDCache?.GetMobileAsync()) ?? "", //(string)userInfoDict?.GetValueOrDefault("Mobile", new TinyFx.Caching.CacheValue<object>("")).Value
                        Username = (await userDCache?.GetUsernameAsync()) ?? "",
                        Nickname = (await userDCache?.GetNicknameAsync()) ?? ""
                    };
                    srUserDayDict.Add(item.UserID, eo);
                }
                else
                {
                    var eo = srUserDayDict[item.UserID];
                    eo.CashAuditAmount += item.Amount;                   
                }
            }
            return srUserDayDict;
        }


        /// <summary>
        /// 获取运营商指定某天的最大dayId
        /// </summary>
        /// <returns></returns>
        protected override async Task<DateTime?> GetMaxDayId(string operatorId)
        {
            var maxDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_srUserDayMo.TableName} where OperatorID=@OperatorID order by DayID desc limit 1",operatorId);
            return maxDayId;
        }

        protected async override Task<DateTime?> GetMinDayId(string operatorId)
        {
            var minDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_srUserDayMo.TableName} where OperatorID=@OperatorID order by DayID asc limit 1", operatorId);
            return minDayId;
        }
    }
}
