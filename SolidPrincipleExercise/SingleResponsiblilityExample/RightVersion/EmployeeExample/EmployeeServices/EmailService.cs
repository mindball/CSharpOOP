using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblilityExample.RightVersion.EmployeeExample.EmployeeServices
{
    public class EmailService
    {
        public void SendingEmail(string newEmployeeName, string employeeEmail)
        {
            //Sending...
            Console.WriteLine($"Email:{employeeEmail} FullName:{newEmployeeName}");
        }

       
    }
}
