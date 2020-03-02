using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Car : ICar
    {
        public void MoveCar()
        {
            Console.WriteLine("Car has been driven");
        }
    }
}
