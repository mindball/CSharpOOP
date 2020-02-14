using System;
using System.Collections.Generic;
using System.Text;

namespace ExersiceEnumAndAttribute
{
    class CardNotDeckException : Exception
    {
        private const string Message = "Card is not in the deck.";

        public CardNotDeckException():
            base(Message)
        {
        }

        public CardNotDeckException(string message) 
            : base(message)
        {
        }
    }
}
