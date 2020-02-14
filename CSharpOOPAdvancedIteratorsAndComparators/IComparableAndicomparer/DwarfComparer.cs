using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IComparableAndicomparer
{
    public class DwarfComparer : IComparer<Dwarf>
    {
       
        public int Compare(Dwarf x, Dwarf y)
        {
            return x.id - y.id;
        }
    }
}
