namespace PlayersAndMonsters.Core.Factories
{
    using System;

    using Core.Factories.Contracts;
    using Models.Players.Contracts;
    class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            throw new NotImplementedException();
        }
    }
}
