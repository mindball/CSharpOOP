using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmsCoresVersion.AnimalsFactory
{
    class TomCat : Cat
    {
        private const string gender = "Male";
        public TomCat(string name, int age)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
