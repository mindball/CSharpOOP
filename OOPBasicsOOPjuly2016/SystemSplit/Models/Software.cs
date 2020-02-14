using System;
using System.Collections.Generic;
using System.Text;
using SystemSplit.Contracts;

namespace SystemSplit.Models
{
    public abstract class Software : IComponentSoftware
    {
        public Software(string name)
        {
            this.Name = name;
        }

        public abstract int CapacityConsumption { get; set; }
        public abstract int MemoryConsumption { get; set; }
        public string Name { get; set; }

    }
}
