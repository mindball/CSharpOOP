using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleExtension
{
    public class Car : Vehicle
    {
        private const double AirConditionАdditionalFuelConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += AirConditionАdditionalFuelConsumption;
        }

    }
}
