namespace InterfaceSegragation.After
{
    
    using System;
    using System.Collections.Generic;

    public class PasswordChanger : IPasswordCanger
    {
        public void ChangePassword(string oldPass, string newPass)
        {
            // change password
        }
    }
}
