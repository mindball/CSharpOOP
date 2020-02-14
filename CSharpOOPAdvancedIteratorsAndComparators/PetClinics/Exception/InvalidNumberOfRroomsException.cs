namespace PetClinics.Exception
{
    public class InvalidNumberOfRroomsException : System.Exception
    {
        private const string MESSAGE = "Invalid Operation!";

        public InvalidNumberOfRroomsException()
            : base(MESSAGE)
        {
        }

        public InvalidNumberOfRroomsException(string message)
            : base(message)
        {
        }
    }
}
