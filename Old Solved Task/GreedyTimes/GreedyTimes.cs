using System;
using System.Collections.Generic;
using System.Linq;

class GreedyTimes
{
   
    static void Main(string[] args)
    {
        long capacity = long.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        Bag n = new Bag(capacity);

        for (int i = 0; i < input.Length; i += 2)
        {
            string key = input[i];
            long value = long.Parse(input[i + 1]);
            InsertItem(key, value, n);
        }

    }

    private static void InsertItem(string key, long value, Bag bag)
    {
        if (key.Length == 3)
        {
            Currency cash = new Currency(key, value);
            bag.AddItem("cash", cash);
        }
        else if (key.Length >= 4 && key.ToLower().EndsWith("gem"))
        {
            Gems gem = new Gems(key, value);
            bag.AddItem("Gem", gem);
        }
        else if (key.ToLower().Equals("gold"))
        {
            Gold gold = new Gold(key, value);
            bag.AddItem("Gold", gold);
        }
    }
}

