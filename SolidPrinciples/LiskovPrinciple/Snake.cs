using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    class Snake : Animal
    {
        
        public override void Eat()
        {
            Console.WriteLine("eat");
        }


        //Тук има проблем с този метод, макар че да приемем че абстракният ни клас
        //е със съвършенна абстракция 
        //може също така да го оставим not implemented
        public override void Jump()
        {
           
        }

        
        public override void Sleep()
        {
            Console.WriteLine("never sleep");
        }
    }
}
