using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.Quartz.Repository
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sr_channel_sourcetype_day")]
    public partial class Sr_channel_sourcetype_dayPO
    {
           public Sr_channel_sourcetype_dayPO(){

            this.SourceType =0;
            this.Bonus =0;

           }
           /// <summary>
           /// Desc:统计日
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public DateTime DayID {get;set;}

           /// <summary>
           /// Desc:推广渠道编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ChannelID {get;set;}

           /// <summary>
           /// Desc:业务类型（统计维度）0-未知10000X-运营活动2-提现审批3xxx后台
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int SourceType {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:bonus数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Bonus {get;set;}

    }
}
