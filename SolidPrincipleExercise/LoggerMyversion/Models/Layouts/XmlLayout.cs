

namespace LoggerMyversion.Models.Layouts
{
    using System.Globalization;
    using System.Text;
    using LoggerMyversion.Models.Contracts;

    class XmlLayout : ILayout
    {
        const string DateFormat = "M/d/yyyy h:mm:ss tt";
        private string[] XMLtags = new string[]
        {
            "log", "date", "level", "message"
        };

        public string FormatError(IError error)
        {
            StringBuilder formatStringToXml = new StringBuilder();

            string dateString = error.DateTime.ToString(DateFormat,
                CultureInfo.InvariantCulture);
            string levelError = error.LevelError.ToString();

            formatStringToXml.AppendLine($"<{XMLtags[0]}>").
                AppendLine($"\t<{XMLtags[1]}>{dateString}</{XMLtags[1]}>").
                    AppendLine($"\t<{XMLtags[2]}>{error.LevelError.ToString()}</{XMLtags[2]}>").
                    AppendLine($"\t<{XMLtags[3]}>{error.Message}</{XMLtags[3]}>").
                AppendLine($"</{XMLtags[0]}>");

            return formatStringToXml.ToString().TrimEnd();
        }
    }
}
