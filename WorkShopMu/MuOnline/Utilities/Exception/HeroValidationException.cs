using System;
using System.Collections.Generic;
using System.Text;

namespace MuOnline.Utilities.Exception
{
    class HeroValidationException : System.Exception
    {
        private const string baseMessage = " cannot be less than zero";
        public HeroValidationException(string message)
            : base(message + baseMessage)
        {
        }
    }
}
