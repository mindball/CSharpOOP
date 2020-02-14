using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesKingsGambitExtended.Models
{
    class RoyalGuard : Subordinate
    {
        private const int LifePoints = 3;
        public RoyalGuard(string name, string action = "defending")
            : base(name, action, LifePoints) { }

        public override void ReactOnAttack()
        {
            if (this.IsAlive)
            {
                Console.WriteLine($"Royal Guard {this.Name} is {this.Action}");
            }
        }
    }
}
