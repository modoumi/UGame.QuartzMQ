//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TinyFx.Logging;
//using TinyFx;
//using Xxyy.MQ.Admin;
//using Xxyy.Common.MQ;
//using UGame.Quartz.Service.Caching;
//using Xxyy.Sharding;

//namespace UGame.Quartz.Service.Services.MQConsumers
//{
//    public class CachingChangeMQSub : XxyySubConsumer<CachingChangeMsg>
//    {
//        protected override bool IsBroadcast => true;

//        public CachingChangeMQSub()
//        {
//            RegisterAction(ClearCaching);

//        }

//        private async Task ClearCaching(CachingChangeMsg msg, CancellationToken token)
//        {
//            if (string.IsNullOrEmpty(msg.TableName) || msg.TableName.StartsWith("s_"))
//            {
//                Xxyy.Common.Caching.DbCacheUtil.Clear();
//                //DbCacheUtil.Clear();
//            }
//            if (string.IsNullOrEmpty(msg.TableName)||msg.TableName.StartsWith("sf_",StringComparison.OrdinalIgnoreCase))
//            {
//                DbCacheUtil.Clear();
//            }
//            ShardingUtil.ClearCaching();
//        }
//    }
//}
