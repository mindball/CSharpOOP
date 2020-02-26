using CodeprojectExample.Contracts;
using System;

namespace CodeprojectExample.Models
{
    public class CostManager : ICosting
    {
        public float ApplyDiscounts(float price, float discountPercent)
        {
            Console.WriteLine(string.Format("A discount of {0}% has been applied on the product's price of {1}"
                , discountPercent, price));
            return price - ((discountPercent / 100) * price);
        }
    }
}
