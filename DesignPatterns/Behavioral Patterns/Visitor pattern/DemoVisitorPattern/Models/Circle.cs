using DemoVisitorPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoVisitorPattern.Models
{
    public class Circle : Dot
    {
        private int radius;
        public Circle(int id, int x, int y, int radius)
            : base(id, x, y)
        {
            this.radius = radius;
        }

        public override string Accept(IVisitor visitor)
        {
            return visitor.VisitCircle(this);
        }

        public int GetRadius()
        {
            return this.radius;
        }
    }
}
