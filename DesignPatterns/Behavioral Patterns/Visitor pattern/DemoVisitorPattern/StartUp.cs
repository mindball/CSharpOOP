using DemoVisitorPattern.Contracts;
using DemoVisitorPattern.Models;
using System;

namespace DemoVisitorPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dot dot = new Dot(1, 10, 55);
            Circle circle = new Circle(2, 23, 15, 10);
            Rectangle rectangle = new Rectangle(3, 10, 17, 20, 30);

            CompoundShape compoundShape = new CompoundShape(4);
            compoundShape.AddShapes(dot);
            compoundShape.AddShapes(circle);
            compoundShape.AddShapes(rectangle);

            CompoundShape c = new CompoundShape(5);
            c.AddShapes(dot);
            compoundShape.AddShapes(c);

            Export(circle, compoundShape);
        }

        private static void Export(params IShape[] shapes)
        {
            XMLExportVisitor exportVisitor = new XMLExportVisitor();
            Console.WriteLine(exportVisitor.Export(shapes));
        }
    }
}
