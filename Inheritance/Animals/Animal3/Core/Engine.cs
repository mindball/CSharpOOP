using System;
using System.Collections.Generic;
using System.Text;

namespace Animal3.Core
{
    class Engine
    {
        private AnimalFactory animalFactory;
        private List<Animal> animals;

        public Engine()
        {
            animalFactory = new AnimalFactory();
            animals = new List<Animal>();
        }
        public void Run()
        {
            string input = Console.ReadLine();

            while (!input.Equals("Beast!"))
            {
                try
                {
                    string[] arguments = Console.ReadLine().Split();
                    string name = arguments[0];
                    int? age = int.Parse(arguments[1]);
                    string gender = arguments[2];

                    var newAnimal = animalFactory.CreateAnimal(input, name, age, gender);
                    animals.Add(newAnimal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                animal.ProduceSound();
            }
        }
    }
}
