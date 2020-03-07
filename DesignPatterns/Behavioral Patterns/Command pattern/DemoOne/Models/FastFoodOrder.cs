using System;
using System.Collections.Generic;

namespace DemoOne.Models
{
    public class FastFoodOrder
    {
        public FastFoodOrder()
        {
            this.currentItems = new List<MenuItem>();
        }

        public List<MenuItem> currentItems { get; set; }

        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(this.currentItems, item);
        }

        public void ShowCurrenItems()
        {
            foreach (var item in currentItems)
            {
                item.Display();
            }
            Console.WriteLine("-----------------------");
        }
    }
}
