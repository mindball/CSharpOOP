namespace MuOnline.Utilities.Exception
{
    class MonsterValidationException : System.Exception
    {
        private const string baseMessage = " cannot be less than zero";
        public MonsterValidationException(string message)
            : base(message + baseMessage)
        {
        }
    }
}
