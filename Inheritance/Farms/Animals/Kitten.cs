using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farms.AnimalsFactory
{
    class Kitten : Cat
    {
        private const string gender = "Female";
        public Kitten(string name, int age) 
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
