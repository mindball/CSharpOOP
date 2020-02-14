using System;

namespace Logger.Exceptions
{
    public class InvalidAppenderTypeException : Exception
    {
        private const string MESSAGE = "Invalid Appender type!";

        public InvalidAppenderTypeException()
            :base(MESSAGE)
        {
        }

        public InvalidAppenderTypeException(string message) 
            : base(message)
        {
        }
    }
}
