namespace MuOnline.Core.Commands
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Repositories.Contracts;

    class AttackMonsterCommand : ICommand
    {
        private const string commandMessage = "{0} is dead";
        private readonly IRepository<IHero> heroRepository;
        private readonly IRepository<IMonster> monsterRepository;

        public AttackMonsterCommand(IRepository<IHero> heroRepository, 
            IRepository<IMonster> monsterRepository)
        {
            this.heroRepository = heroRepository;
            this.monsterRepository = monsterRepository;
        }

        public string Execute(string[] inputArgs)
        {
            string heroUserName = inputArgs[0];
            string monsterName = inputArgs[1];

            var hero = this.heroRepository.Get(heroUserName);
            var monster = this.monsterRepository.Get(monsterName);

            var heroTotalPoints = hero.TotalAttackPoints;
            var monsterTotalPoints = monster.AttackPoints;            

            while(hero.IsAlive  && monster.IsAlive)
            {
                hero.TakeDamage(monsterTotalPoints);
                var experience = monster.TakeDamage(heroTotalPoints);
                ((IProgress)hero).AddExperience(experience);
            }
                       
            return string.Format(commandMessage, hero.IsAlive ? 
                monster.GetType().Name : heroUserName);
        }
    }
}
