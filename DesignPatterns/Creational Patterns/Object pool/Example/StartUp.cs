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
            EmployeePool newPool = new EmployeePool();
            var employeesExampleOne = newPool.getEmployee();
            var employeesExampleTwo = newPool.getEmployee();

            //Console.WriteLine(employeesExampleOne.GetInfo());
            //Console.WriteLine(employeesExampleTwo.GetInfo());

            newPool.getOccupiedEmployees().ForEach(x => Console.WriteLine(x.GetInfo()));
            newPool.getFreeEmployees().ForEach(x => Console.WriteLine(x.GetInfo()));

        }
    }
}
