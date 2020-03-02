using System;

namespace Demo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ICar car = new ProxyCar(new Driver(16));
            car.MoveCar();

            car = new ProxyCar(new Driver(22));
            car.MoveCar();
        }
    }
}
