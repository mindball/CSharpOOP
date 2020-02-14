namespace MuOnline
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    using Core;
    using Core.Contracts;
    using MuOnline.Repositories.Contracts;
    using MuOnline.Repositories;
    using MuOnline.Models.Heroes.HeroContracts;
    using MuOnline.Models.Monsters.Contracts;
    using MuOnline.Models.Items.Contracts;
    using MuOnline.Core.Factories.Contracts;
    using MuOnline.Core.Factories;    
    using MuOnline.Utilities.Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();
            IEngine engine = new Engine(serviceProvider);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IItemFactory, ItemFactory>();
            serviceCollection.AddTransient<IMonsterFactory, MonsterFactory>();
            serviceCollection.AddTransient<IHeroFactory, HeroFactory>();

            //serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();
            serviceCollection.AddTransient<ICommandInterpreter>(
                s =>  new CommandInterpreter("test"));


            serviceCollection.AddSingleton<IRepository<IHero>, HeroRepository>();
            serviceCollection.AddSingleton<IRepository<IMonster>, MonsterRepository>();
            serviceCollection.AddSingleton<IRepository<IItem>, ItemRepository>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
