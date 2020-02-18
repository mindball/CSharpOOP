using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample
{
    public class CheesePizza : Pizza
    {
        private const string name = "Cheese";
        private const string souce = "Cheese souce";
        private const string dough = "Cheese dough";

        public CheesePizza()
            : base(name, souce, dough)
        {
        }

        public override void Prepare()
        {
            //Make CheesePizza
        }
    }
}
