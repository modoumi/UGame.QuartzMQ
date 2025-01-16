using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.BIZ.DataSplit;
using TinyFx.BIZ.DataSplit.DAL;
using TinyFx.BIZ.RabbitMQ;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.RabbitMQ;
using Xxyy.MQ.Admin;
using Xxyy.MQ.Quartz;
using UGame.Quartz.Service.MQMsg;


namespace UGame.Quartz.Service.Services.MQConsumers
{

    public class DataMoveMQSubV2 : MQBizSubConsumer<DataMoveMsgV2>
    {
        public DataMoveMQSubV2()
        {
            AddHandler(Execute);
        }

        public override MQSubscribeMode SubscribeMode =>  MQSubscribeMode.OneQueue;

        protected override void Configuration(ISubscriptionConfiguration config)
        {
            config.WithPrefetchCount(1);
        }

        protected override Task OnMessage(DataMoveMsgV2 message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        private async Task Execute(DataMoveMsgV2 message, CancellationToken cancellationToken)
        {
            var list = DbUtil.GetRepository<S_split_tablePO>().AsQueryable().Where(a => a.DatabaseId == message.DatabaseId && a.TableName == message.TableName).ToList();
            await new DataSplitJob().Execute(list);
            await MQUtil.PublishAsync(new CachingChangeMsg());
        }
    }
}
