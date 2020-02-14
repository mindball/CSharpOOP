using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals.MammalFactory
{
    public class MammalFactory
    {
        public Mammal CreateMamamls(string type, string name, double weight, string livingRegion)
        {
            type = type.ToLower();

            switch (type)
            {
                case "mouse":
                    return new Mouse(name, weight, livingRegion);
                    break;
                case "dog":
                    return new Dog(name, weight, livingRegion);
                    break;
                default:
                    throw new ArgumentException("no kind of mammals");
            }
        }
    }
}
