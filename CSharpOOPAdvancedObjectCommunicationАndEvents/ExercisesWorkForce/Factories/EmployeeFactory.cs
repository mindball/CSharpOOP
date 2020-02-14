using ExercisesWorkForce.Contracts;
using ExercisesWorkForce.Models;

namespace ExercisesWorkForce.Factories
{
    class EmployeeFactory
    {
        public IEmployee CreateEmployee(string type, string name)
        {
            Employee employee = null;

            switch(type)
            {
                case "PartTimeEmployee":
                    employee = new PartTimeEmployee(name);
                    break;
                case "StandardEmployee":
                    employee = new StandardEmployee(name); 
                    break;                
            }

            return employee;
        }
    }
}
