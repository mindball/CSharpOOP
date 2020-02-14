﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    class MyRequiredAttribute : MyValidationAttribute
    {
        
        public override bool IsValid(object obj)
        {
            if (obj is null)
                return false;

            return true;
        }
    }
}
