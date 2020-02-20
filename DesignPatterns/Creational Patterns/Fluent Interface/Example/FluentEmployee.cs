using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class FluentEmployee
    {
        private Employee employee = new Employee();

        public Employee Employee => this.employee;

        public FluentEmployee NameOfEmployee(string FullName)
        {
            this.employee.FullName = FullName;
            return this;
        }

        public FluentEmployee AgeOfEmployee(int age)
        {
            this.employee.Age = age;
            return this;
        }

        public FluentEmployee BornDateOfEmployee(string dateOfBorn)
        {
            this.employee.BornDate = Convert.ToDateTime(dateOfBorn);
            return this;
        }

        public FluentEmployee AddressOfEmployee(string address)
        {
            this.employee.Address = address;
            return this;
        }

       
    }
}
