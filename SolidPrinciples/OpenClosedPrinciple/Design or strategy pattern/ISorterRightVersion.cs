using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public interface ISorterRightVersion<T>
    {
        //design pattern or strategy pattern
        IEnumerable<T> Sort(IEnumerable<T> collection);
    }
}
