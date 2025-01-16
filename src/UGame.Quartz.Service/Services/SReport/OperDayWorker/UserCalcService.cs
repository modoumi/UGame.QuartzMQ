using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Data;
using UGame.Quartz.Service.Services.BasicReport;
using Xxyy.Common;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Services.SReport.OperDayWorker
{
    internal class UserCalcService
    {
        public UserCalcService() { }


        /// <summary>
        /// 获取cash和bonus
        /// </summary>
        /// <returns></returns>
        public async Task<(long cash,long bonus,DateTime tatalBalanceCalcTime)> GetTotalBalance(OperatorDayContext context)
        {
           var userMoList= DbSink.GetUserMoList();
            long totalCash = 0;
            long totalBonus = 0;
            var channelsql = $" and FromMode={context.FromMode} and FromId='{context.GroupKey}'";
            foreach (var userMo in userMoList)
            {
               var sql = $"select sum(cash) as cash,sum(bonus) as bonus from {userMo.TableName} where OperatorID='{context.OperatorId}' and UserKind=1 and status=1 {(context.GroupKey==context.OperatorId?"":channelsql)}";
                var tb= await DbSink.MainDb.ExecSqlTableAsync(sql);
                totalCash += tb.Rows[0].ToInt64N(0)??0;
                totalBonus += tb.Rows[0].ToInt64N(1)??0;
            }
            return (totalCash,totalBonus,DateTime.UtcNow);
        }

    }
}
