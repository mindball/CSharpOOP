namespace Example.Models
{
    public class Car
    {
        public Car(string make, string model, string colour, int numberOfDoors)
        {
            this.Make = make;
            this.Model = model;
            this.Colour = colour;
            this.NumberOfDoors = numberOfDoors;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfDoors { get; set; }
        public string Colour { get; set; }
    }
}
