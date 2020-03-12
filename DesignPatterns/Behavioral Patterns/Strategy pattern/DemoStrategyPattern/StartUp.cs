using DemoStrategyPattern.Contracts;
using DemoStrategyPattern.Models;
using System;
using System.Collections.Generic;

namespace DemoStrategyPattern
{
    class StartUp
    {
        private static Dictionary<int, int> priceOnProducts = new Dictionary<int, int>();
        private static Order order = new Order();
        private static IPayStrategy strategy;
        
        static void Main(string[] args)
        {
            priceOnProducts.Add(1, 2200);
            priceOnProducts.Add(2, 1800);
            priceOnProducts.Add(3, 200);
            priceOnProducts.Add(4, 7200);

            while (!order.IsClosed())
            {
                int cost = 0;
                string continueChoice;
                do
                {
                    Console.Write("Please, select a product:" + "\n" +
                            "1 - Mother board" + "\n" +
                            "2 - CPU" + "\n" +
                            "3 - HDD" + "\n" +
                            "4 - Memory" + "\n");

                    int choice = int.Parse(Console.ReadLine());
                    cost = priceOnProducts[choice];
                    Console.Write("Count: ");
                    int count = int.Parse(Console.ReadLine());
                    order.SetTotalCost(cost * count);
                    Console.WriteLine("Do you wish to continue selecting products? Y/N: ");
                    continueChoice = Console.ReadLine();
                } while (continueChoice.ToUpper().Equals("Y"));

                if(strategy is null)
                {
                    Console.Write("Please, select a payment method:" + "\n" +
                        "1 - PalPay" + "\n" +
                        "2 - Credit Card");

                    string paymentMethod = Console.ReadLine();
                    // Client creates different strategies based on input from user,
                    // application configuration, etc.
                    if (paymentMethod.Equals("1"))
                    {
                        strategy = new PayByPayPal();
                    }
                    else
                    {
                        strategy = new PayByCreditCard();
                    }

                    // Order object delegates gathering payment data to strategy
                    // object, since only strategies know what data they need to
                    // process a payment.
                    order.ProcessOrder(strategy);

                    Console.Write("Pay " + order.GetTotalCost() + " units or Continue shopping? P/C: ");
                    String proceed = Console.ReadLine();
                    if (proceed.ToUpper().Equals("P"))
                    {
                        // Finally, strategy handles the payment.
                        if (strategy.Pay(order.GetTotalCost()))
                        {
                            Console.WriteLine("Payment has been successful.");
                        }
                        else
                        {
                            Console.WriteLine("FAIL! Please, check your data.");
                        }

                        order.SetClosed();
                    }
                }
            }            
        }
    }
}
