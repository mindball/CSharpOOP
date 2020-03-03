using CoffeExample.Contracts;

namespace CoffeExample.Models
{
    public class EspressoCoffee : ICoffee
    {
        public double Cost()
        {
            return 2.0;
        }

        public string GetDescription()
        {
            return "Espresso coffee";
        }
    }
}
