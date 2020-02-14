using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Exceptions
{
    class InvalidStateException : Exception
    {
        private const string STATE_EXC = "invalid state";
        public InvalidStateException()
            : base(STATE_EXC)
        {

        }

        public InvalidStateException(string message) 
            : base(message)
        {

        }
    }
}
