using DemoObserver.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoObserver.Models
{
    public class EmailNotificationListener : IEventListener
    {
        private string email;

        public EmailNotificationListener(string email)
        {
            this.email = email;
        }
        public void Update(string eventType, FileStream file)
        {
            Console.WriteLine("Email to " + email +
                ": Someone has performed " + eventType +
                " operation with the following file: " + file.Name);
        }
    }
}
