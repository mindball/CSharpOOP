using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesKingsGambit.Models
{
    public class Footman : Subordinate
    {
        public Footman(string name, string action = "panicking")
            : base(name, action) { }

    }
}
