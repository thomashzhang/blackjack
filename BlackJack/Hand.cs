using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        private Deck deck;
        private List<Card> playerCards;
        private List<Card> dealerCards;
        public Hand()
        {
            deck = new Deck();
            playerCards = deck.GetCard(2);
            dealerCards = new List<Card>();
            dealerCards.Add(deck.GetCard());
        }
    }
}
