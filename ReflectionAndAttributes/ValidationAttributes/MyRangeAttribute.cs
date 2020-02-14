using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    class MyRangeAttribute : MyValidationAttribute
    {
        private  int minValue;//= Int32.MinValue;
        private  int maxValue; //= Int32.MaxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            var value = Convert.ToInt32(obj);

            if (value < minValue || value > maxValue)
                return false;

            return true;
        }
    }
}
