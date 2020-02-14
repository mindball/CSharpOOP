using DependencyInversion.LiveDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.LiveDemo
{
    public class ConsoleRenderer : IRenderer
    {
        public void DrawAt(Shape shape)
        {
            Console.SetCursorPosition(shape.PositionX, 
                shape.PositionY);
            Console.WriteLine("peshka");
        }
    }
}
