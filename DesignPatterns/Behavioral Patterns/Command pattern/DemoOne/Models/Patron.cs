using DemoOne.Contracts;
using DemoOne.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Models
{
    /// <summary>
    /// The Invoker class
    /// </summary>
    public class Patron
    {
        private OrderCommand orderCommand;
        private MenuItem menuItem;
        private FastFoodOrder order;

        public Patron()
        {
            this.order = new FastFoodOrder();
        }

        public void SetCommand(int commandOption)
        {
            this.orderCommand = new CommandFactory().GetCommand(commandOption);
        }

        public void SetMenuItem(MenuItem item)
        {
            this.menuItem = item;
        }

        public void ExecuteCommand()
        {
            this.order.ExecuteCommand(this.orderCommand, menuItem);
        }

        public void ShowCurrentOrder()
        {
            this.order.ShowCurrenItems();
        }
    }
}
