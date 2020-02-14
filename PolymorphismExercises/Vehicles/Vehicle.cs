using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public double FuelQuantity
        {
            get; set;
        }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double currentFuelQuantity = distance * this.FuelConsumption;
            if (currentFuelQuantity > this.FuelQuantity)
                throw new ArgumentException($"{this.GetType().Name} needs refueling");

            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            this.FuelQuantity -= currentFuelQuantity;
        }

        public void ReFuel(double fuelQuantity)
        {
            if(this is Truck)
            {
                fuelQuantity *= 0.95;
            }

            this.FuelQuantity += fuelQuantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
