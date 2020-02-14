
namespace MuOnline.Core.Commands
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Models.Items.Contracts;
    using MuOnline.Repositories.Contracts;

    public class AddItemToHeroCommand : ICommand
    {
        private const string successfullyMessage = "Successfully added item {0} to hero {1}";
        private readonly IRepository<IHero> heroRepository;
        private readonly IRepository<IItem> itemRepository;
        

        public AddItemToHeroCommand(IRepository<IHero> heroRepository,
            IRepository<IItem> itemRepository)
        {
            this.heroRepository = heroRepository;
            this.itemRepository = itemRepository;
        }

        public string Execute(string[] inputArgs)
        {
            string heroUserName = inputArgs[0];
            string itemName = inputArgs[1];

            var hero = this.heroRepository.Get(heroUserName);
            var item = this.itemRepository.Get(itemName);

            hero.Inventory.AddItem(item);

            return string.Format(successfullyMessage, item.GetType().Name, heroUserName);
        }
    }
}
