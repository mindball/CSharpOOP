using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals.Feline.FelineFactory
{
    public class FelineFactory
    {
        public Feline CreateFeline(string type, string name, double weight, 
            string livingRegion, string breed)
        {
            type = type.ToLower();

            switch(type)
            {
                case "cat":
                    return new Cat(name, weight, livingRegion, breed);
                    break;
                case "tiger":
                    return new Tiger(name, weight, livingRegion, breed);
                    break;
                default:
                    throw new ArgumentException("no kind of feline");
            }
        }
    }
}
