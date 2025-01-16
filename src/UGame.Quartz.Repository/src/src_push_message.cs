using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Quartz.Repository
{
    ///<summary>
    ///推送消息表
    ///</summary>
    [SugarTable("src_push_message")]
    public partial class Src_push_messagePO
    {
           public Src_push_messagePO(){

            this.SummaryType =0;
            this.ProfitAmount =0;
            this.LossAmount =0;
            this.SumProfit =0;
            this.SumLoss =0;
            this.RegisterUsers =0;
            this.BetUsers =0;
            this.OrderNum =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MessageID {get;set;}

           /// <summary>
           /// Desc:汇总时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime SummaryTime {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:统计类型
			///              1、平台每20分钟净输赢
			///              2、app每20分钟净盈利top
			///              3、app每20分钟净亏损top
			///              4、每20分钟用户净盈利top
			///              5、每20分钟用户净亏损top
			///              6、每20分钟用户充值总额
			///              7、每20分钟用户提现总额
			///              8、平台每小时注册用户数量
			///              9、平台每小时用户下注数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SummaryType {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CountryId {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppID {get;set;}

           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? UserID {get;set;}

           /// <summary>
           /// Desc:净盈利
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ProfitAmount {get;set;}

           /// <summary>
           /// Desc:净亏损
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long LossAmount {get;set;}

           /// <summary>
           /// Desc:总净盈利
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SumProfit {get;set;}

           /// <summary>
           /// Desc:总净亏损
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SumLoss {get;set;}

           /// <summary>
           /// Desc:每小时注册数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RegisterUsers {get;set;}

           /// <summary>
           /// Desc:每小时下注用户数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetUsers {get;set;}

           /// <summary>
           /// Desc:排序，从小到大
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
