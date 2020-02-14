using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryEliteVersion2.Contracts
{
    public interface IRepair
    {
        string PartName { get; }
        int HoursWorked { get; }
    }
}
