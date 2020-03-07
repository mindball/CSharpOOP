using DemoOne.Contracts;
using System.Collections.Generic;

namespace DemoOne.Models
{
    /// <summary>
    /// The Command abstract class
    /// </summary>
    public abstract class OrderCommand : IOrderCommand
    {
        public abstract void Execute(List<MenuItem> orders, MenuItem newItem);
    }
}
