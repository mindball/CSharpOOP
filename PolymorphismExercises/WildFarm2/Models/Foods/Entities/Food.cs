using System;
using System.Collections.Generic;
using System.Text;
using WildFarm2.Models.Foods.Contracts;

namespace WildFarm2.Models.Foods.Entities
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; private set; }
    }
}
