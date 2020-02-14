using OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyShoppingChart.Contracts;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyShoppingChart
{
    class SpecialCalculationStrategy : IPriceCalculationStrategy
    {
        public decimal Calculate(OrderItem item)
        {
            decimal total = item.Quantity * 0.4m;
            int setsOfThree = item.Quantity / 3;
            total -= setsOfThree * 0.2m;

            return total;
        }

        public bool isMatch(OrderItem item)
        {
            if (item.Sku.StartsWith("SPECIAL"))
            {
                return true;
            }

            return false;
        }
    }
}
