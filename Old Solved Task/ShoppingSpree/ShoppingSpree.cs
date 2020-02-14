using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingSpree
{
    static void Main()
    {
        Dictionary<string, Person> people = new Dictionary<string, Person>();
        Dictionary<string, Product> product = new Dictionary<string, Product>();
        string line = Console.ReadLine();
        string[] tokens = line.Split(new string[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries);
        if (!AddEntity(tokens, people))
            return;

        line = Console.ReadLine();
        tokens = line.Split(new string[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries);
        if (!AddEntity(tokens, product))
            return;

        while (true)
        {
            string command = Console.ReadLine();
            if (command.Equals("END"))
                break;

            tokens = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string nameOfPeople = tokens[0];
            string nameOfProducts = tokens[1];

            Person currentPeople;
            Product currentProduct;
            try
            {
                if (people.TryGetValue(nameOfPeople, out currentPeople) &&
                product.TryGetValue(nameOfProducts, out currentProduct))
                {
                    currentPeople.AddToBag(currentProduct);
                    Console.WriteLine($"{nameOfPeople} bought {nameOfProducts}");
                }
                else
                {
                    return;
                }
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);               
            }            
        }

        foreach (var p in people.Values)
        {
            Console.WriteLine(p);
        }
    }

    public static bool AddEntity<T>(string[] s, Dictionary<string, T> t)
    {
        string name;
        decimal money;
        for (int i = 0; i < s.Length; i += 2)
        {
            try
            {
                name = s[i];
                money = decimal.Parse(s[i + 1]);

                T item = (T)Activator.CreateInstance(typeof(T),
                    new object[]
                    {
                        name,
                        money
                    }
                    );

                t.Add(name, item);
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.InnerException.Message);
                return false;
            }
        }
        return true;

    }


}

