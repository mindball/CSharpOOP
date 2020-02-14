using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern
{
    class MergeSorter<T> : ISorterRightVersion<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> collection)
        {
            Console.WriteLine("Merge sort is the worst!!");
            return collection;
        }
    }
}
