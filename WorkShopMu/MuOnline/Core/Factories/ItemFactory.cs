namespace MuOnline.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using Models.Items.Contracts;

    public class ItemFactory : IItemFactory
    {
        public IItem Create(string itemType)
        {
            IItem item = null;
            var itemName = itemType.ToLower();

            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == itemName);

            if (type == null)
            {
                throw new ArgumentNullException("Invalid item type!");
            }

            try
            {
                item = (IItem)Activator.CreateInstance(type);                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

            return item;
        }
    }
}
