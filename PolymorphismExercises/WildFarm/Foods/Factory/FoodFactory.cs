using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Foods.Factory
{
    public class FoodFactory
    {
        public Food CreateFoods(string name, int quantity)
        {
            name = name.ToLower();

            switch (name)
            {
                case "fruit":
                    return new Fruit(quantity);
                    break;
                case "meat":
                    return new Meat(quantity);
                    break;
                case "seeds":
                    return new Seeds(quantity);
                    break;
                case "vegetable":
                    return new Vegetable(quantity);
                default:
                    throw new ArgumentException("Invalid food!!!");
            }
        }
    }
}
