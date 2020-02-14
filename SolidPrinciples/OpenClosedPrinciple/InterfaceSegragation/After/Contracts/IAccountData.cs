namespace InterfaceSegragation.After
{
    using System.Collections.Generic;

    public interface IAccountData
    {
        IEnumerable<IUser> GetAllUsersOnline();

        IEnumerable<IUser> GetAllUsers();

        IUser GetUserByName(string name);
    }
}
