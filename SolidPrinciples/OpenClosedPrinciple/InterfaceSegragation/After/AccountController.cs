using InterfaceSegragation.After;

namespace InterfaceSegragation.After
{
    

    public class AccountController
    {
        private readonly IPasswordCanger manager;

        public AccountController(IPasswordCanger manager)
        {
            this.manager = manager;
        }

        public void ChangePassword(string oldPass, string newPass)
        {
            this.manager.ChangePassword(oldPass, newPass);
        }
    }
}
