

namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PlayersAndMonsters.Models.Cards.Contracts;    
    using PlayersAndMonsters.Repositories.Contracts;

    class CardRepository : ICardRepository
    {
        private Dictionary<string, ICard> cards;

        public CardRepository()
        {
            this.cards = new Dictionary<string, ICard>();
        }

        public int Count => this.cards.Count;

        public IReadOnlyCollection<ICard> Cards => 
            this.cards.Values.ToList().AsReadOnly();


        public void Add(ICard card)
        {
            if (card is null)
            {
                throw new ArgumentException("Card cannot be null");
            }

            if (this.cards.ContainsKey(card.Name))
            {
                new ArgumentException($"Card {card.Name} already exists!");
            }

            this.cards.Add(card.Name, card);
        }
      

        public ICard Find(string name)
        {
            ICard card;
            if (!this.cards.TryGetValue(name, out card))
                return null;

            return card;
        }

        public bool Remove(ICard card)
        {
            return this.cards.Remove(card.Name);
        }
    }
}
