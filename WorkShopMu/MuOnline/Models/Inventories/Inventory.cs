namespace MuOnline.Models.Inventories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Items.Contracts;
    using Contracts;

    public class Inventory : IInventory
    {
        private readonly List<IItem> items;

        public Inventory()
        {
            this.items = new List<IItem>();
        }

        //TODO diff from cast (IReadOnlyCollection<IItem>)this.items vs this.items.AsReadOnly()        
        public IReadOnlyCollection<IItem> Items => this.items.AsReadOnly();

        public void AddItem(IItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The item cannot be null!");
            }

            this.items.Add(item);
        }

        public bool RemoveItem(IItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The item cannot be null!");
            }

            var isRemove = this.items.Remove(item);
            return isRemove;
        }

        public IItem GetItem(string item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The item cannot be null!");
            }

            //TODO if item name is half i.GetType().Name.Contains(item)
            var targetItem = this.items.FirstOrDefault(i => i.GetType().Name == item);

            return targetItem;
        }
    }
}
