using System;
using System.Collections.Generic;
using System.Text;
using ExceptionNotFoundExample.Contracts;

namespace ExceptionNotFoundExample.Models
{
    public abstract class Veggies
    {
        private decimal pricePerPound;
        private List<IRestaurant> restaurants = new List<IRestaurant>();

        public Veggies(decimal pricePerPoung)
        {
            this.pricePerPound = pricePerPoung;
        }

        public decimal PricePerPound
        {
            get => this.pricePerPound;
            set
            {
                if (this.pricePerPound != value)
                {
                    this.pricePerPound = value;
                    this.Notify(); //Automatically notify our observers of price changes
                }
            }
        }

        public void Attach(IRestaurant restaurant)
        {
            this.restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            this.restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (var restaurant in this.restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine("");
        }
    }
}
