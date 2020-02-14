using System;
using System.Collections.Generic;
using System.Text;

namespace SystemSplit.Contracts
{
    public interface IComponentSoftware : IComponent
    {
        int CapacityConsumption
        {
            get;
        }

        int MemoryConsumption
        {
            get;
        }
       
    }
}
