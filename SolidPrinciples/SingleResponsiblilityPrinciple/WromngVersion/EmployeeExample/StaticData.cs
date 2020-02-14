using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblilityExample.WromngVersion.EmployeeExample
{ 
    class StaticData
    {
        public static List<EmployeeService> Employees { get; set; } = new List<EmployeeService>();
    }
}
