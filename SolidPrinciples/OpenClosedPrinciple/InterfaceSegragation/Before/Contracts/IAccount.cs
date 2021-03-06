﻿namespace InterfaceSegragation.Before
{
    using System.Collections.Generic;

    public interface IAccount
    {
        bool RequireUniqueEmail { get; }

        int MinRequiredPasswordLength { get; }

        int MaxRequiredPasswordLength { get; }

        void Register(string username, string password);

        void Login(string username, string password);

        void ChangePassword(string oldPass, string newPass);

        IEnumerable<IUser> GetAllUsersOnline();

        IEnumerable<IUser> GetAllUsers();

        IUser GetUserByName(string name);
    }
}
