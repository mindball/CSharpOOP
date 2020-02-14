using System;

namespace Logger.Exceptions
{
    class InvalidLevelTypeException : Exception
    {
        private const string MESSAGE = "Invalid Level Type";
        public InvalidLevelTypeException()
            : base(MESSAGE)
        {
        }

        public InvalidLevelTypeException(string message) 
            : base(message)
        {
        }
    }
}
