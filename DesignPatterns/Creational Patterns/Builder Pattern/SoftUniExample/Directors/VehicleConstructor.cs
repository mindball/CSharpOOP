using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUniExample.Builders;

namespace SoftUniExample.Directors
{
    /// <summary>
    /// The 'Director' class
    /// Construct an object using the Builder interface
    /// </summary>
    /// <param name="type"></param>        
    public class VehicleConstructor : IVehicleConstructor
    {
        //There may be different constructors (with different steps order)
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            //класа директор определя последователността на стъпките при изграждането на колата.
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
