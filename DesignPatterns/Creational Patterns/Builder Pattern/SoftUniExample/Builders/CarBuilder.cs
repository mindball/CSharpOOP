using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExample.Builders
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            this.Vehicle = new Vehicle("Car");
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "4";
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "2500 cc";
        }

        public override void BuildFrame()
        {
            this.Vehicle["frame"] = "Car Frame";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "4";
        }
    }
}
