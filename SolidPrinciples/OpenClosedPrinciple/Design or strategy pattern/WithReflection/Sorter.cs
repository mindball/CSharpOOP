using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.WithReflection
{
    class Sorter
    {
        public Sorter(string type)
        {
            Type currentSorter =
            Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => typeof(ISorter).IsAssignableFrom(t)
            && t.IsClass && t.Name.ToLower().Contains(type))
            .FirstOrDefault();

            ISorter sorterStrategy = (ISorter)Activator.CreateInstance(currentSorter);
            sorterStrategy.Sort(new List<int>());
        }
        
    }
}
