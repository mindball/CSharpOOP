namespace LoggerMart2018.Models.Contracts
{
    public interface ILogger
    {
        void Log(IError error);
    }
}
