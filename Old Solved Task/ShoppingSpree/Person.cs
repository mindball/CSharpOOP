using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    private decimal money;
    private string name;
    private List<Product> products;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        products = new List<Product>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
            }

            this.name = value;
        }
    }

    public List<Product> BagOfProduct
    {
        get
        {
            return this.products;
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

    public void AddToBag(Product newProduct)
    {
        if(newProduct.Money > this.Money)
        {
            throw new InvalidOperationException(
                $"{this.Name} can't afford {newProduct.Name}"
                );
        }

        this.products.Add(newProduct);
        this.Money -= newProduct.Money; 
    }

    public override string ToString()
    {
        string listOfProducts = string.Join(", ", this.BagOfProduct);
        if (string.IsNullOrEmpty(listOfProducts))
            listOfProducts = "Nothing bought";

        string result = $"{this.Name} - {listOfProducts}";
        return result;
    }
}



