using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals;
using WildFarm.Animals.Birds.Factory;
using WildFarm.Animals.Contracts;
using WildFarm.Animals.Mammals.Feline.FelineFactory;
using WildFarm.Animals.Mammals.MammalFactory;
using WildFarm.Foods.Contracts;
using WildFarm.Foods.Factory;

namespace WildFarm.Core
{
    class Engine
    {
        private FoodFactory foodfactory;
        private BirdFactory birdFactory;
        private MammalFactory mammalsFactory;
        private FelineFactory felineFactory;
        private List<Animal> animals;

        public Engine()
        {
            foodfactory = new FoodFactory();
            birdFactory = new BirdFactory();
            mammalsFactory = new MammalFactory();
            felineFactory = new FelineFactory();
            animals = new List<Animal>();
        }

        public void Run()
        {
            string input = Console.ReadLine();
            Animal animal = null;

            while (!input.Equals("End"))
            {
                string[] inputArguments = input.Split();
                string type = inputArguments[0];
                string name = inputArguments[1]; ;
                double weight = double.Parse(inputArguments[2]);

                try
                {
                    if (type.Equals("Cat") || type.Equals("Tiger"))
                    {
                        string livingRegion = inputArguments[3];
                        string breed = inputArguments[4];

                        animal = felineFactory.CreateFeline(type, name, weight, livingRegion, breed);
                    }
                    else if (type.Equals("Dog") || type.Equals("Mouse"))
                    {
                        string livingRegion = inputArguments[3];

                        animal = mammalsFactory.CreateMamamls(type, name, weight, livingRegion);

                    }
                    else if (type.Equals("Owl") || type.Equals("Hen"))
                    {
                        double wingSize = double.Parse(inputArguments[3]);

                        animal = birdFactory.CreateBirds(type, name, weight, wingSize);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                string secondInput = Console.ReadLine();
                string[] secondInputs = secondInput.Split();
                var foodType = foodfactory.CreateFoods(secondInputs[0], int.Parse(secondInputs[1]));
                animal.ProduceSound();
                try
                {
                    animal.Eat(foodType);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);

                input = Console.ReadLine();
            }

            foreach (var currentAnimal in animals)
            {
                Console.WriteLine(currentAnimal);
            }
        }
    }
}
