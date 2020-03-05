using AnotherDemo.Contracts;
using System;

namespace AnotherDemo.Models
{
    public class RedColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Red color");
        }
    }
}
