namespace ExercisesKingsGambitExtended.Models
{
    using System;
    using Contracts;

    public abstract class Subordinate : ISubordinateble
    {
        public Subordinate(string name, string action, int hitPoints)
        {
            this.Name = name;
            this.Action = action;
            this.HitPoints = hitPoints;

            this.IsAlive = true;
        }
        public string Name { get; }
        public bool IsAlive { get; private set; }

        public string Action { get; }
        public int HitPoints { get; private set; }

        public event SubordinateDeathEventHandler RemoveDeathUnitEvent;

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
            this.RemoveDeathUnitEvent?.Invoke(this);
        }
        public void TakeDamage()
        {
            this.HitPoints--;
            if (this.HitPoints <= 0)
                this.Kill();
        }
    }
}
