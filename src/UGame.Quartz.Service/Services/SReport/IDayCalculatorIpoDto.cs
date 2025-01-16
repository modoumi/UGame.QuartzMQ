using TinyFx.Extensions.AutoMapper;
using UGame.Quartz.Repository;
using S_currency_changeEO = UGame.Quartz.Repository.S_currency_changeEO;

namespace UGame.Quartz.Service.Services.BasicReport
{
    public interface IDayCalculatorIpo
    {
        /// <summary>
        /// 指定日期
        /// </summary>
        DateTime ReportDate { get; set; }

        /// <summary>
        /// 运营商编号
        /// </summary>
        string OperatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string GroupKey { get; set; }

        /// <summary>
        /// frommode 0-运营商  1-用户   2-channel
        /// </summary>
        int FromMode { get; set; }

        /// <summary>
        /// 当日新增的所有用户数
        /// </summary>
        List<Repository.S_user_dayEO> UserDayEos { get; set; }

        /// <summary>
        /// 当日新增的所有下注订单数
        /// </summary>
        List<Xxyy.DAL.S_provider_orderEO> ProviderOrderEos { get; set; }

        /// <summary>
        /// 当日新增的所有currencyChange数
        /// </summary>
        List<S_currency_changeEO> CurrencyChangeEos { get; set; }

        /// <summary>
        /// 当日新增的所有bankorder数
        /// </summary>
        List<Sb_bank_orderEO> BankOrderEos { get; set; }

        /// <summary>
        /// 流水需求订单
        /// </summary>
        List<Xxyy.DAL.S_requireflow_orderEO> RequireFlowOrderEos { get; set; }

        /// <summary>
        /// 提现待审记录
        /// </summary>
        List<Sc_cash_auditEO> CashAuditEos { get; set; }
        Repository.S_user_dayEO GetUserDayEo(string userId);

    }

    public class DayCalculatorDto : IMapTo<Sr_oper_dayEO>, IMapTo<Sr_channel_dayEO>
    {
        /// <summary>
        /// 当日用户总账户存量
        /// </summary>
        public long TotalBalance { get; set; }
        /// <summary>
        /// 下注额
        /// </summary>
        public long BetAmount { get; set; }

        /// <summary>
        /// 下注时扣除的bonus
        /// </summary>
        public long BetBonus { get; set; }

        /// <summary>
        /// 返奖时增加的bonus
        /// </summary>
        public long WinBonus { get; set; }

        /// <summary>
        /// 新用户下注的bonus
        /// </summary>
        public long NewUserBetBonus { get; set; }

        /// <summary>
        /// 新用户返奖bonus
        /// </summary>
        public long NewUserWinBonus { get; set; }

        /// <summary>
        /// 下注用户数
        /// </summary>
        public int BetUsers { get; set; }

        /// <summary>
        /// 提款金额
        /// </summary>
        public long CashAmount { get; set; }

        /// <summary>
        /// bonus领取人数
        /// </summary>
        public int BonusRecUsers { get; set; }

        /// <summary>
        /// bonus发放总量
        /// </summary>
        public long BonusAmount { get; set; }

        /// <summary>
        /// bonus消耗总量
        /// </summary>
        public long BonusUseAmount => this.BetBonus - this.WinBonus;

        /// <summary>
        /// bonus存量
        /// </summary>
        public long BonusRemainAmount { get; set; }

        /// <summary>
        /// bonus解锁量
        /// </summary>
        public long BonusUnlockAmount { get; set; }

        public Dictionary<int,long> ActivityDict { get; set; }

        ///// <summary>
        ///// bonus首充发放数量
        ///// </summary>
        //public long BonusFirstPayAmount { get; set; }

        ///// <summary>
        ///// bonus签到发放数量
        ///// </summary>
        //public long BonusSignAmount { get; set; }

        ///// <summary>
        ///// bonus输返发放数量
        ///// </summary>
        //public long BonusLossRebateAmount { get; set; }

        /// <summary>
        /// 提审现金额度
        /// </summary>
        public long CashAuditAmount { get; set; }

        /// <summary>
        /// 拒审现金额度
        /// </summary>
        public long CashRefuseAmount { get; set; }

        /// <summary>
        /// 通过成功现金额度
        /// </summary>
        public long CashPassAmount { get; set; }

        /// <summary>
        /// 失败额度
        /// </summary>
        public long CashFailAmount { get; set; }

        /// <summary>
        /// 提款我方手续费
        /// </summary>
        public decimal CashOwnFee { get; set; }

        /// <summary>
        /// 提款用户手续费
        /// </summary>
        public decimal CashUserFee { get; set; }

        /// <summary>
        /// 当日提款用户数
        /// </summary>
        public int CashUsers { get; set; }
        public string CountryID { get; set; }
        public string CurrencyID { get; set; }
        public DateTime DayID { get; set; }

        /// <summary>
        /// 当日注册用户首充金额
        /// </summary>
        public long DNU_FirstPayAmount { get; set; }

        /// <summary>
        /// 当日注册用户复充用户数
        /// </summary>
        public int DNU_RepayUsers { get; set; }

        /// <summary>
        /// 老用户首充金额(历史从未充值过)
        /// </summary>
        public long DOU_FirstPayAmount { get; set; }

        /// <summary>
        /// 首充老用户的累计金额(历史从未充值过)
        /// </summary>
        public long DOU_FirstPayTotalAmount { get; set; }

        /// <summary>
        /// 老用户当日首充（历史未有充值）人数
        /// </summary>
        public int DOU_FirstPayUsers { get; set; }


        /// <summary>
        /// 当日登录用户数
        /// </summary>
        public int LoginUsers { get; set; }

