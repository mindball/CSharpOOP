using System;
using System.Collections.Generic;
using ExceptionNotFoundVisitorPattern.Contracts;

namespace ExceptionNotFoundVisitorPattern.Models
{
    public class Employees
    {
        private List<Employee> employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
