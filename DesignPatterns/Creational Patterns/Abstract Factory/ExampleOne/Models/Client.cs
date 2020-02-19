
namespace ExampleOne.Models
{
    using ExampleOne.Contracts;

    public class Client
    {
        private AbstractProductA productA;
        private AbstractProductB productB;

        public Client(AbstractFactory factory)
        {
            this.productA = factory.CreateProductA();
            this.productB = factory.CreateProductB();
        }
    }
}
