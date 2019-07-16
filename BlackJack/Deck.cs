using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> cards;
        public Deck()
        {
            ResetDeck();
        }

        public Card GetCard()
        {
            int nextRandomCard = (new Random()).Next(cards.Count);
            var returnedCard = cards[nextRandomCard];
            cards.Remove(returnedCard);
            return returnedCard;
        }
        public List<Card> GetCard(int count)
        {
            var cards = new List<Card>();
            for (int i = 0; i < count; i++)
            {
                cards.Add(GetCard());
            }

            return cards;
        }


        public void ResetDeck()
        {
            cards = new List<Card>();
            foreach (CardType card in new CardType[] { CardType.Diamond, CardType.Spade, CardType.Heart, CardType.Jack })
            {
                for (int i = 1; i <= 13; i++)
                {
                    cards.Add(new Card(i, card));
                }
            }
        }
    }
}
