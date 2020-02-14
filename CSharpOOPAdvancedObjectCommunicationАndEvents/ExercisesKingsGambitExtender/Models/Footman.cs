using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesKingsGambitExtended.Models
{
    public class Footman : Subordinate
    {
        private const int LifePoints = 2;
        public Footman(string name, string action = "panicking")
            : base(name, action, LifePoints) { }

    }
}
