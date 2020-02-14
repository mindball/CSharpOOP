using System;

namespace Telephony.Exceptions
{
    class InvalidURLException : Exception
    {
        private const string IVALID_MESSAGE = "Invalid URL!";
        public InvalidURLException() : 
            base (IVALID_MESSAGE)
        {

        }

        public InvalidURLException(string message)
            : base (message)
        {

        }
    }
}
