using System;
using System.Collections.Generic;
using System.Text;

namespace SystemSplit.Models
{
    class LightSoftware : Software
    {
        private const int capacityConsumptionPercent = 50;
        private const int memoryConsumptionPercent = 50;

        private int memoryConsumption;
        private int capacityConsumption;

        public LightSoftware(string name, int capacityConsumption, int memoryConsumption)
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
                int decreaseMemory = (value * memoryConsumptionPercent) / 100;
                this.memoryConsumption = value - decreaseMemory;
            }

        }

        public override int CapacityConsumption
        {
            get
            {
                return this.capacityConsumption;
            }
            set
            {
                int increaseCapacity = (value * capacityConsumptionPercent) / 100;
                this.capacityConsumption = value + increaseCapacity;
            }
        }
    }
}
