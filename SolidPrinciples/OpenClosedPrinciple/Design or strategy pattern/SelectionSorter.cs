using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern
{
    class SelectionSorter<T> : ISorterRightVersion<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> collection)
        {
            Console.WriteLine("Selection sort is tge best!!!");
            return collection;
        }
    }
    
}
