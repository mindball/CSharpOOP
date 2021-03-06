﻿using System;
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
            newPool.Release(employeesExampleTwo);

            Console.WriteLine(employeesExampleOne.GetInfo());
            Console.WriteLine(employeesExampleTwo.GetInfo());

            newPool.getOccupiedEmployees()
                .ForEach(
                x => Console.WriteLine($"List of occupied employees: {x.Name}"));

            newPool.getFreeEmployees()
                .ForEach(
                x => Console.WriteLine($"List of free employees: {x.Name}"));

        }
    }
}
