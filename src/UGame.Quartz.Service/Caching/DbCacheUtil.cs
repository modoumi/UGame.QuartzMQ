using EasyNetQ.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.DbCaching;
using TinyFx.Logging;
using TinyFx.Reflection;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Caching
{
    public static class DbCacheUtil
    {
        private static object objlock = new object();
        private static readonly S_channelMO _channelMo = new();
        private static readonly L_activity_baseMO _lActivityBaseMo = new();


        //private static Dictionary<string, List<S_channelEO>> _channels;

        //public static Dictionary<string, List<S_channelEO>> GetChannels()
        //{
        //    if(_channels == null)
        //    {
        //        lock(objlock)
        //        {
        //            if(_channels == null)
        //            {
        //                var dict=new Dictionary<string,List<S_channelEO>>();
        //                foreach (var item in _channelMo.GetAll())
        //                {
        //                    if (string.IsNullOrWhiteSpace(item.OperatorID)) continue;
        //                    if (!dict.ContainsKey(item.OperatorID))
        //                        dict.Add(item.OperatorID, new List<S_channelEO> { item });
        //                    else
        //                        dict[item.OperatorID].Add(item);
        //                }
        //                _channels = dict;
        //            }
        //        }
        //    }
        //    return _channels;
        //}

        //private static Dictionary<string, Sf_promoter_configEO> _promoterConfigDict;

        ///// <summary>
        ///// 获取运营商推广配置字典key:OperatorID,value:sc_promoter_configEo
        ///// </summary>
        ///// <returns></returns>
        //public static Dictionary<string, Sf_promoter_configEO> PromoterConfigDict() => _promoterConfigDict ??= new Sf_promoter_configMO().GetAll().ToDictionary(x=>x.OperatorID);

        public static Sf_promoter_configPO GetPromoterConfig(string operatorId)
        {
            return DbCachingUtil.GetSingle<Sf_promoter_configPO>(operatorId);
        }


        //private static Dictionary<string, List<Sf_promoter_comm_configEO>> _promoterCommConfigDict;

        ///// <summary>
        ///// 获取佣金等级配置字典key:OperatorID|PromoterType|PLevel,value:sc_promoter_comm_configEo
        ///// </summary>
        ///// <returns></returns>
        //public static Dictionary<string, List<Sf_promoter_comm_configEO>> PromoterCommConfigDict() => _promoterCommConfigDict ??= new Sf_promoter_comm_configMO().GetAll().GroupBy(x=>x.OperatorID).ToDictionary(x=>x.Key,gr=>gr.ToList());

        /// <summary>
        /// 根据业绩和OperatorId获取佣金配置Eo
        /// </summary>
        /// <param name="perf"></param>
        /// <param name="promoterType"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static Sf_promoter_comm_configPO GetPromoterCommConfig(long perf,int promoterType,string operatorId)
        {
            //var promoterConfigDict = PromoterConfigDict();
            //if (!promoterConfigDict.ContainsKey(operatorId))
            //    throw new Exception($"该运营商下{operatorId}的佣金基础配置为空!");
            var promoterConfig = DbCachingUtil.GetSingle<Sf_promoter_configPO>(operatorId);
            if (null==promoterConfig)
                throw new Exception($"该运营商下{operatorId}的佣金基础配置为空!");

            var promoterCommConfigs = DbCachingUtil.GetList<Sf_promoter_comm_configPO>(it =>it.OperatorID,operatorId);
            if (null== promoterCommConfigs|| promoterCommConfigs.Count==0)
            {
                LogUtil.Warning($"该运营商下operatorId:{operatorId}的佣金等级配置为空!");
                return new Sf_promoter_comm_configPO { 
                      CommLevel = 0,
                      Comm=0,
                      MinCashPerf=0,
                      MinAmountPerf=0,
                      OperatorID = operatorId,
                      PromoterType = promoterType
                };
                //throw new Exception($"该运营商下{operatorId}的佣金等级配置为空!");
            }

            //var promoterCommConfigDict = PromoterCommConfigDict();
            //if(!promoterCommConfigDict.ContainsKey(operatorId))
            //{
            //    throw new Exception($"该运营商下{operatorId}的佣金等级配置为空!");
            //}
            Sf_promoter_comm_configEO promoterCommConfig = null;
            if (promoterConfig.HasBonusPerf)
            {
                foreach (var item in promoterCommConfigs.Where(x=> x.PromoterType == promoterType).OrderBy(x => x.MinAmountPerf))
                {
                    if (perf >= item.MinAmountPerf)
                    {
                        promoterCommConfig = item;
                        continue;
                    }
                    break;
                }
            }
            else
            {
                foreach (var item in promoterCommConfigs.Where(x => x.PromoterType == promoterType).OrderBy(x => x.MinCashPerf))
                {
                    if (perf >= item.MinCashPerf)
                    {
                        promoterCommConfig = item;
                        continue;
                    }
                    break;
                }
            }
            return promoterCommConfig;
        }



        //private static Dictionary<string, List<Sf_promoter_vipEO>> _promoterVipDict;

        ///// <summary>
        ///// 获取用户累计流水等级配置字典
        ///// </summary>
        ///// <returns></returns>
        //private static Dictionary<string, List<Sf_promoter_vipEO>> PromoterVipDict() => _promoterVipDict ??= new Sf_promoter_vipMO().GetAll().GroupBy(x=>x.OperatorID).ToDictionary(x=>x.Key,v=>v.ToList());

        /// <summary>
        /// 根据业绩和OperatorId获取等级配置Eo
        /// </summary>
        /// <param name="perf"></param>
        /// <param name="promoterType"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static Sf_promoter_vipEO GetPromoterVipConfig(long perf,string operatorId)
        {
            //var promoterConfigDict = PromoterConfigDict();
            //if (!promoterConfigDict.ContainsKey(operatorId))
            //    throw new Exception($"该运营商下{operatorId}的佣金基础配置为空!");
            var promoterConfig = DbCachingUtil.GetSingle<Sf_promoter_configPO>(operatorId);
            if (null==promoterConfig)
                throw new Exception($"该运营商下{operatorId}的佣金基础配置为空!");

            //var promoterVipConfigDict = PromoterVipDict();
            //if (!promoterVipConfigDict.ContainsKey(operatorId))
            //{
            //    throw new Exception($"该运营商下{operatorId}的业绩等级配置为空!");
            //}
            var promoterVipConfigs = DbCachingUtil.GetList<Sf_promoter_vipPO>(it =>it.OperatorID,operatorId);
            if (promoterVipConfigs==null|| promoterVipConfigs.Count==0)
            {
                LogUtil.Warning($"该运营商下operatorId:{operatorId}的业绩等级配置为空!");
                return new Sf_promoter_vipEO {
                 OperatorID = operatorId,
                 NeedPerf = perf,
                 PLevel = 0
                };
                //throw new Exception($"该运营商下{operatorId}的业绩等级配置为空!");
            }
            Sf_promoter_vipEO promoterVipConfig = null;
           
            foreach (var item in promoterVipConfigs.OrderBy(x => x.NeedPerf))
            {
                if (perf >= item.NeedPerf)
                {
                    promoterVipConfig = item;
                    continue;
                }
                break;
            }
            return promoterVipConfig;
        }



        //private static Dictionary<string, L_activity_baseEO> _lActivityBaseDict = null;
        //public static Dictionary<string, L_activity_baseEO> GetLActivityBaseDict() => _lActivityBaseDict??= _lActivityBaseMo.GetAll().ToDictionary(x => x.ActivityID.ToString());

        //public static void Clear()
        //{
            //_channels= null;
            //_lActivityBaseDict = null;
            //_promoterConfigDict= null;
            //_promoterCommConfigDict = null;
            //_promoterVipDict = null;
        //}
    }
}
