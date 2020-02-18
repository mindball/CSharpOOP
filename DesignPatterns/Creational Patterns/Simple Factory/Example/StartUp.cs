using System;

namespace Example
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string orderPizza = "Piperoni";
            OrderPizza(orderPizza);
        }

        private static void OrderPizza(string pizzaName)
        {
            SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();
            IPizza pizzaType = pizzaFactory.CreatePizza(pizzaName);

            pizzaType.Prepare();
            Console.WriteLine($"Price of {pizzaType}: someSum");
        }
    }
}
