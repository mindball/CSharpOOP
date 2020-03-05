using AnotherDemo.Models;
using System;

namespace AnotherDemo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Shape newShape = new Triangle(new RedColor());
            newShape.ApplyColor();

            newShape = new Pentagon(new GreenColor());
            newShape.ApplyColor();
        }
    }
}
