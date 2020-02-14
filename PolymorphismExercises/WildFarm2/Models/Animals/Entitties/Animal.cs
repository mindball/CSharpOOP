using System;
using System.Collections.Generic;
using WildFarm2.Models.Animals.Contracts;
using WildFarm2.Models.Foods.Contracts;
using WildFarm2.Exceptions;

namespace WildFarm2.Models.Animals.Entitties
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        protected abstract List<Type> PrefferedFoodTypes { get; }
        protected abstract double WeightMultiplier { get; }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        public abstract string AskFood();       

        public void Feed(IFood food)
        {
            if(!this.PrefferedFoodTypes.Contains(food.GetType()))
            {
                throw new InvalidOperationException
                    (String.Format(ExceptionMessages.InvalidFoodTypeException, 
                    this.GetType().Name, food.GetType().Name));
            }

            this.Weight += food.Quantity * this.WeightMultiplier;
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
