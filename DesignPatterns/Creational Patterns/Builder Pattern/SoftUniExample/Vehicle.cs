using System.Collections.Generic;
using System;

namespace SoftUniExample
{
    public class Vehicle
    {
        private string vehicleType;
        private readonly Dictionary<string, string> parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get => this.parts[key];
            set
            {
                this.parts[key] = value;
            }
        }

        public void Show()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Vehicle Type: {0}", this.vehicleType);
            Console.WriteLine(" Frame   : {0}", this["frame"]);
            Console.WriteLine(" Engine  : {0}", this["engine"]);
            Console.WriteLine(" #Wheels : {0}", this["wheels"]);
            Console.WriteLine(" #Doors  : {0}", this["doors"]);

        }
    }
}
