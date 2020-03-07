using System.Collections.Generic;
using System.Linq;

namespace DemoOne.Models
{
    public class ModifyCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> orders, MenuItem newItem)
        {
            var item = orders.Where(x => x.Name == newItem.Name).First();
            item.Price = newItem.Price;
            item.Amount = newItem.Amount;
        }
    }
}
