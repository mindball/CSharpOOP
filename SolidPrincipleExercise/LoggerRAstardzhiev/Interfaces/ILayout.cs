namespace LoggerRAstardzhiev.Interfaces
{
    public interface ILayout
    {
        string FormatReport(string datetime, string reportLevel, string message);
    }
}