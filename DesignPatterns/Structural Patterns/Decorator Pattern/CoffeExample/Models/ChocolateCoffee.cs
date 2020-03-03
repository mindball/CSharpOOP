using CoffeExample.Contracts;

namespace CoffeExample.Models
{
    public class ChocolateCoffee : CondimentDecorator
    {
        public ChocolateCoffee(ICoffee coffee)
            : base(coffee)
        {
            this.coffeType = "chocolate";
            this.price = 1.00;
        }
    }
}
