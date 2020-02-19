namespace ExampleOne.Contracts
{
    public interface AbstractFactory
    {
        AbstractProductA CreateProductA();
        AbstractProductB CreateProductB();
    }
}
