using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
class Bag
{
    Dictionary<string, List<ItemType>> items = new Dictionary<string, List<ItemType>>();
    private readonly long capacity = 2000;
    private long current;
    private static long totalAmountOfGold = -1;

    public Bag(long capacity)
    {
        this.capacity = capacity;
    }

    public ItemType Item { get; set; }

    public int MyProperty { get; set; }

    public static long TotalAmountOfGems { get; set; }

    public static long TotalAmountOfCurrency { get; set; }

    public static long TotalAmountOfGold
    {
        get { return totalAmountOfGold; }
        private set { totalAmountOfGold = value; }
    }



    public void AddItem(string key, ItemType item)
    {
        if (capacity >= current + item.Quantity)
        {

            //The gold amount in your bag should always be more than or equal to the gem amount at any time
            if (items.ContainsKey(key))
            {
                //Gold is always count 1
                if (item is Gold)
                    items[key][0].IncreaseQuantity(item.Quantity);
                else
                    LookForSubItem(items[key], item);
            }
            //The gold amount in your bag should always be more than or equal to the gem amount at any time
            else if (item is Gold || CheckCondition(item))
            {
                //key=cash                
                AddNewKeyItem(key, item);
            }
        }

        current += item.Quantity;
    }

    private bool CheckCondition(ItemType item)
    {
        if(item is Gems && 
            TotalAmountOfGold >= item.Quantity + TotalAmountOfGems)
        {
            TotalAmountOfGems += item.Quantity;
            return true;
        }
        else if(item is Currency &&
            TotalAmountOfGems >= item.Quantity + TotalAmountOfCurrency)
        {
            TotalAmountOfCurrency += item.Quantity;
            return true;
        }
        else
        {
            return false;
        }
    }

    private void LookForSubItem(List<ItemType> list, ItemType item)
    {
        foreach (var subItem in list.ToList())
        {
            if (item.Name.Equals(subItem.Name))
            {
                subItem.IncreaseQuantity(item.Quantity);
                break;
            }
            else
            {
                list.Add(item);
                break;
            }
        }
    }

    private void AddNewKeyItem(string key, ItemType item)
    {
        items.Add(key, new List<ItemType>());
        items[key].Add(item);

        IncreaseTotalAmount(item);
    }

    private void IncreaseTotalAmount(ItemType item)
    {
        if (item is Gems) TotalAmountOfGems += item.Quantity;
        else if (item is Currency) TotalAmountOfCurrency += item.Quantity;
        else TotalAmountOfGold += item.Quantity;
    }


}

