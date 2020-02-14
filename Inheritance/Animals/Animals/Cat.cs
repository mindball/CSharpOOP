using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public class Cat : Animal
    {
        public Cat(string gender, int? age, string name) 
            : base(gender, age, name)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
