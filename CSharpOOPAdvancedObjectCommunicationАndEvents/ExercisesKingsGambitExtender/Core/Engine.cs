using ExercisesKingsGambitExtended.Contracts;
using ExercisesKingsGambitExtended.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesKingsGambitExtended.Core
{
    class Engine
    {
        private IKing newKing;

        public void Run()
        {

            string input = Console.ReadLine();
            string kingName = input;
            this.newKing = new King(kingName, new List<ISubordinateble>());

            string[] rouyalGuards = Console.ReadLine().Split(" ");
            foreach (var item in rouyalGuards)
            {
                ISubordinateble subordinate = new RoyalGuard(item);
                this.newKing.AddSubordinate(subordinate);
            }

            string[] footsman = Console.ReadLine().Split(" ");
            foreach (var item in footsman)
            {
                ISubordinateble subordinate = new Footman(item);
                this.newKing.AddSubordinate(subordinate);
            }
                       
            input = Console.ReadLine();
            while (!input.Equals("End"))
            {
                string[] tokens = input.Split();

                if (tokens[0].Equals("Attack"))
                {
                    this.newKing.GetAttack();
                }
                else if(tokens[0].Equals("Kill"))
                {
                    this.newKing.Subordinates.First(x => x.Name == tokens[1]).TakeDamage();
                }

                input = Console.ReadLine();

            }
            Console.WriteLine();

        }

    }
}
