using DependencyInversion.LiveDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.LiveDemo
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine("Sending emails");
        }
    }
}
