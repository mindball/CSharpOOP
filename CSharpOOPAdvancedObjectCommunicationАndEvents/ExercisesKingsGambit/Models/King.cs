namespace ExercisesKingsGambit.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    public class King : INameble, IKing, IAttackable
    {
        public event AttackKingEventHadler AttackTheKing;

        private ICollection<ISubordinateble> subordinates;

        public King(string name, ICollection<ISubordinateble> subordinates)
        {
            this.Name = name;
            this.subordinates = subordinates;
        }
      
        public string Name { get; }
        public IReadOnlyCollection<ISubordinateble> Subordinates 
            => (IReadOnlyCollection<ISubordinateble>)this.subordinates;


        public void GetAttack()
        {
            Console.WriteLine($"{this.GetType().Name} {this.Name} is under attack!");
            this.AttackTheKing?.Invoke();
        }

        public void AddSubordinate(ISubordinateble unit)
        {
            this.subordinates.Add(unit);
            this.AttackTheKing += unit.ReactOnAttack;
        }
    }
}
