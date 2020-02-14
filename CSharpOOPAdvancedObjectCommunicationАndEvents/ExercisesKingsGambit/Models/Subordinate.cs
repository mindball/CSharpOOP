namespace ExercisesKingsGambit.Models
{
    using System;
    using Contracts;

    public abstract class Subordinate : ISubordinateble
    {
        public Subordinate(string name, string action)
        {
            this.Name = name;
            this.Action = action;
            this.IsAlive = true;
        }
        public string Name { get; }
        public bool IsAlive { get; private set; }

        public string Action { get; }

        public virtual void ReactOnAttack()
        {
            if (this.IsAlive)
            {
                Console.WriteLine($"{this.GetType().Name} {this.Name} is {this.Action}!");
            }
        }

        public void Kill()
        {
            this.IsAlive = false;
        }
    }
}
