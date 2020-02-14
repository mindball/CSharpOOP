using System;
using System.Collections.Generic;
using System.Text;
using VehicleExtension;

namespace VehicleExtension
{
    public class Bus : Vehicle
    {
        private const double AirConditionАdditionalFuelConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double currentFuelConsumption = this.FuelConsumption;
            if (!this.IsEmptyVehicle)
            {
                currentFuelConsumption += AirConditionАdditionalFuelConsumption;
            }
            double currentFuelQuantity = distance * currentFuelConsumption;            
            if (currentFuelQuantity > this.FuelQuantity)
                throw new ArgumentException($"{this.GetType().Name} needs refueling");

            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");

            
            this.FuelQuantity -= currentFuelQuantity;
        }
    }
}
