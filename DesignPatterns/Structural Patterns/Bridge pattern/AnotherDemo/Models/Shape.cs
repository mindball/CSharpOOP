using AnotherDemo.Contracts;

namespace AnotherDemo.Models
{
    public abstract class Shape
    {
        protected IColor color;

        public Shape(IColor color)
        {
            this.color = color;
        }

        public abstract void ApplyColor();
    }
}
