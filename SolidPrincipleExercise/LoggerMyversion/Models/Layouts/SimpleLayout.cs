
namespace LoggerMyversion.Models.Layouts
{
    using LoggerMyversion.Models.Contracts;
    using System.Globalization;

    public class SimpleLayout : ILayout
    {
        const string FORMAT_MESSAGE = "{0} - {1} - {2}";
        const string DateFormat = "M/d/yyyy h:mm:ss tt";
        public string FormatError(IError error)
        {
            string dateString = error.DateTime.ToString(DateFormat,
                CultureInfo.InvariantCulture);

            return string.Format(FORMAT_MESSAGE,
                dateString,
                error.LevelError.ToString(),
                error.Message);
        }
    }
}
