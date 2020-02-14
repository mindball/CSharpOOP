using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Exceptions
{
    class InvalidMissionCompleteException : Exception
    {
        private const string MSG_EXP = "";
        public InvalidMissionCompleteException()
            : base(MSG_EXP)
        {
        }

        public InvalidMissionCompleteException(string message) 
            : base(message)
        {
        }
    }
}
