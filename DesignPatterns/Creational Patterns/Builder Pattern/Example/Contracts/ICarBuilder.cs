using Example.Models;

namespace Example.Contracts
{
    public interface ICarBuilder
    {
        string Color { get; set; }

        int NumberOfDoor { get; set; }

        Car GetResult();
    }
}
