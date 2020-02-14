using System;
using System.Collections.Generic;
using System.Text;

namespace SystemSplit.Models
{
    public class PowerHardware : Hardware
    {
        private const int ReduceCapacityByPercent = 75;
        private const int IncreaseMemoryByPercent = 75;

        private int maxCapacity;
        private int maxMemory;

        public PowerHardware(string name, int capacity, int memory, string type)
            : base(name, type)
        {
            this.MaxCapacity = capacity;
            this.MaxMemory = memory;
        }

        public override int MaxCapacity
        {
            get
            {
                return this.maxCapacity;
            }
            set
            {
                int capacityDecrease = (value * ReduceCapacityByPercent) / 100;
                this.maxCapacity = value - capacityDecrease;
            }
        }

        public override int MaxMemory
        {
            get
            {
                return this.maxMemory;
            }
            set
            {
                int memoryIncrease = (value * IncreaseMemoryByPercent) / 100;
                this.maxMemory = value + memoryIncrease;
            }
        }
    }
}
