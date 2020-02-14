using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    private decimal money;
    private string name;
    public Product(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
    }
    
    public string Name
    {   get
        {
            return this.name;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
            }

            this.name = value;
        }
    }
    public decimal Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException($"{nameof(this.Money)} cannot be negative");

            this.money = value;
        }
    }

    public override string ToString()
    {
        return this.Name;
    }
}

