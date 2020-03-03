using CoffeExample.Contracts;
using CoffeExample.Models;
using System;

namespace CoffeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee espressoCoffee = new EspressoCoffee();
            Console.WriteLine($"Order: {espressoCoffee.GetDescription()}, " +
                $"price calculating: {espressoCoffee.Cost()}");

            ICoffee filteredCoffee = new FilteredCoffee();
            Console.WriteLine($"Order: {filteredCoffee.GetDescription()}, " +
                $"price calculating: {filteredCoffee.Cost()}");

            Console.WriteLine("-------------------------");
            Console.WriteLine("--------Condiment--------");

            ICoffee filteredCoffeeWithMilk = new CoffeeWithMilk(new FilteredCoffee());
            Console.WriteLine($"Order: {filteredCoffeeWithMilk.GetDescription()}, " +
                $"price calculating: {filteredCoffeeWithMilk.Cost()}");

            ICoffee espressoCoffeeWithMilk = new CoffeeWithMilk(new EspressoCoffee());
            Console.WriteLine($"Order: {espressoCoffeeWithMilk.GetDescription()}, " +
                $"price calculating: {espressoCoffeeWithMilk.Cost()}");

            ICoffee filteredCoffeeWithChocolate = new ChocolateCoffee(new FilteredCoffee());
            Console.WriteLine($"Order: {filteredCoffeeWithChocolate.GetDescription()}, " +
                $"price calculating: {filteredCoffeeWithChocolate.Cost()}");

            ICoffee espressoCoffeeWithChocolate = new ChocolateCoffee(new EspressoCoffee());
            Console.WriteLine($"Order: {espressoCoffeeWithChocolate.GetDescription()}, " +
                $"price calculating: {espressoCoffeeWithChocolate.Cost()}");

            Console.WriteLine("-------------------------");
            Console.WriteLine("--------Condiment--------");

            ICoffee espressoCoffeeWithChocolateAndMilk = 
                new ChocolateCoffee(new CoffeeWithMilk(new EspressoCoffee()));
            Console.WriteLine($"Order: {espressoCoffeeWithChocolateAndMilk.GetDescription()}, " +
                $"price calculating: {espressoCoffeeWithChocolateAndMilk.Cost()}");

            ICoffee filteredCoffeeWithChocolateAndMilk =
               new ChocolateCoffee(new CoffeeWithMilk(new FilteredCoffee()));
            Console.WriteLine($"Order: {filteredCoffeeWithChocolateAndMilk.GetDescription()}, " +
                $"price calculating: {filteredCoffeeWithChocolateAndMilk.Cost()}");
        }
    }
}
