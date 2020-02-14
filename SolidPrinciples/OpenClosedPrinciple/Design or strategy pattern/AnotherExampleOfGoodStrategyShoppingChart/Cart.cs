using System;
using System.Collections.Generic;
using System.Text;
using OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyShoppingChart.Contracts;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyShoppingChart
{
    public class Cart
    {
        private readonly List<OrderItem> items;
        private readonly List<IPriceCalculationStrategy> calculationStrategies;

        public Cart()
        {
            this.items = new List<OrderItem>();
            this.calculationStrategies = new List<IPriceCalculationStrategy>()
            {
                new SpecialCalculationStrategy(),
                new WeightCalculationStrategy()
            };
        }

        public IEnumerable<OrderItem> Items
        {
            get
            {
                return new List<OrderItem>(this.items);
            }
        }

        public string CustomerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            this.items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0.0M;

            foreach (var item in this.items)
            {
                foreach (var strategy in this.calculationStrategies)
                {
                    total += strategy.Calculate(item);
                }
            }
            //more rules are coming!
            //ето тук ако доваим нова стратегия например много лесно може да стане
            return total;
        }
    }
}
