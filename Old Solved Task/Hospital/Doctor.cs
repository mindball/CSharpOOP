using System;
using System.Collections.Generic;
using System.Linq;

class Doctor
{
    private string fName;
    private string lName;
    public Doctor(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    public string FirstName
    {
        get
        {
            return this.fName;
        }
        set
        {
            if(value.Length > 1 && value.Length <= 20)
            {
                this.fName = value;
            }
            else
            {
                throw new ArgumentException("First name len is less 1 or > 20");
            }
        }
    }

    public string LastName
    {
        get
        {
            return this.lName;
        }
        set
        {
            if (value.Length > 1 && value.Length <= 20)
            {
                this.lName = value;
            }
            else
            {
                throw new ArgumentException("Last name len is less 1 or > 20");
            }
        }
    }
}


