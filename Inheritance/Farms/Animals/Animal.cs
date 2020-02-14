using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farms.AnimalsFactory
{
    public  abstract class Animal
    {
        //TODO think over the class
        private string name;
        private int? age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Gender
        {
            get { return gender; }
            private set
            {
                if(value == null || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid input");
                }
                gender = value;

            }
        }

        public int? Age
        {
            get { return age; }
            private set
            {
                if(value == null || value < 0)
                {
                    throw new Exception("Invalid input");
                }
                age = value;
            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid input");
                }
                name = value;
            }
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine("Screaam");
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
