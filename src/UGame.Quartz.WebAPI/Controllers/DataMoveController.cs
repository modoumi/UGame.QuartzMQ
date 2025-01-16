using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TinyFx.BIZ.DataSplit;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.RabbitMQ;
using Xxyy.MQ.Quartz;
using UGame.Quartz.Service;
using UGame.Quartz.Service.MQMsg;
using Xxyy.Quartz.DAL;

namespace UGame.Quartz.WebAPI.Controllers
{
    public class DataMoveController : QuartzControllerBase
    {

        ///// <summary>
        ///// 执行数据迁移备份
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //[AllowAnonymous]
        //public async Task Execute()
        //{
        //    await MQUtil.PublishAsync(new DataMoveMsg());
        //    //DataMoveUtil.Execute();
        //    //return Task.CompletedTask;
        //}

        /// <summary>
        /// 执行数据迁移备份
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task ExecuteV2()
        {
           var list= DbUtil.GetRepository<S_split_tablePO>().AsQueryable().Where(c => c.Status == 1).OrderBy(c => c.HandleOrder).ToList();
            foreach (var item in list)
            {
                await MQUtil.PublishAsync(new DataMoveMsgV2() { DatabaseId=item.DatabaseId,TableName=item.TableName});
            }
        }



        /// <summary>
        /// 执行数据迁移备份
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task ExecuteV2Test()
        {
            var list = DbUtil.GetRepository<TinyFx.BIZ.DataSplit.DAL.S_split_tablePO>().AsQueryable().Where(c => c.DatabaseId== "default" && c.TableName== "s_provider_order").OrderBy(c => c.HandleOrder).ToList();
            await new DataSplitJob().Execute(list);
        }
    }
}
