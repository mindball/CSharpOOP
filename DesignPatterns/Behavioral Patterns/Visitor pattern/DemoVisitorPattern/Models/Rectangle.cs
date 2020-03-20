using DemoVisitorPattern.Contracts;
using System;

namespace DemoVisitorPattern.Models
{
    public class Rectangle : IShape
    {
        private int id;
        private int x;
        private int y;
        private int width;
        private int height;

        public Rectangle(int id, int x, int y, int width, int height)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitRectangle(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Draw {this.GetType().Name}");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"Move {this.GetType().Name} {x} and {y} coordinate" );
        }

        public int GetId()
        {
            return this.id;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int GetHeight()
        {
            return this.height;
        }
    }
}
