namespace PlayersAndMonsters.Core.Factories
{
    using System;

    using Core.Factories.Contracts;
    using Models.Cards.Contracts;
    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            throw new NotImplementedException();
        }
    }
}
