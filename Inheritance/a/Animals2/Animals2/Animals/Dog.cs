using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public class Dog : Animal
    {
        public Dog(string gender, int? age, string name) 
            : base(gender, age, name)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!"); 
        }
    }
}
