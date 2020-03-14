using ExceptionNotFoundExample.Models;
using System;

namespace ExceptionNotFoundExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Carrots carrots = new Carrots(0.82m);
            carrots.Attach(new HappyRestaurantVarna("Golden sands", 0.77m));
            carrots.Attach(new HappyRestaurantVarna("Johnny's Sports Bar", 0.74m));
            carrots.Attach(new HappyRestaurantVarna("Salad Kingdom", 0.75m));

            // Fluctuating carrot prices will notify subscribing restaurants.
            carrots.PricePerPound = 0.79m;
            carrots.PricePerPound = 0.76m;
            carrots.PricePerPound = 0.74m;
            carrots.PricePerPound = 0.81m;

            Console.ReadKey();
        }
    }
}
