using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class StartUp
    {
        static void Main(string[] args)
        {
            FluentEmployee empl = new FluentEmployee();

            Employee employeeBuilded = empl.NameOfEmployee("Mich")
                .AgeOfEmployee(29)
                .BornDateOfEmployee("01/05/1991")
                .AddressOfEmployee("Belgium")
                .Employee;
        }
    }
}
