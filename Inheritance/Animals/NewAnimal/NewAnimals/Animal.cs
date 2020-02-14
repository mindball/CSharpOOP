using System;

namespace Animals.Animals
{
    public abstract class Animal
    {
        private string  name;
        private int? age;
        private string gender;

        protected Animal(string gender, int? age, string name)
        {
            this.Gender = gender;
            this.Age = age;
            this.Name = name;
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Invalid input!");
                gender = value;
            }
        }

        public int? Age
        {
            get { return age; }
            set
            {
                if (value == null || value <= 0)
                    throw new Exception("Invalid input!");
                age = value;
            }
        }

        public string  Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Invalid input!");
                name = value;
            }
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine("Some sound");
        }

        public override string ToString()
        {
            var type = this.GetType().Name;
            return type;
        }

    }
}
