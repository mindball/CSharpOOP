using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern
{
    //Add new sort
    class NewSortBogo<T> : ISorterRightVersion<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> collection)
        {
            Console.WriteLine("Add new sort");
            return collection;
        }
    }
}
