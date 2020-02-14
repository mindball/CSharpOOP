using System;
using System.Collections.Generic;
using System.Text;
using WildFarm2.Models.Foods.Entities;

namespace WildFarm2.Models.Animals.Entitties
{
    public class Dog : Mammals
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override List<Type> PrefferedFoodTypes
            => new List<Type>()
            {
                typeof(Meat)
            };

        protected override double WeightMultiplier { get; }

        public override string AskFood()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
