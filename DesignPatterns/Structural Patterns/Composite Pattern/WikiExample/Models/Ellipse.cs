using System;
using WikiExample.Contracts;

namespace WikiExample.Models
{
    /// <summary>
    /// Leaf
    /// </summary>
    public class Ellipse : IGraphic
    {
        public void Print()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
