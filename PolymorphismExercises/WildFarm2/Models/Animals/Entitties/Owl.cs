﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm2.Models.Foods.Entities;

namespace WildFarm2.Models.Animals.Entitties
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override List<Type> PrefferedFoodTypes => new List<Type> { typeof(Meat) };
        protected override double WeightMultiplier => 0.25;

        public override string AskFood()
        {
            return "Hoot Hoot";
        }
    }
}
