using TinyFx.Logging;
using Xxyy.Common;

namespace UGame.Quartz.Service.Services.SReport.AppProviderJobs
{
    public abstract class AppProvJobBase
    {

        public abstract Task Execute(AppProvDayContext context);
        protected abstract Task<DateTime?> GetMaxDayId();
        protected abstract Task<DateTime?> GetMinDayId();
        public virtual async Task<(DateTime startDate, DateTime endDate)> CalcStartEndDate(DateTime? startDate, DateTime? endDate)
        {
            try
            {
                var yesterDate = DateTime.UtcNow.AddDays(-1).Date;
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
                    var minDayId = await GetMinDayId();
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
                    var maxDayId = await GetMaxDayId();
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
                LogUtil.Error(ex, $"计算job：{GetType().Name}开始和结束日期异常！");
            }
            return (DateTime.MinValue, DateTime.MinValue);
        }
    }
}
