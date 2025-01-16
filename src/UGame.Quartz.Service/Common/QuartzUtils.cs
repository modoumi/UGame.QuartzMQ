using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xxyy.Common;
using Xxyy.DAL;
using UGame.Quartz.Service.Services.LoseCashBack;
using UGame.Quartz.Repository;

namespace UGame.Quartz.Service.Common
{
    public static class QuartzUtils
    {
        private static object _sync = new object();

        private static Dictionary<string, S_operatorEO> _operators;

        private static Dictionary<string, S_countryEO> _countrys;

        /// <summary>
        /// 运营商
        /// </summary>
        private static Dictionary<string, S_operatorEO> Operators
        {
            get
            {
                if (_operators == null)
                {
                    lock (_sync)
                    {
                        if (_operators == null)
                        {
                            Dictionary<string, S_operatorEO> dictionary = new Dictionary<string, S_operatorEO>();
                            foreach (S_operatorEO item in new S_operatorMO().GetAll())
                            {
                                dictionary.Add(item.OperatorID, item);
                            }

                            _operators = dictionary;
                        }
                    }
                }

                return _operators;
            }
        }

        /// <summary>
        /// 国家
        /// </summary>
        private static Dictionary<string, S_countryEO> Countrys
        {
            get
            {
                if (_countrys == null)
                {
                    lock (_sync)
                    {
                        if (_countrys == null)
                        {
                            Dictionary<string, S_countryEO> dictionary = new Dictionary<string, S_countryEO>();
                            foreach (S_countryEO item in new S_countryMO().GetAll())
                            {
                                dictionary.Add(item.CountryID, item);
                            }

                            _countrys = dictionary;
                        }
                    }
                }

                return _countrys;
            }
        }


        public static S_operatorEO GetOperator(string operatorId)
        {
            if (Operators.ContainsKey(operatorId))
            {
                return Operators[operatorId];
            }

            return null;
        }

        public static S_countryEO GetCountry(string countryId)
        {
            if (Countrys.ContainsKey(countryId))
            {
                return Countrys[countryId];
            }

            return null;
        }



        /// <summary>
        /// 获取当前活动是否有效
        /// </summary>
        /// <param name="operatorId">运营商编码</param>
        /// <param name="currencyId">货币编码</param>
        /// <param name="activityType">活动类型</param>
        /// <param name="activityEvent">事件类型</param>
        /// <returns></returns>
        public static async Task<(bool IsValid, ActivityListEventEntity activityEntity)> GetActivityIsOpen(string operatorId, string currencyId, ActivityType activityType, ActivityEvent activityEvent)
        {
            (bool IsValid, ActivityListEventEntity activityEntity) ret = (false, null);

            var sql = $@"select
	                    l_activity_operator.ActivityID,
	                    l_activity_operator.OperatorID,
	                    l_activity_operator.CurrencyID,
	                    l_activity_operator.CountryID,
	                    l_activity_operator.BeginDate,
	                    l_activity_operator.EndDate,
	                    l_activity_operator.OrderNum,
	                    l_activity_operator.`Status`,
	                    l_activity_operator.IsSendNotify,
	                    l_activity_operator.IsSendNotifyEmail,
	                    l_activity_event_operator.ActivityEventId as EventId
                    from l_activity_operator
                    inner join l_activity_event_operator
                    on l_activity_operator.OperatorID = l_activity_event_operator.OperatorID and l_activity_operator.ActivityID = l_activity_event_operator.ActivityID
                    where l_activity_operator.`Status` = 1
                    and l_activity_operator.OperatorID = '{operatorId}'
                    and l_activity_operator.CurrencyID = '{currencyId}'
                    and '{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}' BETWEEN l_activity_operator.BeginDate and l_activity_operator.EndDate
                    and l_activity_event_operator.`Status` = 1
                    order by l_activity_operator.OrderNum";

            var list = await DbSink.MainDb.ExecSqlListAsync<ActivityListEventEntity>(sql);

            if (list == null || !list.Any())
                return ret;

            ret.activityEntity = list.Where(d => d.Status && d.ActivityID == (int)activityType && d.EventId == (int)activityEvent).FirstOrDefault();

            if (ret.activityEntity != null)
                ret.IsValid = true;

            return ret;

        }

        /// <summary>
        /// 获取一条活动配置
        /// </summary>
        /// <param name="operatorId">运营商编码</param>
        /// <param name="currencyId">货币编码</param>
        /// <param name="activityType">活动类型</param>
        /// <returns></returns>
        public static async Task<L_activity_operatorEO> GetActivityOperatorSingleAsync(string operatorId, string currencyId, ActivityType activityType)
        {
            return await new L_activity_operatorMO().GetSingleAsync("OperatorId = @OperatorId and CurrencyId = @CurrencyId and ActivityID = @ActivityID", operatorId, currencyId, (int)activityType);
        }
    }

    public class ActivityListEventEntity
    {
        public int ActivityID { get; set; }
        public string OperatorId { get; set; }
        public string CurrencyId { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int OrderNum { get; set; }
        public bool Status { get; set; }
        public int EventId { get; set; }
        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        public bool IsSendNotify { get; set; }
        /// <summary>
        /// 是否发送站内邮箱通知
        /// </summary>
        public bool IsSendNotifyEmail { get; set; }
    }
}
