using OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyShoppingChart.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyShoppingChart
{
    class WeightCalculationStrategy : IPriceCalculationStrategy
    {
        public decimal Calculate(OrderItem item)
        {
            return item.Quantity * 4m / 1000;
        }

        public bool isMatch(OrderItem item)
        {
            if(item.Sku.StartsWith("WEIGHT"))
            {
                return true;
            }

            return false;
        }
    }
}
