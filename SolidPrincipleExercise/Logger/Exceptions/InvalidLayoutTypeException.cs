using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Exceptions
{
    public class InvalidLayoutTypeException : Exception
    {
        private const string MESSAGE = "Invalid Layout Exception";
        public InvalidLayoutTypeException()
            : base(MESSAGE)
        {
        }

        public InvalidLayoutTypeException(string message) 
            : base(message)
        {
        }
    }
}
