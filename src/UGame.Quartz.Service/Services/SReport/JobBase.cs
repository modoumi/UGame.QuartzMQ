using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Logging;
using UGame.Quartz.Service.Services.BasicReport;
using Xxyy.Common;

namespace UGame.Quartz.Service.Services.SReport
{
    public abstract class JobBase
    {
        //public abstract Task<(DateTime startDate, DateTime endDate)> CalcStartEndDate(DateTime? startDate, DateTime? endDate, string operatorId);
       
        public abstract Task Execute(OperatorDayContext context);
        protected abstract Task<DateTime?> GetMaxDayId(string operatorId);
        protected abstract Task<DateTime?> GetMinDayId(string operatorId);
        public virtual async Task<(DateTime startDate, DateTime endDate)> CalcStartEndDate(DateTime? startDate, DateTime? endDate, string operatorId)
        {
            try
            {
                var yesterDate = DateTime.UtcNow.ToLocalTime(operatorId).AddDays(-1).Date;
                var startDateIsNotNull = startDate != null && startDate.Value != DateTime.MinValue;
                var endDateIsNotNull = endDate != null && endDate.Value != DateTime.MinValue;
                if (startDateIsNotNull || endDateIsNotNull)
                {
                    if (startDateIsNotNull && endDateIsNotNull)
                    {
                        if (startDate.Value > endDate.Value)
                            throw new Exception($"参数错误，startDate:{startDate.Value}不能大于endDate:{endDate.Value}");
                        return (startDate.Value, endDate.Value);
                    }
                    if (startDateIsNotNull)
                    {
                        if (startDate.Value > yesterDate)
                            throw new Exception($"startDate:{startDate.Value}不能大于yesterdate:{yesterDate}");
                        return (startDate.Value, yesterDate);
                    }
                        
                    //startDate is null
                    var minDayId = await GetMinDayId(operatorId);
                    if (null == minDayId || minDayId.Value == DateTime.MinValue)
                        return (endDate.Value, endDate.Value);

                    //
                    if (minDayId.Value < endDate.Value)
                        return (minDayId.Value, endDate.Value);
                    else
                        return (endDate.Value, endDate.Value);
                }
                else
                {
                    var maxDayId = await GetMaxDayId(operatorId);
                    if (null == maxDayId || maxDayId.Value == DateTime.MinValue)
                    {
                        return (yesterDate, yesterDate);
                    }
                    var nextDate = maxDayId.Value.AddDays(1);
                    if (nextDate > yesterDate)
                        throw new Exception($"日期异常!nextDate:{nextDate}不能大于yesterDate:{yesterDate}");
                    return (nextDate, yesterDate);
                }
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex,$"计算job：{this.GetType().Name}开始和结束日期异常！");
            }
            return (DateTime.MinValue,DateTime.MinValue);
        }
    }
}
