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
using UGame.Quartz.Service.Services.BasicReport;
using EasyNetQ;
using TinyFx.BIZ.RabbitMQ;
using TinyFx.Extensions.RabbitMQ;
using UGame.Quartz.Service.MQMsg;
using UGame.Quartz.Service.Services.SReport.AppProviderJobs;

namespace UGame.Quartz.Service.Services.MQConsumers
{
    public class SRAppProvPerDayMQSub : MQBizSubConsumer<SRAppProvPerDayMsg>
    {
        public override MQSubscribeMode SubscribeMode =>  MQSubscribeMode.OneQueue;

        // private readonly SRDayEngine _engine;
        public SRAppProvPerDayMQSub()
        {
         //   _engine = new SRDayEngine();
            AddHandler(Execute);
        }

        private async Task Execute(SRAppProvPerDayMsg message,CancellationToken cancellationToken)
        {
            //LogUtil.Info("SROperatorPerDayMQSub.{0},收到报表消息！param:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(message));
            try
            {
                await new SrAppProvEngine(message).Execute();

                LogUtil.Info("SRAppProvPerDayMQSub.{0},after engine.execute执行完成！param:{1}", MethodBase.GetCurrentMethod()?.Name, SerializerUtil.SerializeJsonNet(message));
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "SRAppProvPerDayMQSub消费者执行异常！msg:{0}", SerializerUtil.SerializeJsonNet(message));
            }
            
        }

        protected override void Configuration(ISubscriptionConfiguration x)
        {
            x.WithPrefetchCount(2);
            //base.Configuration(x);
        }

        protected override Task OnMessage(SRAppProvPerDayMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
