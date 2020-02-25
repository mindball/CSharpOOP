using SoftUniExample.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniExample.Directors
{
    public interface IVehicleConstructor
    {
        void Construct(VehicleBuilder vehicleBuilder);
    }
}
