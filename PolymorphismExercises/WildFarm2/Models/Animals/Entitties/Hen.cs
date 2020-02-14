using System;
using System.Collections.Generic;
using System.Text;
using WildFarm2.Models.Foods.Entities;

namespace WildFarm2.Models.Animals.Entitties
{
    class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override List<Type> PrefferedFoodTypes
            => new List<Type>
            {
                typeof(Fruit),
                typeof(Meat),
                typeof(Seeds),
                typeof(Vegetable)
            };
        protected override double WeightMultiplier => 0.35;

        public override string AskFood()
        {
            return "Cluck";
        }
    }
}
