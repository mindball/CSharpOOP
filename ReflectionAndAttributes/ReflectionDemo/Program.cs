using System;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Year = 1999;
            Refs(ref car);
            Console.WriteLine(car.Year);
            
        }

        public static void Refs(ref Car a)
        {
            Console.WriteLine($"car a: {a.Year}");

            Car b = a;
            a = new Car();

            Console.WriteLine($"car a: {a.Year}");
            Console.WriteLine($"car b: {b.Year}");
        }

        public class Car
        {
            private int year = 10;
            public int Year
            {
                get => this.year;
                set => this.year = value;
            }
        }
       
    }
}
