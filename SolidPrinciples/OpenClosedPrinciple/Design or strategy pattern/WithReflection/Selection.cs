using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.WithReflection
{
    public class Selection : ISorter
    {
        public IEnumerable<int> Sort(IEnumerable<int> collection)
        {
            Console.WriteLine("Selection sort is tge best!!!");
            return collection;
        }
    }
}
