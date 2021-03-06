﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaName)
        {
            Pizza pizzaType = null;

            if (pizzaName.Contains("Piperoni")) pizzaType = new PeperoniPizza();
            else pizzaType = new CheesePizza();

            return pizzaType;
        }
    }
}
