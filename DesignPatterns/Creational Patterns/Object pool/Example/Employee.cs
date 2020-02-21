using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Employee
    {
        public Employee(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }

        public int Id {  get; private set; }

        public string Name { get; private set; }

        public string GetInfo()
        {
            return $"ID - {this.Id}, Name - {this.Name};";    
        }
    }
}
