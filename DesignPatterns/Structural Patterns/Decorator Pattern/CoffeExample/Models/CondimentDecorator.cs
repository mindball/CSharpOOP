using CoffeExample.Contracts;

namespace CoffeExample.Models
{
    public abstract class CondimentDecorator : ICoffee
    {
        private ICoffee coffee;
        protected string coffeType = "undefined";
        protected double price = 0.0;

        public CondimentDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public double Cost()
        {
            return this.coffee.Cost() + this.price;
        }

        public string GetDescription()
        {
            return string.Format("{0}, {1}", this.coffee.GetDescription(), this.coffeType);
        }
    }
}
