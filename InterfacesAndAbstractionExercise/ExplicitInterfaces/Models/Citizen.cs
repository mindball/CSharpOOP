using ExplicitInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Models
{
    public class Citizen : IResindent, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }
        public string Name { get; }
        public string Country { get; }
        public int Age { get; }

        public string GetName()
        {
            return this.Name;
        }

        string IResindent.GetName()
        {
            return "Mr/Ms/Mrs " + this.Name;
        }
    }
}
