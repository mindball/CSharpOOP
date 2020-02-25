using SoftUniExample.Builders;
using SoftUniExample.Directors;

namespace SoftUniExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //We cabn choose concrete constructor (director)
            IVehicleConstructor director = new VehicleConstructor();

            //And we can choose concrete builder
            VehicleBuilder builder = new CarBuilder();
            director.Construct(builder);
            builder.Vehicle.Show();

            director = new VehicleConstructor();
            builder = new ScooterBuilder();
            director.Construct(builder);
            builder.Vehicle.Show();

            director = new VehicleConstructor();
            builder = new MotorCycleBuilder();
            director.Construct(builder);
            builder.Vehicle.Show();
        }
    }
}
