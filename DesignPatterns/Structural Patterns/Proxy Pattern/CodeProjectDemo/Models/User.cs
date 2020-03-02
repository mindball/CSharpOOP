namespace CodeProjectDemo.Models
{
    public class User
    {
        private string userName;
        private string passwords;

        public User(string userName, string password, Credentials credential)
        {
            this.UserName = userName;
            this.Passwords = password;
            this.Credential = credential;
        }

        public string UserName { get => userName; private set => userName = value; }
        public string Passwords { get => passwords; private set => passwords = value; }
        public Credentials Credential { get; }
    }
}
