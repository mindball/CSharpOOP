using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldCodeExample
{
    /// <summary>
    /// SubSystem ClassA
    /// </summary>
    public class Bank
    {
        private const int minLimitOfAmount = 1000000;
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for: " + c.Name);
            if (amount >= minLimitOfAmount)
                return true;
            else
                return false;
        }
    }
}
