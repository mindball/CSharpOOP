using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ShoppingSpree
{
    static void Main()
    {

    }

    internal class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = Name;
            this.Money = money;
        }

        public string Name { get; private set; }
        public decimal  Money { get; private set; }
    }

    internal class Product
    {
        public Product(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}

