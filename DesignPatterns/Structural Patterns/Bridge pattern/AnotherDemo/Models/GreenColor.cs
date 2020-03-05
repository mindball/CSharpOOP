using AnotherDemo.Contracts;
using System;

namespace AnotherDemo.Models
{
    class GreenColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Green color");
        }
    }
}
