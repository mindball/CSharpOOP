
namespace ExampleOne.Models
{
    using ExampleOne.Contracts;

    public class ConcreteFactoryB : AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
