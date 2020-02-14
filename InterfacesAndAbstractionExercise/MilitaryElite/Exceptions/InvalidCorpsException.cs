using System;

namespace MilitaryElite.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        private const string CORP_EXC = "invalid corss";
        public InvalidCorpsException()
            : base(CORP_EXC)
        {

        }

        public InvalidCorpsException(string message) 
            : base(message)
        {
        }
    }
}
