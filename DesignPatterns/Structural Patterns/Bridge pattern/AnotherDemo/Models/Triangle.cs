using System;
using AnotherDemo.Contracts;

namespace AnotherDemo.Models
{
    public class Triangle : Shape
    {
        public Triangle(IColor color)
            : base(color)
        {
        }
        public override void ApplyColor()
        {
            Console.WriteLine($"{this.GetType().Name} filled with color");
            this.color.ApplyColor();
        }
    }
}
