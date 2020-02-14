using MilitaryEliteVersion2.Contracts;
using MilitaryEliteVersion2.Enums;
using MilitaryEliteVersion2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryEliteVersion2.Core
{
    class Engine
    {
        private ICollection<ISoldier> soldiers;
        private ISoldier soldier;

        public Engine()
        {
            this.soldiers = new List<ISoldier>();
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

                if(type.Equals("Private"))
                {                    
                    soldier = GetPrivateType(int.Parse(id), firstName, lastName, salary);
                }
                else if(type.Equals("LieutenantGeneral"))
                {
                    string[] newArgs = commandArgs.Skip(5).ToArray();
                    soldier = GetLieutenantGeneralType(int.Parse(id), 
                        firstName, lastName, salary, newArgs);
                }
                else if (type.Equals("Engineer"))
                {
                    string[] newArgs = commandArgs.Skip(5).ToArray();
                    soldier = GetEngineerType(int.Parse(id),
                        firstName, lastName, salary, newArgs);

                    //In case of invalid corps the entire line should be skipped
                    if (soldier == null)
                        break;
                }
                else if(type.Equals("Commando"))
                {
                    string[] newArgs = commandArgs.Skip(5).ToArray();
                    soldier = GetCommandoType(int.Parse(id),
                        firstName, lastName, salary, newArgs);

                    //In case of invalid corps the entire line should be skipped
                    if (soldier == null)
                        if (soldier == null)
                        break;
                }
                else if(type.Equals("Spy"))
                {
                    //“Spy<id> < firstName > < lastName > < codeNumber >”
                    string codeNumber = commandArgs[4];
                    soldier = new Spy(int.Parse(id), firstName, lastName, int.Parse(codeNumber));
                }

                if (soldier != null)
                {
                    soldiers.Add(soldier);                   
                }

                command = Console.ReadLine();
            }

            foreach (var @soldier in soldiers)
            {
                Console.WriteLine(@soldier);
            }
        }

        private ISoldier GetCommandoType(int id, string firstName, string lastName, decimal salary, string[] newArgs)
        {
            ICommando commando = null;

            Corp corp;
            bool isCastToCorp = Enum.TryParse<Corp>(newArgs[0], out corp);
            if(isCastToCorp)
            {
                commando = new Commando(id, firstName, lastName, salary, corp);
                string codeName;
                string state;
               
                for (int i = 1; i < newArgs.Length; i += 2)
                {
                    codeName = newArgs[i];
                    state = newArgs[i + 1];
                    
                    //“Commando <id> <firstName> <lastName> <salary> <corps>
                    //<mission1CodeName>  <mission1state> … <missionNCodeName> <missionNstate>”
                    //a missions cde name, description and state will always come together
                    //bool validMissionName = Enum.TryParse<State>(missionName, out newMission.State)
                    if(Enum.TryParse<State>(state, out State newState))
                    {
                        IMission validMissionName = new Mission(codeName, newState);
                        commando.AddMission(validMissionName);
                    } 
                }
            }

            return commando;
        }

        private ISoldier GetEngineerType(int id, string firstName, string lastName, decimal salary, string[] newArgs)
        {
            IEngineer engineer = null;

            Corp corp;
            bool isCastToCorp = Enum.TryParse<Corp>(newArgs[0], out corp);
            if(isCastToCorp)
            {
                engineer = new Engineer(id, firstName, lastName, salary, corp);
                string partName;
                int hoursWorked;
                for (int i = 1; i < newArgs.Length; i += 2)
                {
                    partName = newArgs[i];
                    hoursWorked = int.Parse(newArgs[i + 1]);
                    IRepair repair = new Repair(partName, hoursWorked);
                    engineer.AddRepairs(repair);
                }
            }

            return engineer;

        }

        private ISoldier GetLieutenantGeneralType(int id, string firstName,
            string lastName, decimal salary, string[] newArgs)
        {
            ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
            for (int i = 0; i < newArgs.Length; i++)
            {
                int privateId = int.Parse(newArgs[i]);
                var privateSoldier = soldiers.First(x => x.Id == privateId);

                lieutenantGeneral.AddPrivate((IPrivate)privateSoldier);
            }

            return lieutenantGeneral;
        }

        private ISoldier GetPrivateType(int id, string firstName, string lastName, decimal salary)
        {
            ISoldier currentSoldier = new Private(id, firstName, lastName, salary);
            return currentSoldier;
        }
    }
}
