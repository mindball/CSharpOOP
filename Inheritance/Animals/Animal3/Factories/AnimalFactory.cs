using Animals.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal3.Factories
{
    class AnimalFactory
    {
        public Animal CreateAnimal(string type, string name, int? age, string gender)
        {
            type = type.ToLower();

            switch (type)
            {
                case "cat":
                    return new Cat(gender, age, name);
                case "dog":
                    return new Dog(gender, age, name);
                case "frog":
                    return new Frog(gender, age, name);
                case "kitten":
                    return new Kitten(age, name);
                case "tomcat":
                    return new Tomcat(age, name);
                default:
                    throw new Exception("Invalid input!");
            }
        }
    }
}
