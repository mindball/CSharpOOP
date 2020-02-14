using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string PHONE_MESSAGE = "Invalid number!";

        public InvalidPhoneNumberException()
            : base(PHONE_MESSAGE)
        {

        }

        public InvalidPhoneNumberException(string message)
            : base (message)
        {

        }
    }
}
