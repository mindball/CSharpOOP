using System;

namespace FactoryMethodExample
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
            PizzaFactory pizzaFactory = new PizzaFactory();
            IPizza pizzaType = pizzaFactory.CreatePizza(pizzaName);

            pizzaType.Prepare();
            Console.WriteLine($"Price of {pizzaType}: someSum");
        }
    }
}
