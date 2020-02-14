using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Exceptions
{
    public class InvalidDateTimeFormatException : Exception
    {
        private const string MESSAGE = "Invalid DateTime format!";
        public InvalidDateTimeFormatException()
            : base(MESSAGE)
        {
        }

        public InvalidDateTimeFormatException(string message) : base(message)
        {
        }

        public InvalidDateTimeFormatException(string message, Exception innerException) 
            : base(MESSAGE, innerException)
        {
        }
    }
}
