using System;
using System.Collections.Generic;
using System.Text;

namespace PetClinics.Core
{

    class Engine
    {
        private ClinicsManager manager;
        public Engine()
        {
            manager = new ClinicsManager();
        }
        public void Run(int numberOfArguments)
        {
            while (numberOfArguments >= 0)
            {
                string input = Console.ReadLine();
                string[] arguments = input.Split();

                switch(arguments[0])
                {
                    case "Create":
                        if (arguments.Length == 4)
                            manager.CreateClinic(arguments[2],
                                int.Parse(arguments[3]));
                        else
                            manager.CreatePet(arguments[2],
                                int.Parse(arguments[3]),
                                arguments[4]);
                        break;
                    case "Add":
                        manager.AddPet(arguments[1],
                            arguments[2]);
                        break;
                    case "Release":
                        manager.Release(arguments[1]);
                        break;
                    case "Print":
                        if (arguments.Length == 3)
                            manager.PrintSpecifiedRoom(arguments[1],
                                int.Parse(arguments[2]));
                        else
                            manager.PrintAllRooms(arguments[1]);
                        break;
                    case "HasEmptyRooms":
                        manager.HasEmptyRooms(arguments[1]);
                        break;
                }
            }

            
        }
    }
}
