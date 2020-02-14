using System;
using System.Collections.Generic;
using System.Text;

namespace SystemSplit.Models
{
    class ExpressSoftware : Software
    {
        private int memoryConsumption;
        private int capacityConsumption;
        public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption)
            : base(name)
        {
            this.MemoryConsumption = memoryConsumption;
            this.CapacityConsumption = capacityConsumption;
        }
        
        public override int MemoryConsumption
        {
            get
            {
                return this.memoryConsumption;
            }
            set
            {
                this.memoryConsumption = value * 2;
            }
        }

        public override int CapacityConsumption
        {
            get => this.capacityConsumption;
            set => this.capacityConsumption = value;
        }
    }
}
