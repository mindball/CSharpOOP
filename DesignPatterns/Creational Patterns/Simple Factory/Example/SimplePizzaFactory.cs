using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(string pizzaName)
        {
            IPizza pizzaType = null;

            if (pizzaName.Contains("Piperoni")) pizzaType = new PeperoniPizza();
            else pizzaType = new CheesePizza();

            return pizzaType;
        }
    }
}
