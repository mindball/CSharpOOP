using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;

namespace Vehicles.Core
{
    class Engine
    {
        public void Run()
        {
            string inputLine;
            string[] inputArg;
            double fuelQuantity;
            double fuelConsumption;
            IVehicle car = null;
            IVehicle truck = null;

            for (int i = 0; i < 2; i++)
            {
                inputLine = Console.ReadLine();
                inputArg = inputLine.Split();
                fuelQuantity = double.Parse(inputArg[1]);
                fuelConsumption = double.Parse(inputArg[2]);
                

                if (inputArg[0].Equals(typeof(Car).Name))
                {
                    car = new Car(fuelQuantity, fuelConsumption);
                }
                else
                {
                    truck = new Truck(fuelQuantity, fuelConsumption);
                }
            }
            inputLine = Console.ReadLine();
            int n = int.Parse(inputLine);           

            for (int i = 0; i < n; i++)
            {
                inputLine = Console.ReadLine();
                inputArg = inputLine.Split();
                string typeOfVehicle = inputArg[1];

                try
                {
                    if (typeOfVehicle.Equals(typeof(Car).Name))
                        VehicleComand(car, inputArg);
                    else
                        VehicleComand(truck, inputArg);

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        public void VehicleComand(IVehicle vehicle, string[] vehicleArguments)
        {
            string vehiclеAction = vehicleArguments[0];
            double vehiclеParameter = double.Parse(vehicleArguments[2]);

            switch (vehiclеAction)
            {
                case "Drive":
                    vehicle.Drive(vehiclеParameter);
                    break;
                case "Refuel":
                    vehicle.ReFuel(vehiclеParameter);
                    break;
            }
        }
    }
}
