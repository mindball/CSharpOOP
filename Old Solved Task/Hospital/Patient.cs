using System;
using System.Collections.Generic;
using System.Linq;

class Patient
{
    private string name;
    public Patient(string name)
    {
        this.Name = name;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if(value.Length > 1 && value.Length <= 20)
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentException("First name len is less 1 or > 20");
            }
        }
    }
}

