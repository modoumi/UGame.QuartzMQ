namespace UGame.Quartz.Service.Services.BasicReport
{
    public interface ICalculator
    {
        Task<DayCalculatorDto> Execute();
    }
}
