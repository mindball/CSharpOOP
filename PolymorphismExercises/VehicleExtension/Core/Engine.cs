using System;
using System.Collections.Generic;
using System.Text;
using VehicleExtension.Contracts;

namespace VehicleExtension.Core
{
    class Engine
    {
        public void Run()
        {
            string inputLine;
            string[] inputArg;
            double fuelQuantity;
            double fuelConsumption;
            double tankCapacity;
            IVehicle car = null;
            IVehicle truck = null;
            IVehicle bus = null;

            for (int i = 0; i < 3; i++)
            {
                inputLine = Console.ReadLine();
                inputArg = inputLine.Split();
                fuelQuantity = double.Parse(inputArg[1]);
                fuelConsumption = double.Parse(inputArg[2]);
                tankCapacity = double.Parse(inputArg[3]);



                if (inputArg[0].Equals(typeof(Car).Name))
                {
                    car = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else if(inputArg[0].Equals(typeof(Truck).Name))
                {
                    truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else
                {
                    bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
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
                    else if(typeOfVehicle.Equals(typeof(Truck).Name))
                        VehicleComand(truck, inputArg);
                    else
                        VehicleComand(bus, inputArg);

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
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
                case "DriveEmpty":
                    vehicle.IsEmptyVehicle = true;
                    vehicle.Drive(vehiclеParameter);
                    break;
            }
        }
    }
}
