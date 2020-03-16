using CodeProjectObserverExample.Contracts;
using System;

namespace CodeProjectObserverExample.Models
{
    public class Observer : IObserver
    {
        public Observer(string userName, ISubject subject)
        {
            this.UserName = userName;
            subject.RegisterObserver(this);
        }
        public string UserName { get; set; }

        public void Update(bool isAvailability)
        {
            string resultOfAvailable = isAvailability ? "available" : "not available";

            Console.WriteLine($"Hello {this.UserName}, Product is now " 
                + $"{resultOfAvailable} on Amazon");                
        }
    }
}
