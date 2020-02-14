using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExersiceEnumAndAttribute
{
    public class Player
    {
        private IList<Card> cards;
        private Card winningCard;

        public Player(string name)
        {
            this.Name = name;
            cards = new List<Card>();
        }
        public string Name { get; set; }

        public Card WinningCard  { get => this.winningCard; }

        public void AddCard(Card newCard)
        {
            if(this.cards.Any(x => x.Suit == newCard.Suit &&
                      x.Rank == newCard.Rank))
            {
                throw new CardNotDeckException();
            }

            this.cards.Add(newCard);

            if (this.winningCard is null 
                || this.winningCard.CardPower < newCard.CardPower)
                this.winningCard = newCard;
        }

        public override string ToString()
        {
            return $"{this.Name} wins with {this.WinningCard.Rank} of {this.WinningCard.Suit}"; 
        }
    }
}
