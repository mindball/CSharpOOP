using CodeprojectExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeprojectExample.Models
{
    public class LogisticsManager : ILogistics
    {
        public void ShipProduct(string productName, string shippingAddress)
        {
            Console.WriteLine(string.Format("Congratulations your product {0} has been shipped "
                + "at the following address: {1}", productName, shippingAddress));
        }
    }
}
