using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Logging;
using TinyFx;
using Xxyy.MQ.Bank;
using Xxyy.MQ.Quartz;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.BIZ.RabbitMQ;
using EasyNetQ;
using UGame.Quartz.Service.Services.BasicReport;

namespace UGame.Quartz.Service.Services.MQConsumers
{
    public class SROperatorPerHourMQSub : MQBizSubConsumer<MQMsg.SROperatorPerHourMsg>
    {
        public SROperatorPerHourMQSub()
        {
            AddHandler(Execute);
        }

        public override MQSubscribeMode SubscribeMode =>  MQSubscribeMode.OneQueue;

        protected override void Configuration(ISubscriptionConfiguration config)
        {
            
        }

        protected override Task OnMessage(MQMsg.SROperatorPerHourMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async Task Execute(MQMsg.SROperatorPerHourMsg message, CancellationToken cancellationToken)
        {
            //LogUtil.Info("SROperatorPerDayMQSub.{0},收到报表消息！param:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(message));
            try
            {
                await new SRHourEngine(message).Execute();

                LogUtil.Info("SROperatorPerHourMQSub.{0},after engine.execute执行完成！param:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(message));
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "SROperatorPerHourMQSub消费者执行异常！msg:{0}", SerializerUtil.SerializeJsonNet(message));
            }

        }
    }
    
}
