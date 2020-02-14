using MilitaryElite.Contracs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class Repair : IRepair
    {
        public Repair(string partName, int hoursWork)
        {
            this.PartName = partName;
            this.HoursWork = hoursWork;
        }
        public string PartName { get; }
        public int HoursWork { get; }

    }
}
