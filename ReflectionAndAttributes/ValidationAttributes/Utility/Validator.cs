using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Entity;

namespace ValidationAttributes.Utility
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {

            PropertyInfo[] properties = obj.GetType().GetProperties();
            object[] attrs;

            foreach (var property in properties)
            {
                attrs = property.GetCustomAttributes(true);
                var value = property.GetValue(obj);

                if (attrs.Length > 0)
                {
                    foreach (var atr in attrs)
                    {
                        var myAtt = atr as MyValidationAttribute;
                        if (myAtt != null)
                        {
                            if (!myAtt.IsValid(value))
                            {
                                return false;
                            }
                        }                       
                    }
                }
            }

            return true;
        }
    }
}
