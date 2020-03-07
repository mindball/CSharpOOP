using System.Collections.Generic;

namespace DemoOne.Models
{
    public class AddCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> orders, MenuItem newItem)
        {
            orders.Add(newItem);
        }
    }
}
