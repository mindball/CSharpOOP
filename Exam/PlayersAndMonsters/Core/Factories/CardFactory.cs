namespace PlayersAndMonsters.Core.Factories
{

    using Core.Factories.Contracts;
    using Models.Cards.Contracts;
    using Models.Cards;

    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            ICard card = null;
            switch(type)
            {
                case "Magic":
                    card = new MagicCard(name);
                    break;
                case "Trap":
                    card = new TrapCard(name);
                    break;
            }

            return card;
        }
    }
}
