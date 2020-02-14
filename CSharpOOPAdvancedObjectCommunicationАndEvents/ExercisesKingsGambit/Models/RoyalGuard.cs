using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesKingsGambit.Models
{
    class RoyalGuard : Subordinate
    {
        public RoyalGuard(string name, string action = "defending")
            : base(name, action) { }

        public override void ReactOnAttack()
        {
            if (this.IsAlive)
            {
                Console.WriteLine($"Royal Guard {this.Name} is {this.Action}");
            }
        }
    }
}
