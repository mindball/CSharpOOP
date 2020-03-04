using CoffeExample.Contracts;

namespace CoffeExample.Models
{
    public class CoffeeWithChocolate : CondimentDecorator
    {
        public CoffeeWithChocolate(ICoffee coffee)
            : base(coffee)
        {
            this.coffeType = "chocolate";
            this.price = 1.00;
        }
    }
}
