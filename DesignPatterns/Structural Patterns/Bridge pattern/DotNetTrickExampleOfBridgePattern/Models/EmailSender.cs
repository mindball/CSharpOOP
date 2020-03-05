﻿using DotNetTrickExampleOfBridgePattern.Contracts;
using System;

namespace DotNetTrickExampleOfBridgePattern.Models
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Email\n{0}\n{1}\n", subject, body);
        }
    }
}
