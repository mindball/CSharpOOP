using System.Globalization;
using LoggerMart2018.Models.Contracts;

namespace LoggerMart2018.Models
{
    class SimpleLayout : ILayout
    {
        //format "<date-time> - <report level> - <message>"
        const string Format = "{0} - {1} - {2}";
        //3/31/2015 5:33:07 PM
        const string DateFormat = "M/d/yyyy h:mm:ss tt";
        public string FormatError(IError error)
        {
            string dateString = error.DateTime.ToString(DateFormat, 
                CultureInfo.InvariantCulture);
            string formattedError = string.Format(Format,
                dateString,
                error.Level.ToString(),
                error.Message);

            return formattedError;
        }
    }
}
