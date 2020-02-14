using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.WithReflection
{
    public interface ISorter
    {
        IEnumerable<int> Sort(IEnumerable<int> collection);
    }
}
