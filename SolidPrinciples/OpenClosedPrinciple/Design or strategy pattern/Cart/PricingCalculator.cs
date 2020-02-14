using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OpenClosedPrinciple.Cart
{
    using OpenClosedPrinciple.Cart.Contracts;
    using OpenClosedPrinciple.Cart.Rules;

    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> pricingRules;

        public PricingCalculator()
        {
            this.pricingRules = new List<IPriceRule>()
            {
                new BuyFourGetOneFree(),
                new EachPriceRule(),
                new PerGramPriceRule(),
                new SpecialRule()
            };

        }
        public decimal CalculatePrice(OrderItem item)
        {
            return this.pricingRules
                .First(x => x.IsMatch(item))
                .CalculatePrice(item);
        }
    }
}
