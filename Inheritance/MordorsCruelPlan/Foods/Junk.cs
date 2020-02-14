using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Foods
{
    class Junk : Food
    {
        private const int happiness = -1;
        public Junk() 
            : base(happiness)
        {
        }
    }
}
