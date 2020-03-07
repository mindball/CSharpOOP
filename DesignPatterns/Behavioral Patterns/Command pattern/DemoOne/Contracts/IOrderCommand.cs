using DemoOne.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Contracts
{
    public interface IOrderCommand
    {
        void Execute(List<MenuItem> orders, MenuItem newItem);
    }
}
