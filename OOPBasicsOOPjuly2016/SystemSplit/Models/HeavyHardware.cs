using System;
using System.Collections.Generic;
using System.Text;
using SystemSplit.Contracts;

namespace SystemSplit.Models
{
    public class HeavyHardware : Hardware
    {
        private const int DecreaseMemoryByPercent = 25;

        private int maxCapacity;
        private int maxMemory;
        private string typeOfHardware;

        public HeavyHardware(string name, int capacity, int memory, string type)
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
                this.maxCapacity = value * 2;
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
                int memoryDecrease = (value * DecreaseMemoryByPercent) / 100;
                this.maxMemory = value - memoryDecrease;
            }
        }

        
    }
}
