
namespace ExampleOne.Models
{
    using ExampleOne.Contracts;

    public class ConcreteFactoryA : AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
