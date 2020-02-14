using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple.Example
{
    public class DerivedClass : BaseClass
    {
        //правилна имплементация 
        //public override string Type { get; set; }
        //public override int ID { get; set; }

            //неправилно
        //референцията към базовия тип да се реплейсват от наследяващия клас без това да
        // води до проблем ->тук е проблема че Тype and ID не се имплементирани,
        //може в случая да не ни трябват ако е така тогава DerivedClass не трябва да 
        //наследява BaseClass. В този случай крашваме базовия клас.
        //Или казано по друг начин базовия клас гърми ако ползва функционалност от 
        //наследяващият клас
        public override string Type => throw new NotFiniteNumberException();
        public override int ID => throw new NotFiniteNumberException();
    }
}
