using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblilityExample.RightVersion.EmployeeExample.EmployeeServices
{
    public class EmployeeService
    {
        //след като сме разделили ф-стта, тук могат да се добавят различни операции
        public void RegistrationEmployee(Employee employee)
        {
            EmailService email = new EmailService();
            email.SendingEmail(employee.FullName, employee.Email);
        }

        //и тук лесно могат да се разширят ф-стите като се добавят нови.

    }
}
