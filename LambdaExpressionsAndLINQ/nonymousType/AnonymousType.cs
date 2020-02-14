using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    class AnonymousType
    {
        public int Age { get; set; }
        public string  Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new { Engine = 1.9, Color = "Red" };

            Console.WriteLine("{0}, {1}", myCar.Color, myCar.Engine);
            Console.WriteLine(myCar.ToString());
            Console.WriteLine(myCar.GetHashCode());
            Console.WriteLine(myCar.Equals(new { Engine = 1.9, Color = "Red" }));

            Console.WriteLine(myCar.GetType());

            List<AnonymousType> dogs = new List<AnonymousType>()
            {
                new AnonymousType() {Age = 3,Name = "Sharo" },
                new AnonymousType() {Age = 5,Name = "Rila" },
                new AnonymousType() {Age = 6,Name = "Bacho" },
                new AnonymousType() {Age = 7,Name = "Sasho" },
                new AnonymousType() {Age = 8,Name = "Bay" },
                new AnonymousType() {Age = 9,Name = "Richi" },
               
            };

            var newCol = dogs.Select(x => new { Age = x.Age, FirsLeeter = x.Name[0] });

        }
    }
}
