namespace LoggerRAstardzhiev.Views
{
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string FormatReport(string datetime, string reportLevel, string message)
            => $"{datetime} - {reportLevel} - {message}";
    }
}