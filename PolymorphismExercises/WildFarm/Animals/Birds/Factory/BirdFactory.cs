using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Birds.Factory
{
    public class BirdFactory
    {
        public Bird CreateBirds(string type, string name, double weight, double wingSize)
        {
            type = type.ToLower();

            switch(type)
            {
                case "owl":
                    return new Owl(name, weight, wingSize);
                    break;
                case "hen":
                    return new Hen(name, weight, wingSize);
                    break;
                default:
                    throw new ArgumentException("no kind of birds!!!");
            }
        }
    }
}
