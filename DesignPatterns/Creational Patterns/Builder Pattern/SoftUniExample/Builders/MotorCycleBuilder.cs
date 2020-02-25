using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExample.Builders
{
    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            this.Vehicle = new Vehicle("Motor Cycle");
        }       

        public override void BuildDoors()
        {
            this.Vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            this.Vehicle["engine"] = "1000 cc";
        }

        public override void BuildFrame()
        {
            this.Vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildWheels()
        {
            this.Vehicle["wheels"] = "2";
        }
    }
}
