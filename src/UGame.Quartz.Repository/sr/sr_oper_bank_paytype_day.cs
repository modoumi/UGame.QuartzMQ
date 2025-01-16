using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Quartz.Repository
{
    ///<summary>
    ///银行支付方式每日统计
    ///</summary>
    [SugarTable("sr_oper_bank_paytype_day")]
    public partial class Sr_oper_bank_paytype_dayPO
    {
           public Sr_oper_bank_paytype_dayPO(){

            this.PaytypeID =0;
            this.PayUsers =0;
            this.CashUsers =0;
            this.PayOwnFee =0.00m;
            this.PayUserFee =0.00m;
            this.PayAmount =0;
            this.CashAmount =0;
            this.CashOwnFee =0.00m;
            this.CashUserFee =0.00m;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:统计日
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public DateTime DayID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:银行编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string BankID {get;set;}

           /// <summary>
           /// Desc:支付方式0-综合1-visa2-spei
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int PaytypeID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CountryID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyID {get;set;}

           /// <summary>
           /// Desc:充值用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int PayUsers {get;set;}

           /// <summary>
           /// Desc:提现用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CashUsers {get;set;}

           /// <summary>
           /// Desc:充值我方手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal PayOwnFee {get;set;}

           /// <summary>
           /// Desc:充值用户手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal PayUserFee {get;set;}

           /// <summary>
           /// Desc:充值数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PayAmount {get;set;}

           /// <summary>
           /// Desc:提现数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashAmount {get;set;}

           /// <summary>
           /// Desc:提现我方手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal CashOwnFee {get;set;}

           /// <summary>
           /// Desc:提现用户手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal CashUserFee {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
