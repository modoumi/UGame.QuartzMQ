using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Quartz.Repository
{
    ///<summary>
    ///风控配置表
    ///</summary>
    [SugarTable("src_push_config")]
    public partial class Src_push_configPO
    {
           public Src_push_configPO(){

            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:键Key
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CfgID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

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
           /// Desc:游戏净盈利/净亏损limit
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? GameTop {get;set;}

           /// <summary>
           /// Desc:用户净盈利/净亏损limit
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? UserTop {get;set;}

           /// <summary>
           /// Desc:数据重置时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ResetTime {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
