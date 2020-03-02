using CodeProjectDemo.Factories;
using CodeProjectDemo.Models;
using System;

namespace CodeProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "AccountingAccount";
            string password = "123456";
            string credentials = "USANsa";

            User user = CreateUserFactori(userName, password, credentials);
            FolderProxy proxy = new FolderProxy(user);
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
