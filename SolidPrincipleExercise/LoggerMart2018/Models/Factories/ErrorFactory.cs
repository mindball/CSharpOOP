using System;
using System.Globalization;
using LoggerMart2018.Models;
using LoggerMart2018.Models.Contracts;

namespace LoggerMart2018.Models.Factories
{
    public class ErrorFactory
    {
        const string DateFormat = "M/d/yyyy h:mm:ss tt";
        public IError CreateError(string dateTimeString,
            string level, string message)
        {
            DateTime dateTime = DateTime.ParseExact(dateTimeString,
                DateFormat,
                CultureInfo.InvariantCulture);
            ErrorLevel errorLevel = ParseErrorLevel(level);
            IError error = new Error(dateTime, errorLevel, message);

            return error;

        }

        private ErrorLevel ParseErrorLevel(string level)
        {
            try
            {
                object levelObj = Enum.Parse(typeof(ErrorLevel), level);

                return (ErrorLevel)levelObj;
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Invalid ErrorLevel Type!!!", e);
            }
        }
    }

   
}
