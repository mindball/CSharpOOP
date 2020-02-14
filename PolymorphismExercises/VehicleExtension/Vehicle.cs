using System;
using System.Collections.Generic;
using System.Text;
using VehicleExtension.Contracts;

namespace VehicleExtension
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            
        }

        public bool IsEmptyVehicle { get; set; }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                if (value > this.TankCapacity)
                    value = 0;
               
               this.fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            set
            {
                this.tankCapacity = value;
            }
        }

        public virtual void Drive(double distance)
        {
            double currentFuelQuantity = distance * this.FuelConsumption;
            if (currentFuelQuantity > this.FuelQuantity)
                throw new ArgumentException($"{this.GetType().Name} needs refueling");

            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            this.FuelQuantity -= currentFuelQuantity;
        }

        public virtual void ReFuel(double liters)
        {
            if(this.FuelQuantity + liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            
            if(liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
