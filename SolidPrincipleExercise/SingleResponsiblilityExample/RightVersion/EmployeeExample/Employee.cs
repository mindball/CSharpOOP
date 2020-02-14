using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblilityExample.RightVersion.EmployeeExample
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string email;
        public Employee(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
        private string FirstName { get; set; }
        private string LastName { get; set; }

        public string FullName => this.FirstName + " " + this.LastName;

        public string Email { get; set; }
    }
}
