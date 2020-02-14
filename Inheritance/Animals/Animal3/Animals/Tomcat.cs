using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    class Tomcat : Animal
    {
        private const string gender = "Male";
        public Tomcat(int? age, string name) : base(gender, age, name)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }


    }
}
