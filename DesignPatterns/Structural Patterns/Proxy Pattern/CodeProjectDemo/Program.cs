using CodeProjectDemo.Factories;
using CodeProjectDemo.Models;
using System;

namespace CodeProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "guest";
            string password = "1234567";
            string credentials = "Guest";

            User user = CreateUserFactori(userName, password, credentials);
            FolderProxy proxy = new FolderProxy(user);
            Console.WriteLine("When username, passwords and credential are correct perform operation");
            proxy.PerformOperations();

            Console.WriteLine();

            string userTwoName = "chieftain";
            string passwordTwo = "asdasds(!&@$(^!*)$^*()!&$^*(!^$*(!^";
            string credentialsTwo = "USANsa";
            user = CreateUserFactori(userTwoName, passwordTwo, credentialsTwo);
            proxy = new FolderProxy(user);
            Console.WriteLine("When username, passwords and credential are correct perform operation");
            proxy.PerformOperations();
        }

        private static User CreateUserFactori(string userName, string password, string credentials)
        {
            CreateUser factory = new CreateUser();
            return factory.CreateUserWithCredentialRights(
                userName, password, credentials);
        }
    }
}
