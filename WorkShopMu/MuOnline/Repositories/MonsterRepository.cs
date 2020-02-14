
namespace MuOnline.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Repositories.Contracts;

    public class MonsterRepository : IRepository<IMonster>
    {
        private readonly List<IMonster> monsterRepository;

        public MonsterRepository()
        {
            this.monsterRepository = new List<IMonster>();
        }
        public IReadOnlyCollection<IMonster> Repository =>
            this.monsterRepository.AsReadOnly();

        public void Add(IMonster monster)
        {
            if (monster == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }

            this.monsterRepository.Add(monster);
        }

        public IMonster Get(string monster)
        {

            var targetMonster = this.monsterRepository
                .FirstOrDefault(x => x.GetType().Name == monster);

            if (targetMonster == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }

            return targetMonster;
        }

        public bool Remove(IMonster monster)
        {
            if (monster == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }

            bool isRemoveMonster = this.monsterRepository.Remove(monster);
            return isRemoveMonster;
        }
    }
}
