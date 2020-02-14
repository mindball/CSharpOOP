using Farms.AnimalsFactory;
using System;

namespace Farms.Factories
{
    public class AnimalFactory
    {
        public Animal CreatyAnimal(string type, string name,
                int age, string gender)
        {
            type = type.ToLower();

            switch(type)
            {
                case "cat":
                    return new Cat(name, age, gender);
                    break;
                case "dog":
                    return new Dog(name, age, gender);
                    break;
                case "frog":
                    return new Frog(name, age, gender);
                    break;
                case "kitten":
                    return new Kitten(name, age);
                    break;
                case "tomcat":
                    return new TomCat(name, age);
                    break;
                default:
                    throw new Exception("Invalid input");
            }
        } 
    }
}
