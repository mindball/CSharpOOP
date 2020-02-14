using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    class Cat : Animal
    {

        // - There shouldn’t be any virtual methods in constructors
        public Cat(string attackStrategy)
        {
            this.AtackStrategy = attackStrategy;
        }
        public override void Atack()
        {
            Console.WriteLine("Cat attack");
            Console.WriteLine(this.AtackStrategy);
        }
        //end of There shouldn’t be any virtual methods in constructors
        public override void Eat()
        {
            Console.WriteLine("qm");
        }

        public override void Jump()
        {
            Console.WriteLine("ska4am");
        }

        public override void Sleep()
        {
            Console.WriteLine("sleepvam");
        }
    }
}
