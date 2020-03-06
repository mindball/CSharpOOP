using System;
using System.Collections.Generic;
using System.Text;

namespace ChainPatternSoftUniExample
{
    internal class Purchase
    {
        public Purchase(int number, double amount)
        {
            this.Number = number;
            this.Amount = amount;
        }

        public int Number { get; }
        public double Amount { get; }
    }
}
