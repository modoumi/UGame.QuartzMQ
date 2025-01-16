using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Quartz.Repository
{
    ///<summary>
    ///按照app统计下注金额
    ///</summary>
    [SugarTable("sr_app_day")]
    public partial class Sr_app_dayPO
    {
           public Sr_app_dayPO(){

            this.BetUsers =0;
            this.BetCount =0;
            this.BetAmount =0;
            this.BetBonus =0;
            this.WinCount =0;
            this.WinAmount =0;
            this.WinBonus =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:统计日
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public DateTime DayId {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string AppID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CountryID {get;set;}

           /// <summary>
           /// Desc:应用提供商
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ProviderID {get;set;}

           /// <summary>
           /// Desc:货币类型（仅现金，其它另行统计）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:下注用户数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BetUsers {get;set;}

           /// <summary>
           /// Desc:下注次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BetCount {get;set;}

           /// <summary>
           /// Desc:当天用户下注额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetAmount {get;set;}

           /// <summary>
           /// Desc:当天用户bonus下注
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetBonus {get;set;}

           /// <summary>
           /// Desc:返奖次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int WinCount {get;set;}

           /// <summary>
           /// Desc:当天用户返奖额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinAmount {get;set;}

           /// <summary>
           /// Desc:当天用户bonus返奖
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinBonus {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
