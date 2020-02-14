using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.LiveDemo.Contracts
{
    public interface IEmailSender
    {
        void SendEmail(string email, string message);
    }
}
