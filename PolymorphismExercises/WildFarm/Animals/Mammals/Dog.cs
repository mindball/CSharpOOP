﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double foodIncrease = 0.40;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Fruit || food is Seeds)
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += food.Quantity * foodIncrease;
            this.FoodEaten += food.Quantity;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
