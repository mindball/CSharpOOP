
namespace MuOnline.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Models.Monsters.Contracts;

    public class MonsterFactory : IMonsterFactory
    {
        public IMonster Create(string monsterType)
        {
            var monsterTypeName = monsterType.ToLower();            

            //TODO IsAssignableFrom ???
            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(IMonster).IsAssignableFrom(x))
                .FirstOrDefault(x => x.Name.ToLower() == monsterTypeName);

            if (type == null)
            {
                throw new ArgumentNullException("Invalid monster type!");
            }

            var monster = (IMonster)Activator.CreateInstance(type);

            return monster;
        }
    }
}
