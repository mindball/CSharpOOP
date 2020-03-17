using DotnetLeadRealExample.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetLeadRealExample.Models
{
    public class ConcreteColleague<T> : IColleague<T>
    {
        private string name;
        public ConcreteColleague(string name)
        {
            this.name = name;
        }
        public void ReceiveMessage(T message)
        {
            Console.WriteLine(this.name + " received " + message.ToString());
        }

        public void SendMessage(IMediator<T> mediator, T message)
        {
            mediator.DistributeMessage(this, message);
        }
    }
}
