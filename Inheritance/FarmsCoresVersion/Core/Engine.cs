using FarmsCoresVersion.Factories;
using FarmsCoresVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmsCoresVersion.AnimalsFactory;

namespace FarmsCoresVersion.Core
{
    class Engine
    {
        private AnimalFactory animalFactory;
        private List<Animal> listOfAnimals;

        public Engine()
        {
            listOfAnimals = new List<Animal>();
            this.animalFactory = new AnimalFactory();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (!input.Equals("Beast!"))
            {
                try
                {
                    string type = input;
                    string[] data = Console.ReadLine().Split();
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string gender = data[2];

                    Animal newAnimal = animalFactory.CreatyAnimal(
                        type, name, age, gender);
                    listOfAnimals.Add(newAnimal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
            Print();
        }

        private void Print()
        {
            foreach (var animal in listOfAnimals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }
    }
}

