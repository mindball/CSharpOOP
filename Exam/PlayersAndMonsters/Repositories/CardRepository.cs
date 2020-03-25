

namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models.Cards.Contracts;    
    using Contracts;

    public class CardRepository : ICardRepository
    {
        private Dictionary<string, ICard> cards;

        public CardRepository()
        {
            this.cards = new Dictionary<string, ICard>();
        }

        public int Count => this.Cards.Count;

        public IReadOnlyCollection<ICard> Cards => 
            this.cards.Values.ToList().AsReadOnly();


        public void Add(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null!");
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
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null!");
            }

            return this.cards.Remove(card.Name);
        }
    }
}
