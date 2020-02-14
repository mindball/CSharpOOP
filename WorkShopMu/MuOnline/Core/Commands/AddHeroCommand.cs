namespace MuOnline.Core.Commands
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Repositories.Contracts;

    public class AddHeroCommand : ICommand
    {
        private const string successfullMessage = "Successfully created hero {0}";
        private readonly IRepository<IHero> heroRepository;
        private readonly IHeroFactory heroFactory;

        public AddHeroCommand(IRepository<IHero> heroRepository, IHeroFactory heroFactory)
        {
            this.heroRepository = heroRepository;
            this.heroFactory = heroFactory;
        }

        public string Execute(string[] inputArgs)
        {
            var heroType = inputArgs[0];
            var heroUserName = inputArgs[1];

            var hero = this.heroFactory.Create(heroType, heroUserName);

            this.heroRepository.Add(hero);

            return string.Format(successfullMessage, heroUserName);

            /*var itemType = inputArgs[0].ToLower();

            var item = this.itemFactory.Create(itemType);

            this.itemRepository.Add(item);

            return $"Successfully created new {item.GetType().Name}!";
            **/
        }
    }
}
