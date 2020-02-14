using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine();

            while(true)
            {
                string input = Console.ReadLine();
                if (input.Equals("End"))
                    break;

                string[] inputArg = input.Split();
                if(inputArg.Length == 1)
                {
                    string coin = inputArg[0];
                    machine.InsertCoin(coin);                
                }
                else
                {
                    string coffeeQuantity = inputArg[0];
                    string coffeeType = inputArg[1];
                    machine.BuyCoffee(coffeeQuantity, coffeeType);
                }
            }

            foreach (var soldCoffee in machine.CoffeesSold)
            {
                Console.WriteLine(soldCoffee);
            }
        }
    }
}
