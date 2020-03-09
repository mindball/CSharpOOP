﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTemplateMethod
{
    public abstract class Bread
    {
        public abstract void MixIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Slicing the " + this.GetType().Name + " bread!");
        }

        public void Make()
        {
            this.MixIngredients();
            this.Bake();
            this.Slice();
        }


    }
}
