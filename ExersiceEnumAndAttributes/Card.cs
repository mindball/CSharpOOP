using System;
using System.Collections.Generic;
using System.Text;

namespace ExersiceEnumAndAttribute
{
    public class Card : IComparable<Card>
    {
        public Card(NewSuit suit, NewRank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public NewSuit Suit { get; private set; }
        public NewRank Rank { get; private set; }

        public int CardPower => (int)this.Suit + (int)this.Rank;

        public int CompareTo(Card other)
        {
            return this.CardPower.CompareTo(other.CardPower);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Card name: {this.Rank} of {this.Suit};" +
                $"Card power: {this.CardPower.ToString()}");
               
            return str.ToString().TrimEnd();
        }

    }
}
