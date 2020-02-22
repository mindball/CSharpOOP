using System;
using System.Collections.Generic;

namespace Example
{
    public class Fruit
    {
        private string typeName;
        private static IDictionary<string, Fruit> fruits = new Dictionary<string, Fruit>();

        private Fruit(string typeName)
        {
            this.typeName = typeName;
        }

        public static Fruit GetFruitByTypeName(string type)
        {
            Fruit fruit;

            if(!fruits.TryGetValue(type, out fruit))
            {
                //Lazy initialization;
                fruit = new Fruit(type);

                fruits.Add(type, fruit);
            }

            return fruit;
        }

        public static void ShowAll()
        {
            if(fruits.Count > 0)
            {
                foreach (var fruit in fruits)
                {
                    Console.WriteLine(fruit.Key);
                }
            }
        }
    }
}
