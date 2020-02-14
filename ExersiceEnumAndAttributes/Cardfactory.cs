using System;

namespace ExersiceEnumAndAttribute
{
    class CardFactory 
    {
        public Card CreateCard(string newSuit, string newRank)
        {
            
            
            NewRank rank;
            NewSuit suit;
            if (!Enum.TryParse(newSuit, out suit) ||
                !Enum.TryParse(newRank, out rank))
            {
                throw new CardExistsException();
            }
            
            return new Card(suit, rank);
            

            
        }
    }
}
