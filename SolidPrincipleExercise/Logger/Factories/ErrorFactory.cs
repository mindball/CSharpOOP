using System;
using System.Globalization;

using Logger.Exceptions;
using Logger.Models.Contracts;
using Logger.Models.Enumeration;
using Logger.Models.Errors;

namespace Logger.Factories
{
    public class ErrorFactory
    {
        private const string formatDateTime = @"M/dd/yyyy h:mm:ss tt";
        public IError GetError(string dateString, string levelString, 
            string message)
        {
            Level level;
            bool hasParsed = Enum.TryParse<Level>(levelString, out level);            
            if(!hasParsed)
            {
                throw new InvalidLevelTypeException();
            }

            DateTime dateTime;
            try
            {
                dateTime = DateTime.ParseExact(dateString,
                    formatDateTime, CultureInfo.InvariantCulture);
            }
            catch(Exception e)
            {
                throw new InvalidDateTimeFormatException();
            }
            
            return new Error(dateTime, message, level);
        }
    }
}
