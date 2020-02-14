using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblilityExample.WromngVersion.EmployeeExample
{
    class EmployeeService
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //тук трябва да разделим функционалността
        public void EmployeeRegistration(EmployeeService employee)
        {
            //some logic here to registration...
            
        }

        public void SendEmail()
        {
            //SendEmal(); 
        }
    }
}
