using DemoStrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStrategyPattern.Models
{
    public class Order
    {
        /**
            * Order class. Doesn't know the concrete payment method (strategy) user has
            * picked. It uses common strategy interface to delegate collecting payment data
            * to strategy object. It can be used to save order to database.
        */
        private int totalCost = 0;
        private bool isClosed = false;

        public void ProcessOrder(IPayStrategy strategy)
        {
            strategy.CollectPaymentDetails();
            // Here we could collect and store payment data from the strategy.
        }

        public void SetTotalCost(int cost)
        {
            this.totalCost += cost;
        }

        public int GetTotalCost()
        {
            return this.totalCost;
        }

        public bool IsClosed()
        {
            return this.isClosed;
        }

        public void SetClosed()
        {
            this.isClosed = true;
        }
    }
}
