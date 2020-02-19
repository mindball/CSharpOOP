using ExampleTwo.Contracts;

namespace ExampleTwo.Models
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void buildMinimalViableProduct()
        {
            this.builder.BuildPartA();
        }

        public void buildFullFeaturedProduct()
        {
            this.builder.BuildPartA();
            this.builder.BuildPartB();
            this.builder.BuildPartC();
        }
    }
}
