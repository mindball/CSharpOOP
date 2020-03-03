using CoffeExample.Contracts;

namespace CoffeExample.Models
{
    public class FilteredCoffee : ICoffee
    {
        public double Cost()
        {
            return 3.0;
        }

        public string GetDescription()
        {
            return "Filtered coffee";
        }
    }
}
