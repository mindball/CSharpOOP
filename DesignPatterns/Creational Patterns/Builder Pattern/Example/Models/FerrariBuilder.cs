using Example.Contracts;

namespace Example.Models
{
    public class FerrariBuilder : ICarBuilder
    {
        public string Color { get; set; }
        public int NumberOfDoor { get; set; }

        public Car GetResult()
        {
            return this.NumberOfDoor == 2 ? new Car("Ferrari", "488 Spider", this.Color, this.NumberOfDoor) : null;
        }
    }
}
