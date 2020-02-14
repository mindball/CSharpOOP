using OpenClosedPrinciple.Cart.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Cart.Rules
{
    public class SpecialRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            decimal sum = item.Quantity * .4m;
            int setsOfThree = item.Quantity / 3;
            sum -= setsOfThree * .2m;

            return sum;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("SPECIAL");
        }
    }
}
