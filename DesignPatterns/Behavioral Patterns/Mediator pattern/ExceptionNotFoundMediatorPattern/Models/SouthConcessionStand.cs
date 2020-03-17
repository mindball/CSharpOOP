using ExceptionNotFoundMediatorPattern.Contracts;
using System;

namespace ExceptionNotFoundMediatorPattern.Models
{
    public class SouthConcessionStand : ConcessionStand
    {
        public SouthConcessionStand(IMediator mediator) 
            : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine("South Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("South Concession Stand gets message: " + message);
        }
    }
}
