using System;
using System.Collections.Generic;
using System.Text;

namespace MuOnline.Utilities.Exception
{
    public class ItemValidationException : System.Exception
    {
        private const string baseMessage = " cannot be less than zero";
        public ItemValidationException(string message)
            : base(message + baseMessage)
        {
        }
    }
}
