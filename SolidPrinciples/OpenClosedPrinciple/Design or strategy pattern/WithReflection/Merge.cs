using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.WithReflection
{
    public class Merge : ISorter
    {
        public IEnumerable<int> Sort(IEnumerable<int> collection)
        {
            Console.WriteLine("Merge sort is the worst!!");
            return collection;
        }
    }
}
