using DemoVisitorPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoVisitorPattern.Models
{
    public class CompoundShape : IShape
    {
        private int id;
        private List<IShape> shapes = new List<IShape>();

        public CompoundShape(int id)
        {
            this.id = id;
        }

        public IReadOnlyList<IShape> Shapes => this.shapes.AsReadOnly();

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitCompoundGraphic(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Draw {this.GetType().Name}");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"Move {this.GetType().Name} {x} and {y} coordinate");
        }

        public int GetId()
        {
            return this.id;
        }

        public void AddShapes(IShape shape)
        {
            this.shapes.Add(shape);
        }
    }
}
