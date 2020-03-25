namespace PlayersAndMonsters
{

    using Core;
    using Core.Contracts;
    using Core.Factories;
    using Core.Factories.Contracts;
    using IO;
    using IO.Contracts;
    using Models.BattleFields;
    using Repositories;
    using Repositories.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            //IWriter writer = new FiliWriter(); - write into file

            ICardRepository cardRepository = new CardRepository();
            IPlayerRepository playerRepository = new PlayerRepository();
            IPlayerFactory createPlayer = new PlayerFactory();
            ICardFactory createCard = new CardFactory();
            BattleField battleField = new BattleField();

            IManagerController manager = new ManagerController(
                cardRepository,
                playerRepository,
                createPlayer,
                createCard,
                battleField);

            IEngine engine = new Engine(reader, writer, manager);
            engine.Run();
        }                                     
    }                                          
}