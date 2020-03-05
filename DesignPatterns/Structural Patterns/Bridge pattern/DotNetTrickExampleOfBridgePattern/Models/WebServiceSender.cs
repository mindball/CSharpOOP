using DotNetTrickExampleOfBridgePattern.Contracts;
using System;

namespace DotNetTrickExampleOfBridgePattern.Models
{
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web Service\n{0}\n{1}\n", subject, body);
        }
    }
}
