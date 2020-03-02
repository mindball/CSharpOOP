using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class ProxyCar : ICar
    {
        private Driver driver;
        private ICar realCar;

        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            this.realCar = new Car();
        }
        public void MoveCar()
        {
            if(this.driver.Age <= 16)
            {
                Console.WriteLine("Sorry, the driver is too young to drive");
            }
            else
                {
                realCar.MoveCar();
            }
        }
    }
}
