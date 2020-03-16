using System;
using System.Collections.Generic;
using CodeProjectObserverExample.Contracts;

namespace CodeProjectObserverExample.Models
{
    public class Subject : ISubject
    {
        private IList<IObserver> observers = new List<IObserver>();
        private string productName;
        private decimal productPrice;
        private bool isAvailable;

        public Subject(string productName, decimal productPrice, bool isAvailable)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.IsAvailability = isAvailable;
        }

        public bool IsAvailability
        {
            get => this.isAvailable;
            private set
            {
                if (value == true)
                {
                    Console.WriteLine("Availability changed from Out of Stock to Available.");
                    this.NotifyObserver();
                    this.isAvailable = true;
                }
                else
                {
                    this.isAvailable = false;
                }
            }
        }

        public void SetAvailability(bool isAvailable)
        {
            this.IsAvailability = isAvailable;
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            Console.WriteLine("Product Name :"
                            + this.productName + ", product Price : "
                            + this.productPrice + " is Now available. So notifying all Registered users ");
            Console.WriteLine();

            foreach (var observer in this.observers)
            {
                observer.Update(this.IsAvailability);
            }
        }
    }
}
