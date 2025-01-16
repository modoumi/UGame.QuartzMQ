/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-06-16 14: 59:50
 ******************************************************/
using System.Data;

namespace UGame.Quartz.Repository
{
    public interface ISr_oper_dayEO
    {
        float ARUP { get; set; }
        long BetAmount { get; set; }
        int BetUsers { get; set; }
        long CashAmount { get; set; }
        decimal CashOwnFee { get; set; }
        decimal CashUserFee { get; set; }
        int CashUsers { get; set; }
        string CountryID { get; set; }
        string CurrencyID { get; set; }
        DateTime DayID { get; set; }
        long DNU_FirstPayAmount { get; set; }
        int DNU_RepayUsers { get; set; }
        long DOU_FirstPayAmount { get; set; }
        int DOU_FirstPayUsers { get; set; }
        bool HasOriginal { get; }
        int LoginUsers { get; set; }
        int Lose10 { get; set; }
        int Lose10_100 { get; set; }
        int Lose100_500 { get; set; }
        int Lose1000_3000 { get; set; }
        int Lose10000_50000 { get; set; }
        int Lose3000_5000 { get; set; }
        int Lose500_1000 { get; set; }
        int Lose5000_10000 { get; set; }
        int Lose50000 { get; set; }
        float NewARUP { get; set; }
        int NewBetUsers { get; set; }
        int NewCashUsers { get; set; }
        int NewPayUsers { get; set; }
        long NewUserBetAmount { get; set; }
        long NewUserCashAmount { get; set; }
        long NewUserPayAmount { get; set; }
        int NewUsers { get; set; }
        long NewUserWinAmount { get; set; }
        string OperatorID { get; set; }
        DateTime OriginalDayID { get; set; }
        string OriginalOperatorID { get; set; }
        long PayAmount { get; set; }
        int PayNotBetUsers { get; set; }
        decimal PayOwnFee { get; set; }
        decimal PayUserFee { get; set; }
        int PayUsers { get; set; }
        long ProfitAmount { get; set; }
        long PromotionFeeAmount { get; set; }
        DateTime RecDate { get; set; }
        float RegRetentionD1 { get; set; }
        float RegRetentionD15 { get; set; }
        float RegRetentionD3 { get; set; }
        float RegRetentionD30 { get; set; }
        float RegRetentionD7 { get; set; }
        int RegUsers { get; set; }
        int RepeatConsumersD10 { get; set; }
        int RepeatConsumersD15 { get; set; }
        int RepeatConsumersD5 { get; set; }
        float RetentionD1 { get; set; }
        float RetentionD14 { get; set; }
        float RetentionD15 { get; set; }
        float RetentionD20 { get; set; }
        float RetentionD3 { get; set; }
        float RetentionD30 { get; set; }
        float RetentionD7 { get; set; }
        int Win10 { get; set; }
        int Win10_100 { get; set; }
        int Win100_500 { get; set; }
        int Win1000_3000 { get; set; }
        int Win10000_50000 { get; set; }
        int Win3000_5000 { get; set; }
        int Win500_1000 { get; set; }
        int Win5000_10000 { get; set; }
        int Win50000 { get; set; }
        long WinAmount { get; set; }

        Dictionary<string, object> GetPrimaryKeys();
        string GetPrimaryKeysJson();
        Sr_oper_dayEO MapRow(IDataReader reader);
    }
}