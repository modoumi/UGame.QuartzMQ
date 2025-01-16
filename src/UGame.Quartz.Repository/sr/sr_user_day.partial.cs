using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace UGame.Quartz.Repository
{
    public partial class Sr_user_dayPO
    {
        #region tinyfx
        public static implicit operator Sr_user_dayEO(Sr_user_dayPO value)
        {
            if (value==null) return null;
            return new Sr_user_dayEO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        IsNew = value.IsNew,
		        IsLogin = value.IsLogin,
		        LoginDays = value.LoginDays,
		        LastLoginTime = value.LastLoginTime,
		        IsRegister = value.IsRegister,
		        RegistDate = value.RegistDate,
		        IsNewBet = value.IsNewBet,
		        HasBet = value.HasBet,
		        IsNewPay = value.IsNewPay,
		        HasPay = value.HasPay,
		        IsNewCash = value.IsNewCash,
		        HasCash = value.HasCash,
		        BetCount = value.BetCount,
		        BetAmount = value.BetAmount,
		        BetBonus = value.BetBonus,
		        WinCount = value.WinCount,
		        WinAmount = value.WinAmount,
		        WinBonus = value.WinBonus,
		        PayCount = value.PayCount,
		        PayAmount = value.PayAmount,
		        CashCount = value.CashCount,
		        CashAmount = value.CashAmount,
		        ActivityCount = value.ActivityCount,
		        ActivityAmount = value.ActivityAmount,
		        ChangeCount = value.ChangeCount,
		        ChangeAmount = value.ChangeAmount,
		        CashAuditAmount = value.CashAuditAmount,
		        PayUserFee = value.PayUserFee,
		        PayOwnFee = value.PayOwnFee,
		        CashUserFee = value.CashUserFee,
		        CashOwnFee = value.CashOwnFee,
		        EndBalance = value.EndBalance,
		        EndBonus = value.EndBonus,
		        RecDate = value.RecDate,
		        UserIp = value.UserIp,
		        Mobile = value.Mobile,
		        Username = value.Username,
		        Nickname = value.Nickname,
            };
        }
        public static implicit operator Sr_user_dayPO(Sr_user_dayEO value)
        {
            if (value==null) return null;
            return new Sr_user_dayPO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        IsNew = value.IsNew,
		        IsLogin = value.IsLogin,
		        LoginDays = value.LoginDays,
		        LastLoginTime = value.LastLoginTime,
		        IsRegister = value.IsRegister,
		        RegistDate = value.RegistDate,
		        IsNewBet = value.IsNewBet,
		        HasBet = value.HasBet,
		        IsNewPay = value.IsNewPay,
		        HasPay = value.HasPay,
		        IsNewCash = value.IsNewCash,
		        HasCash = value.HasCash,
		        BetCount = value.BetCount,
		        BetAmount = value.BetAmount,
		        BetBonus = value.BetBonus,
		        WinCount = value.WinCount,
		        WinAmount = value.WinAmount,
		        WinBonus = value.WinBonus,
		        PayCount = value.PayCount,
		        PayAmount = value.PayAmount,
		        CashCount = value.CashCount,
		        CashAmount = value.CashAmount,
		        ActivityCount = value.ActivityCount,
		        ActivityAmount = value.ActivityAmount,
		        ChangeCount = value.ChangeCount,
		        ChangeAmount = value.ChangeAmount,
		        CashAuditAmount = value.CashAuditAmount,
		        PayUserFee = value.PayUserFee,
		        PayOwnFee = value.PayOwnFee,
		        CashUserFee = value.CashUserFee,
		        CashOwnFee = value.CashOwnFee,
		        EndBalance = value.EndBalance,
		        EndBonus = value.EndBonus,
		        RecDate = value.RecDate,
		        UserIp = value.UserIp,
		        Mobile = value.Mobile,
		        Username = value.Username,
		        Nickname = value.Nickname,
            };
        }
        #endregion
    }
}