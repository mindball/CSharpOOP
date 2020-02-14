using System;
using System.Collections.Generic;
using System.Text;

namespace SystemSplit.Contracts
{
    public interface IComponentHardware : IComponent
    {
        string Name { get; }

        string TypeOfHardware { get; }
        int MaxCapacity
        {
            get;
            set;
        }

        int MaxMemory
        {
            get;
            set;
        }

        IList<IComponentSoftware> SoftwareComponets { get; }

        void AddSoftwareComponent(IComponentSoftware softwareComponent);

    }
}
