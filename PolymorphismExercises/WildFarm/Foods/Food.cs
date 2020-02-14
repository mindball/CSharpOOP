using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods.Contracts;

namespace WildFarm.Foods
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; }

        //test
    }
}
