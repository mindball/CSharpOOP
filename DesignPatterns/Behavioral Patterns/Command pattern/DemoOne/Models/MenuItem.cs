using System;

namespace DemoOne.Models
{
    public class MenuItem
    {
        public MenuItem(string name, int amount, double price)
        {
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
        }

        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public void Display()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Amount: " + Amount.ToString());
            Console.WriteLine("Price: $" + Price.ToString());
        }
    }
}
