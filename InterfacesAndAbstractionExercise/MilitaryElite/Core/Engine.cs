using MilitaryElite.Contracs;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private readonly List<ISoldier> arms;
        private ISoldier soldier;
        public Engine()
        {
            this.arms = new List<ISoldier>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (!command.Equals("End"))
            {
                string[] commandArgs = command.Split(' ');

                string type = commandArgs[0];
                string id = commandArgs[1];
                string firstName = commandArgs[2];
                string lastName = commandArgs[3];
                decimal salary = decimal.Parse(commandArgs[4]);

                
                if (type.Equals("Private"))
                {
                    soldier = GetPrivateSoldier(id, firstName, lastName, salary); 
                }
                else if (type.Equals("LieutenantGeneral"))
                {
                    soldier = GetLieutenantGeneral(id, firstName, lastName,
                        salary, commandArgs);   
                }
                else if(type.Equals("Engineer"))
                {
                    soldier = GetEngineer(id, firstName, lastName,
                        salary, commandArgs);
                }
                

                if (soldier != null)
                {
                    this.arms.Add(soldier);
                }

                command = Console.ReadLine();
            }
        }

        private ISoldier GetEngineer(string id, string firstName, string lastName, decimal salary, string[] commandArgs)
        {
            IEngineer engineer = new Engineer(id, firstName, lastName, salary)
        }

        private ISoldier GetLieutenantGeneral(string id, string firstName,
            string lastName, decimal salary, string[] commandArgs)
        {
            ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

            string[] privatesToAddArgs = commandArgs
                .Skip(5)
                .ToArray();
            foreach (var pid in privatesToAddArgs)
            {                
                IPrivate soldierToAdd = (IPrivate)this.arms
                    .First(s => s.Id == pid);
                lieutenantGeneral.AddPrivate(soldierToAdd);
            }

            return lieutenantGeneral;
        }

        private ISoldier GetPrivateSoldier(string id, string firstName, 
            string lastName, decimal salary)
        {
            IPrivate privateSoldier = new Private(id, firstName, lastName, salary);
            return privateSoldier;
        }
    }
}
