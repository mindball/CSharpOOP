using System;
using System.Collections.Generic;
using System.Text;

namespace ExersiceEnumAndAttribute
{
    class CardExistsException : Exception
    {
        private const string MESSAGE = "No such card exists.";
        public CardExistsException() :
            base(MESSAGE)
        {
        }

        public CardExistsException(string message) :
           base(message)
        {
        }
    }
}
