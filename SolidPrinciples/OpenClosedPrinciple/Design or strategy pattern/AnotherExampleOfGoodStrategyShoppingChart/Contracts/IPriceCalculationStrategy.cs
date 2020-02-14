using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyShoppingChart.Contracts
{
    public interface IPriceCalculationStrategy
    {
        decimal Calculate(OrderItem item);

        bool isMatch(OrderItem item);
    }
}
