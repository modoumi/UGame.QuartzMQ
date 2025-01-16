using UGame.Quartz.Service.Commands.Base;

namespace UGame.Quartz.Service.Commands;

public class RebateWaterNotifyCommand : RewardNotifyCommandBase
{
    public RebateWaterNotifyCommand() : base()
    { 
        RewardSourceTable = "sa_rebate_user_detail"; 
    }
}
