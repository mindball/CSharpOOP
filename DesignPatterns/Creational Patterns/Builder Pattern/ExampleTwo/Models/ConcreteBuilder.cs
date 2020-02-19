using ExampleTwo.Contracts;

namespace ExampleTwo.Models
{
    class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();
               
        public void Reset()
        {
            this.product = new Product();
        }

        public void BuildPartA()
        {
            this.product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this.product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this.product.Add("PartC1");
        }

        public Product GetProduct()
        {
            Product result = this.product;
            return result;
        }
    }
}
