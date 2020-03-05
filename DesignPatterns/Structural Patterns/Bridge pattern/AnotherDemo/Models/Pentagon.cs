using System;
using AnotherDemo.Contracts;

namespace AnotherDemo.Models
{
    class Pentagon : Shape
    {
        public Pentagon(IColor color)
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
