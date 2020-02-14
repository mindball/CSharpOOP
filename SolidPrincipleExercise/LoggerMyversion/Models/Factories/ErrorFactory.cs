namespace LoggerMyversion.Models.Factories
{
    using LoggerMyversion.Models.Contracts;
    using LoggerMyversion.Models.Enums;
    using System;
    using System.Globalization;

    public class ErrorFactory
    {
        const string DateFormat = "M/d/yyyy h:mm:ss tt";
        public IError CreateError(string message, string dateTimeStr, string levelErrorStr)
        {
            LevelError levelError = this.ParseErrorLevel(levelErrorStr);
            DateTime dateTime = DateTime.ParseExact(dateTimeStr, DateFormat, CultureInfo.InvariantCulture);
            IError error = new Error(message, dateTime, levelError);

            return error;
        }

        private LevelError ParseErrorLevel(string level)
        {
            try
            {
                object levelObj = Enum.Parse(typeof(LevelError), level);

                return (LevelError)levelObj;
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Invalid LevelError Type!!!", e);
            }
        }
    }
}
