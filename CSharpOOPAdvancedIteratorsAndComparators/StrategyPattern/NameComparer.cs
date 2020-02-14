using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {

            int result = x.Name.Length - y.Name.Length;
            if(result == 0)
            {
                string firstLetterOfXName = x.Name[0].ToString().ToLower();
                string firstLetterOfYName = y.Name[0].ToString().ToLower();

                result = firstLetterOfXName.CompareTo(firstLetterOfYName);
            }

            return result;
        }
    }
}
