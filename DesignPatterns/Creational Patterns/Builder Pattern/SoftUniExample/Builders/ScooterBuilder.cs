using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExample.Builders
{
    class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            this.Vehicle = new Vehicle("Scooter");
        }

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "500 cc";
        }

        public override void BuildFrame()
        {
            this.Vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "2";
        }
    }
}
