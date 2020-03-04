using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CoffeExample.Contracts;
using CoffeExample.Models;


namespace TestCoffee
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void ShouldSupportCondiments()
        {
            var beverages = new List<ICoffee>
            {
                new ChocolateCoffee(new FilteredCoffee()),
                new ChocolateCoffee(new CoffeeWithMilk(new EspressoCoffee()))
            };

            var filteredWithChocolate = beverages.First();
            Assert.AreEqual("Filtered coffee, chocolate",
                filteredWithChocolate.GetDescription());

            Assert.AreEqual(1.00 + 3.00, filteredWithChocolate.Cost());

            var espressoWithMilkAndChocolate = beverages.Skip(1).First();
            Assert.AreEqual("Espresso coffee, milk, chocolate",
                    espressoWithMilkAndChocolate.GetDescription());
            Assert.AreEqual(1.00 + 0.50 + 2.00, espressoWithMilkAndChocolate.Cost());


        }
    }
}
