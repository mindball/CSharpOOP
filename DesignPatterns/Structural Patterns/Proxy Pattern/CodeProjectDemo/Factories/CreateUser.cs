using CodeProjectDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeProjectDemo.Factories
{
    class CreateUser
    {

        public User CreateUserWithCredentialRights(string userName,
            string password, string credentialType)
        {
            User user = null;
            Credentials credential;
            if (Enum.TryParse(credentialType, out credential))
            {
                switch (credential)
                {
                    case Credentials.Guest:
                        user = new User(userName, password, Credentials.Guest);
                        break;
                    case Credentials.OrdinalUser:
                        user = new User(userName, password, Credentials.OrdinalUser);
                        break;
                    case Credentials.SpecialUser:
                        user = new User(userName, password, Credentials.SpecialUser);
                        break;
                    case Credentials.Administrator:
                        user = new User(userName, password, Credentials.Administrator);
                        break;
                    case Credentials.USANsa:
                        user = new User(userName, password, Credentials.USANsa);
                        break;
                }
                return user;
            }
            else
            {
                throw new ArgumentException("No such credentials!!!");
            }


        }
    }
}
