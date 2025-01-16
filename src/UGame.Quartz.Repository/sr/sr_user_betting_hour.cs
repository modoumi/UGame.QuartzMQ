using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Quartz.Repository
{
    ///<summary>
    ///时段下注人数统计
    ///</summary>
    [SugarTable("sr_user_betting_hour")]
    public partial class Sr_user_betting_hourPO
    {
           public Sr_user_betting_hourPO(){


           }
           /// <summary>
           /// Desc:统计日期小时
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public DateTime DayId {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:下注人数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UserCount {get;set;}

    }
}
