namespace MuOnline.Core.Commands
{
    using Contracts;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Monsters.Contracts;    
    using MuOnline.Repositories.Contracts;

    public class AddMonsterCommand : ICommand
    {
        private const string successfullMessage = "Successfully created monster: {0}";

        private readonly IRepository<IMonster> monsterRepository;
        private readonly IMonsterFactory monsterFactory;

        public AddMonsterCommand(IRepository<IMonster> monsterRepository,
            IMonsterFactory monsterFactory)
        {
            this.monsterRepository = monsterRepository;
            this.monsterFactory = monsterFactory;
        }

        public string Execute(string[] inputArgs)
        {
            var monsterType = inputArgs[0];
            var monster = this.monsterFactory.Create(monsterType);

            this.monsterRepository.Add(monster);

            return string.Format(successfullMessage, monster.GetType().Name);
        }
    }
}
