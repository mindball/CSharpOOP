namespace PetClinics.Exception
{
    public class InvalidAgeException : System.Exception
    {
        private const string MESSAGE = "Invalid Operation!";

        public InvalidAgeException()
            : base(MESSAGE)
        {
        }

        public InvalidAgeException(string message)
            : base(message)
        {
        }
    }
}
