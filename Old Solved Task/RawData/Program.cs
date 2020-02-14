using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> flamableCar = new List<Car>();
            List<Car> fragileCar = new List<Car>();
            Dictionary<string, List<Car>> cars = new Dictionary<string, List<Car>>();

            string model = "";
            int engineSpeed = 0;
            int enginePower = 0;
            int cargoWeight = 0;
            string cargoType = "";
            double tire1Pressure = 0.0;
            int tire1age = 0;
            double tire2Pressure = 0.0;
            int tire2age = 0;
            double tire3Pressure = 0.0;
            int tire3age = 0;
            double tire4Pressure = 0.0;
            int tire4age = 0;

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                model = parameters[0];
                engineSpeed = int.Parse(parameters[1]);
                enginePower = int.Parse(parameters[2]);
                cargoWeight = int.Parse(parameters[3]);
                cargoType = parameters[4];
                tire1Pressure = double.Parse(parameters[5]);
                tire1age = int.Parse(parameters[6]);
                tire2Pressure = double.Parse(parameters[7]);
                tire2age = int.Parse(parameters[8]);
                tire3Pressure = double.Parse(parameters[9]);
                tire3age = int.Parse(parameters[10]);
                tire4Pressure = double.Parse(parameters[11]);
                tire4age = int.Parse(parameters[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                List<Tire> newTire = new List<Tire>()
                {
                    new Tire(tire1Pressure, tire1age),
                    new Tire(tire2Pressure, tire2age),
                    new Tire(tire3Pressure, tire3age),
                    new Tire(tire4Pressure, tire4age),
                };

                if (!cars.ContainsKey(cargoType))
                {
                    cars.Add(cargoType, new List<Car>() { new Car(model, engine, cargo, newTire) });
                }
                else
                {
                    cars[cargoType].Add(new Car(model, engine, cargo, newTire));
                }
            }

            string command = Console.ReadLine();
            List<Car> result;
            if (cars.TryGetValue(command, out result))
            {

                if (command.Equals("flamable"))
                {
                    var orderCarByEnginePower = result.OrderBy(a => a.Model)
                                                        .Where(a => a.Engine.EnginePower > 250);
                    foreach (var c in orderCarByEnginePower)
                    {
                        Console.WriteLine(c.Model);
                    }
                }
                else
                {
                    var orderCarByTirePressure = result.Where(c => c.Tire.Any(t => t.TirePressure < 1))
                                                        .OrderBy(c => c.Model)
                                                        .Select(c => c.Model);
                    foreach (var c in orderCarByTirePressure)
                    {
                        Console.WriteLine(c);
                    }
                }

            }
        }
    }
}
