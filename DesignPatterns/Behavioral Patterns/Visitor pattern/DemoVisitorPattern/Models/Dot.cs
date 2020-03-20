using System;
using DemoVisitorPattern.Contracts;

namespace DemoVisitorPattern.Models
{
    public class Dot : IShape
    {
        private int id;
        private int x;
        private int y;

        public Dot(int id, int x, int y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
        }

        public virtual string Accept(IVisitor visitor)
        {
            return visitor.VisitDot(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Draw {this.GetType().Name}");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"Move {this.GetType().Name}");
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetId()
        {
            return this.id;
        }
    }
}
