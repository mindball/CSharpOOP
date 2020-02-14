using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyShoppingChart
{
    class OnlineOrder : Order
    {
        public OnlineOrder(Cart cart)
            : base(cart)
        {

        }
    }
}
