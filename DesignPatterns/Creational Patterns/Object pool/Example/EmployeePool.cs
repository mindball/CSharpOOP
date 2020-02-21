using System;
using System.Collections.Generic;

namespace Example
{
    class EmployeePool
    {
        private Dictionary<int, Employee> occupiedEmployees;
        private Stack<Employee> freeEmployees;
        private string[] names = { "William", "Chris", "Elsa", "Jane", "Bob", "Mincho", "Ivan",  };
        private Random generator = new Random();

        public EmployeePool()
        {
            this.occupiedEmployees = new Dictionary<int, Employee>();
            this.freeEmployees = new Stack<Employee>();
        }

        public Employee getEmployee()
        {
            Employee employee = null;
            int id;
            if (this.freeEmployees.Count == 0)
            {
               id = this.occupiedEmployees.Count + this.freeEmployees.Count + 1;

                string randomName = names[generator.Next(0, names.Length - 1)];
                employee = new Employee(id, randomName);
            }
            else
            {
                employee = freeEmployees.Pop();
            }

            this.occupiedEmployees[employee.Id] = employee;
            return employee;
        }

        public void Release(Employee employee)
        {
            int id = employee.Id;

            if (this.occupiedEmployees.ContainsKey(id))
            {
                this.occupiedEmployees.Remove(id);
                this.freeEmployees.Push(employee);
            }
        }

        public List<Employee> getOccupiedEmployees()
        {
            List<Employee> occupiedEmployee = new List<Employee>();

            if (this.occupiedEmployees.Count > 0)
            {
                foreach (var employee in this.occupiedEmployees.Values)
                {
                    occupiedEmployee.Add(employee);
                }
            }

            return occupiedEmployee;
        }

        public List<Employee> getFreeEmployees()
        {
            List<Employee> freeEmployee = new List<Employee>();

            if (this.freeEmployees.Count > 0)
            {
                foreach (var employee in this.freeEmployees)
                {
                    freeEmployee.Add(employee);
                }
            }

            return freeEmployee;
        }
    }
}
