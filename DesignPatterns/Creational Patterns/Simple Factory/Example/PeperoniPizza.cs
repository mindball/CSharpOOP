using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class PeperoniPizza : Pizza
    {
        private const string name = "Piperoni";
        private const string souce = "Piperoni souce";
        private const string dough = "Piperoni dough";

        public PeperoniPizza()
            : base(name, souce, dough)
        {
        }


        public override void Prepare()
        {
            //Make PeproniPiza
        }
    }
}
