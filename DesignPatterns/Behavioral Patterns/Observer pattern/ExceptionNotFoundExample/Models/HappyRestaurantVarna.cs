using ExceptionNotFoundExample.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionNotFoundExample.Models
{
    public class HappyRestaurantVarna : IRestaurant
    {
        private string name;       
        private decimal purchaseThreshold;

        public HappyRestaurantVarna(string name, decimal purchaseThreshold)
        {
            this.name = name;
            this.purchaseThreshold = purchaseThreshold;
        }
        public void Update(Veggies veggie)
        {
            Console.WriteLine($"Notified {this.name} of {veggie.GetType().Name}'s " +
                $" price change to {veggie.PricePerPound} per pound.");

            if(veggie.PricePerPound < this.purchaseThreshold)
            {
                Console.WriteLine(this.name + " wants to buy some " + veggie.GetType().Name + "!");
            }
        }
    }
}
