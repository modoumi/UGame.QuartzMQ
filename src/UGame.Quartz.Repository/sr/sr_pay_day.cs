using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Quartz.Repository
{
    ///<summary>
    ///支付报表
    ///</summary>
    [SugarTable("sr_pay_day")]
    public partial class Sr_pay_dayPO
    {
           public Sr_pay_dayPO(){


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
           /// Desc:货币类型（货币缩写USD）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:银行ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string BankID {get;set;}

           /// <summary>
           /// Desc:代收总额(充值)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long PayTotal {get;set;}

           /// <summary>
           /// Desc:总单数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? OrderTotalNum {get;set;}

           /// <summary>
           /// Desc:代收成功单数(充值)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PaySuccesOrderNum {get;set;}

           /// <summary>
           /// Desc:支付成功率(成功单数/总订单)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long PaySuccessRate {get;set;}

           /// <summary>
           /// Desc:代收费用(充值手续费)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long PayOwnFee {get;set;}

           /// <summary>
           /// Desc:代收单笔均额(代收总额/代收成功)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long PayAverage {get;set;}

           /// <summary>
           /// Desc:代付总额(提现)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CashTotal {get;set;}

           /// <summary>
           /// Desc:代付成功单数(提现)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CashSuccesOrderNum {get;set;}

           /// <summary>
           /// Desc:代付费用(提现)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CashUserFee {get;set;}

           /// <summary>
           /// Desc:商户库存（充值-提现-手续费）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MerchantInventory {get;set;}

    }
}
