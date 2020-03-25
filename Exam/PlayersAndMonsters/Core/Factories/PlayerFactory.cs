namespace PlayersAndMonsters.Core.Factories
{
    
    using Core.Factories.Contracts;
    using Models.Players.Contracts;
    using Models.Players;
    using Repositories;

    class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            IPlayer player = null;
            switch (type)
            {
                case "Beginner":
                    player = new Beginner(new CardRepository(), username);
                    break;
                case "Advanced":
                    player = new Advanced(new CardRepository(), username);
                    break;
            }

            return player;
        }
    }
}
