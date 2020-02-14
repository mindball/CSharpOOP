using System.Collections.Generic;
using ExercisesWorkForce.Contracts;

namespace ExercisesWorkForce.Models
{
    public abstract class Employee : IEmployee
    {
        public Employee(string name, int hoursPerWeek)
        {
            this.Name = name;
            this.HoursPerWeek = hoursPerWeek;
        }
        public string Name { get; private set; }
        public int HoursPerWeek { get; private set; }
       
    }
}
