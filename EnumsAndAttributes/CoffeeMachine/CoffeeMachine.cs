using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class CoffeeMachine
    {
        private int totalCoin;
        private IList<CoffeeType> coffeesSold;
        public CoffeeMachine()
        {
            this.coffeesSold = new List<CoffeeType>();
        }
        public IEnumerable<CoffeeType> CoffeesSold => this.coffeesSold;

        public void BuyCoffee(string quantity, string type)
        {
            int coffeePrice = (int)Enum.Parse(typeof(CoffeePrice), quantity);

            if (coffeePrice <= this.totalCoin)
            {
                CoffeeType typeOfCoffee = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
                coffeesSold.Add(typeOfCoffee);

                this.totalCoin = 0;
            }
            else
                return;
        }
        public void InsertCoin(string coin)
        {
            this.totalCoin += (int)Enum.Parse(typeof(Coin), coin);
        }

    }
}
