using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblilityExample.RightVersion.WorkReport.Contracts
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);
        void RemoveEntryAt(int index);
    }
}
