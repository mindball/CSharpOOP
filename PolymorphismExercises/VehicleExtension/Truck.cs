using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleExtension
{
    public class Truck : Vehicle
    {
        private const double AirConditionАdditionalFuelConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += AirConditionАdditionalFuelConsumption;
        }

        public override void ReFuel(double liters)
        {
            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.FuelQuantity += liters * 0.95;
        }
    }
}
