using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple.Example
{
    public abstract class BaseClass
    {

        //
        public BaseClass()
        {
            //Some logic
        }
        //референцията към базовия тип да се реплейсват от наследяващия клас без това да
        // води до проблем
        public abstract string Type { get; set; }

        public abstract int ID { get; set; }

        public override string ToString()
        {
            return $"{Type} {ID}";
        }
    }
}
