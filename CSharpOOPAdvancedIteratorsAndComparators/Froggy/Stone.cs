using System;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    class Stone
    {
        public Stone(int number)
        {
            this.Number = number;
        }
        public int Number { get;}

        public override string ToString()
        {
            return Number.ToString();
        }

    }
}
