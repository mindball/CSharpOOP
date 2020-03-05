using DotNetTrickExampleOfBridgePattern.Contracts;
using System;

namespace DotNetTrickExampleOfBridgePattern.Models
{
    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("MSMQ\n{0}\n{1}\n", subject, body);
        }
    }
}
