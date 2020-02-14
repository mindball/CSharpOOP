using System;
using System.Collections.Generic;
using System.Text;

namespace IComparableAndicomparer
{
    class Employee : IComparable<Employee>
    {
        public int Salary { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            // Alphabetic sort if salary is equal. [A to Z]
            if (this.Salary == other.Salary)
            {
                return this.Name.CompareTo(other.Name);
            }
            // Default to salary sort. [High to low]
            return other.Salary.CompareTo(this.Salary);
        }

        public override string ToString()
        {
            // String representation.
            return this.Salary.ToString() + "," + this.Name;
        }
    }
}
