//using EasyNetQ;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TinyFx.BIZ.RabbitMQ;
//using TinyFx.Extensions.RabbitMQ;
//using Xxyy.MQ.Admin;
//using Xxyy.MQ.Quartz;
//using UGame.Quartz.Service.MQMsg;


//namespace UGame.Quartz.Service.Services.MQConsumers
//{

//    public class DataMoveMQSub : MQBizSubConsumer<DataMoveMsg>
//    {
//        public DataMoveMQSub()
//        {
//            AddHandler(Execute);
//        }

//        public override MQSubscribeMode SubscribeMode =>  MQSubscribeMode.OneQueue;

//        protected override void Configuration(ISubscriptionConfiguration config)
//        {
//        }

//        protected override Task OnMessage(DataMoveMsg message, CancellationToken cancellationToken)
//        {
//            return Task.CompletedTask;
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="message"></param>
//        /// <param name="cancellationToken"></param>
//        /// <returns></returns>
//        private async Task Execute(DataMoveMsg message, CancellationToken cancellationToken)
//        {
//            await DataMove.DataMoveUtil.MoveData();
//            await MQUtil.PublishAsync(new CachingChangeMsg());
//        }
//    }
//}
