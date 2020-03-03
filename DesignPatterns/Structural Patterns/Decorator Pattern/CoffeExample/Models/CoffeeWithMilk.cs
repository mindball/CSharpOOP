using CoffeExample.Contracts;

namespace CoffeExample.Models
{
    public class CoffeeWithMilk : CondimentDecorator
    {
        public CoffeeWithMilk(ICoffee coffee)
            : base(coffee)
        {
            this.coffeType = "milk";
            this.price = 0.5;
        }
    }
}
