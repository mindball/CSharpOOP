namespace InterfaceSegragation.After
{
    using System.Collections.Generic;

    public interface IPasswordCanger
    {
        void ChangePassword(string oldPass, string newPass);
    }
}
