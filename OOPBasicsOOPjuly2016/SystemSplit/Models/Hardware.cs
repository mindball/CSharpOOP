using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemSplit.Contracts;

namespace SystemSplit.Models
{
    public abstract class Hardware : IComponentHardware
    {

        public Hardware(string name, string typeOfHardware)
        {
            this.Name = name;
            this.SoftwareComponets = new List<IComponentSoftware>();
            this.TypeOfHardware = typeOfHardware;
        }

        public string Name { get; set; }
        public abstract int MaxCapacity { get; set; }
        public abstract int MaxMemory { get; set; }
        public string TypeOfHardware { get; private set; }
        private int MemoryUsed { get; set; }
        private int CapacityUsed { get; set; }

        public IList<IComponentSoftware> SoftwareComponets { get; set; }

        public void AddSoftwareComponent(IComponentSoftware softwareComponent)
        {
            this.SoftwareComponets.Add(softwareComponent);
        }

    }
}
