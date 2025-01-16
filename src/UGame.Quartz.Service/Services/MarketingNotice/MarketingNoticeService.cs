using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.RabbitMQ;
using Xxyy.Common;
using Xxyy.DAL;
using Xxyy.MQ.Email;

namespace UGame.Quartz.Service.Services.MarketingNotice
{
    public class MarketingNoticeService
    {
        public async Task NotifyDeposit(List<string> operatorIds)
        {
            foreach (var operatorId in operatorIds)
            {
                var today = DateTime.UtcNow.ToLocalTime(operatorId).Date;
                var beginDate = today.AddDays(-2);
                var endDate = today.AddDays(-1);
                var userIds = await DbUtil.GetRepository<S_userPO>().AsQueryable()
                    .Where(f => f.OperatorID == operatorId && !f.HasPay && f.UserMode == 2
                        && (f.RegistDate ?? f.RecDate) >= beginDate && (f.RegistDate ?? f.RecDate) < endDate)
                    .Select(f => f.UserID)
                    .ToListAsync();
                if (userIds == null || userIds.Count == 0) return;

                var templateId = "Register24HoursNoDepositNotice";
                foreach (var userId in userIds)
                {
                    //注册24小时后，没有充值将发一封营销短信
                    await MQUtil.PublishAsync(new UserEmailMsg
                    {
                        UserId = userId,
                        AppId = "lobby",
                        BeginDateUtc = DateTime.UtcNow,
                        EndDateUtc = DateTime.UtcNow.AddDays(8),
                        OperatorId = operatorId,
                        TemplateId = templateId,
                        TemplateKey = templateId,
                        DisplayTag = 0,
                        SenderId = "system"
                    });
                }
            }
        }
    }
}
