using System;
using System.Collections.Generic;
using System.Linq;

class Start
{
    static void Main(string[] args)
    {
        List<Car> cars;
        Dictionary<string, Engine> engines;        

        int engineCount = int.Parse(Console.ReadLine());
        engines = SetEngineType(engineCount);        

        int carCount = int.Parse(Console.ReadLine());
        cars = SetCarType(carCount, engines);

        foreach (var item in cars)
        {
            Console.WriteLine(item);
        }                   
    }

    private static List<Car> SetCarType(int carCount, Dictionary<string, Engine> engines)
    {
        List<Car> cars = new List<Car>();
        string[] carParams;       
        string carModel = "";
        Engine carEngineType;
        int carWeight;
        string carColor = "";

        for (int i = 1; i <= carCount; i++)
        {
            carParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            carModel = carParams[0];            
                       
            if(engines.TryGetValue(carParams[1], out carEngineType))
            {
               
                if (carParams.Length == 2)
                    cars.Add(new Car(carModel, carEngineType));
                else if (carParams.Length == 3 && int.TryParse(carParams[2], out carWeight))
                {
                    carWeight = int.Parse(carParams[2]);
                    cars.Add(new Car(carModel, carEngineType, carWeight));
                }
                else if (carParams.Length == 3 && !string.IsNullOrEmpty(carParams[2]))
                {
                    carColor = carParams[2];
                    cars.Add(new Car(carModel, carEngineType, carColor));
                }
                else
                {
                    carWeight = int.Parse(carParams[2]);
                    carColor = carParams[3];
                    cars.Add(new Car(carModel, carEngineType, carWeight, carColor));
                }
            }            
        }

        return cars;
    }

    private static Dictionary<string, Engine> SetEngineType(int engineCount)
    {
        Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
        string[] engineParams;
        string engineModel = "";
        int enginePower = 0;
        int engineDisplacement;
        string engineEfficiency;        

        for (int i = 1; i <= engineCount; i++)
        {
            engineParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            engineModel = engineParams[0];
            enginePower = int.Parse(engineParams[1]);

            if (engineParams.Length == 2)
            {
                engines.Add(engineModel, new Engine(engineModel, enginePower));
            }
            else if (engineParams.Length == 3 && int.TryParse(engineParams[2], out engineDisplacement))
            {
                //call base Engine constructor wih option param:engineDisplacement
                engines.Add(engineModel, new Engine(engineModel, enginePower, engineDisplacement));
            }
            else if (engineParams.Length == 3 && !string.IsNullOrEmpty(engineParams[2]))
            {
                // call base Engine constructor wih option param: efficiency
                engineEfficiency = engineParams[2];
                engines.Add(engineModel, new Engine(engineModel, enginePower, engineEfficiency));
            }
            else
            {
                //all option params
                engines.Add(engineModel, new Engine(engineModel, enginePower, int.Parse(engineParams[2]), engineParams[3]));
            }
        }

        return engines;
    }
}