        /// <summary>
        /// 当日注册用户下注人数
        /// </summary>
        public int NewBetUsers { get; set; }

        /// <summary>
        /// 当日注册用户提现人数
        /// </summary>
        public int NewCashUsers { get; set; }

        /// <summary>
        /// 当天注册的账号充值的用户数
        /// </summary>
        public int NewPayUsers { get; set; }

        /// <summary>
        /// 当天注册的用户下注的金额
        /// </summary>
        public long NewUserBetAmount { get; set; }

        /// <summary>
        /// 当天注册的用户提现的金额
        /// </summary>
        public long NewUserCashAmount { get; set; }

        /// <summary>
        /// 当天注册的用户充值的金额
        /// </summary>
        public long NewUserPayAmount { get; set; }

        /// <summary>
        /// 当日新增用户数
        /// </summary>
        public int NewUsers { get; set; }

        /// <summary>
        /// 充值用户数
        /// </summary>
        public int PayUsers { get; set; }

        /// <summary>
        /// 当天注册的用户返奖的金额
        /// </summary>
        public long NewUserWinAmount { get; set; }
        public string OperatorID { get; set; }

        /// <summary>
        /// 充值金额
        /// </summary>
        public long PayAmount { get; set; }

        /// <summary>
        /// 返奖额
        /// </summary>
        public long WinAmount { get; set; }

        /// <summary>
        /// 充值未下注用户数
        /// </summary>
        public int PayNotBetUsers { get; set; }

        /// <summary>
        /// 充值我方手续费
        /// </summary>
        public decimal PayOwnFee { get; set; }

        /// <summary>
        /// 充值用户手续费
        /// </summary>
        public decimal PayUserFee { get; set; }

        public long ProfitAmount { get; set; }

        public float ARUP { get; set; }
        public long PromotionFeeAmount { get; set; }
        public DateTime RecDate { get; set; }
        public float RegRetentionD1 { get; set; }
        public float RegRetentionD15 { get; set; }
        public float RegRetentionD3 { get; set; }
        public float RegRetentionD30 { get; set; }
        public float RegRetentionD7 { get; set; }
        public int RegUsers { get; set; }
        public int RepeatConsumersD10 { get; set; }
        public int RepeatConsumersD15 { get; set; }
        public int RepeatConsumersD5 { get; set; }
        public int RepeatConsumersD1 { get; set; }
        public float RetentionD1 { get; set; }
        public float RetentionD14 { get; set; }
        public float RetentionD15 { get; set; }
        public float RetentionD20 { get; set; }
        public float RetentionD3 { get; set; }
        public float RetentionD30 { get; set; }
        public float RetentionD7 { get; set; }
        public float PayRetentionD1 { get; set; }
        public float PayRetentionD2 { get; set; }
        public float PayRetentionD3 { get; set; }
        public float PayRetentionD4 { get; set; }
        public float PayRetentionD5 { get; set; }
        public float PayRetentionD6 { get; set; }
        public float PayRetentionD7 { get; set; }
        public float PayRetentionD14 { get; set; }
        public float PayRetentionD20 { get; set; }
        public float PayRetentionD30 { get; set; }

        public float BetD1 { get; set; }
        public long DNU_GGR1 { get; set; }
        public long DNU_GGR2 { get; set; }
        public long DNU_GGR3 { get; set; }
        public long DNU_GGR4 { get; set; }
        public long DNU_GGR5 { get; set; }
        public long DNU_GGR6 { get; set; }
        public long DNU_GGR7 { get; set; }
        public long DNU_GGR8 { get; set; }
        public long DNU_GGR9 { get; set; }
        public long DNU_GGR10 { get; set; }
        public long DNU_GGR11 { get; set; }
        public long DNU_GGR12 { get; set; }
        public long DNU_GGR13 { get; set; }
        public long DNU_GGR14 { get; set; }
        public long DNU_GGR15 { get; set; }
        public long DNU_GGR16 { get; set; }
        public long DNU_GGR17 { get; set; }
        public long DNU_GGR18 { get; set; }
        public long DNU_GGR19 { get; set; }
        public long DNU_GGR20 { get; set; }
        public long DNU_GGR21 { get; set; }
        public long DNU_GGR22 { get; set; }
        public long DNU_GGR23 { get; set; }
        public long DNU_GGR24 { get; set; }
        public long DNU_GGR25 { get; set; }
        public long DNU_GGR26 { get; set; }
        public long DNU_GGR27 { get; set; }
        public long DNU_GGR28 { get; set; }
        public long DNU_GGR29 { get; set; }
        public long DNU_GGR30 { get; set; }

        public int Win10 { get; set; }
        public int Win10_100 { get; set; }
        public int Win100_500 { get; set; }
        public int Win1000_3000 { get; set; }
        public int Win10000_50000 { get; set; }
        public int Win3000_5000 { get; set; }
        public int Win500_1000 { get; set; }
        public int Win5000_10000 { get; set; }
        public int Win50000 { get; set; }
        public int Lose10 { get; set; }
        public int Lose10_100 { get; set; }
        public int Lose100_500 { get; set; }
        public int Lose1000_3000 { get; set; }
        public int Lose10000_50000 { get; set; }
        public int Lose3000_5000 { get; set; }
        public int Lose500_1000 { get; set; }
        public int Lose5000_10000 { get; set; }
        public int Lose50000 { get; set; }
        public float NewARUP { get; set; }



        public void MapTo(Sr_oper_dayEO destination)
        {

        }

        public void MapTo(Sr_channel_dayEO destination)
        {
            
        }
    }
}
