using CodeprojectExample.Contracts;
using CodeprojectExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeprojectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the Order/Product details
            OrderDetails orderDetails = 
                new OrderDetails("C# Design Pattern Book",
               "Simplified book on design patterns in C#", 500, 10,
                "Street No 1", "Educational Area", 1212, "4156213754");

            // Using Facade
            OnlineShoppingFacade facade = new OnlineShoppingFacade();
            facade.FinalizeOrder(orderDetails);
        }
    }
}
