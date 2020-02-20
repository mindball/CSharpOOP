using Example3.Contracts;
using System;

// Builds components and set them as per need of a Kids Bicycle
namespace Example3.Models
{
    public class KidsBicycleBuilder : IBicycleBuilder
    {
        private Bicycle bicycle;
        public KidsBicycleBuilder()
        {
            bicycle = new Bicycle();
            bicycle.BicycleType = "Kids Bicycle";
        }
        public void SetHeight(int height)
        {
            Console.WriteLine("Bicycle is set with given height: {0}", height);
            bicycle.BicycleHeight = height;
        }
        public void SetFrame()
        {
            Console.WriteLine("Frame has been set.");
        }
        public void SetGears()
        {
            Console.WriteLine("Gears have been set.");
        }
        public void PutTires()
        {
            Console.WriteLine("Tires have been set.");
        }
        public void SetColour(string colour)
        {
            Console.WriteLine("Bicycle is set with given colour: {0}", colour);
            bicycle.BicycleColour = colour;
        }
        public void PutAccessaries()
        {
            Console.WriteLine("Accessaries have been set.");
        }
        public Bicycle GetBicycle()
        {
            return this.bicycle;
        }
    }
}
