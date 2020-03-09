using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTemplateMethod
{
    public class TwelveGrain : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Gathering Ingredients for 12-Grain Bread.");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Baking the 12-Grain Bread. (25 minutes)"); 
        }
    }
}
