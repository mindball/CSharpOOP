using System;

namespace OpenClosedPrinciple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Rely on abstraction, not implementation example:
            //
        }
    }

    class BasicClass
    {
        void Method()
        {
            //Нарушаване на Open/Closed принципа
            //Code smell
            //Taзи ф-ност не трябва да е в базовия клас
            if(this is ChildOneOfBasic)
            {
            }
            else if (this is ChildTwoOfBasic)
            {

            }
        }
           
    }

    class ChildOneOfBasic : BasicClass
    {
        
    }

    class ChildTwoOfBasic : BasicClass
    {

    }


}

