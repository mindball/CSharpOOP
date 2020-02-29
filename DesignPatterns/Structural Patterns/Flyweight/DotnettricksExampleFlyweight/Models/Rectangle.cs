using DotnettricksExampleFlyweight.Contracts;
using System;

namespace DotnettricksExampleFlyweight.Models
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }
}
