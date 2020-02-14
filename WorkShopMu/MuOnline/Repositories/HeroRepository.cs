
namespace MuOnline.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Repositories.Contracts;

    public class HeroRepository : IRepository<IHero>
    {
        private readonly List<IHero> heroRepository;

        public HeroRepository()
        {
            this.heroRepository = new List<IHero>();
        }

        public IReadOnlyCollection<IHero> Repository => this.heroRepository.AsReadOnly();

        public void Add(IHero hero)
        {
            if (hero == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }

            this.heroRepository.Add(hero);
        }

        public IHero Get(string hero)
        {
            var targetItem = this.heroRepository
                .FirstOrDefault(x => ((IIdentifiable)x).Username == hero);

            if (targetItem == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }

            return targetItem;
        }

        public bool Remove(IHero hero)
        {
            if (hero == null)
            {
                throw new ArgumentNullException("Item cannot be null!");
            }

            bool isRemoveItem = this.heroRepository.Remove(hero);
            return isRemoveItem;
        }
    }
}
