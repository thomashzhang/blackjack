using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game
    {
        private Deck deck;
        public List<Card> playerCards;
        private List<Card> dealerCards;
        public Game(Deck deck)
        {
            this.deck = deck;
            playerCards = deck.GetCard(2);
            dealerCards = new List<Card>();
            dealerCards.Add(deck.GetCard());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>True if Win, False if Lose</returns>
        public bool Stand()
        {
            // TODO: fix naive dealer strategy
            while (handValue(dealerCards) < handValue(playerCards))
            {
                var dealerBust = Hit(dealerCards);
                if (dealerBust)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Hit(List<Card> cards)
        {
            cards.Add(deck.GetCard());
            if (isBust(cards))
            {
                return true;
            }

            return false;
        }

        private bool isBust(List<Card> cards)
        {
            return cards.Sum(card => card.Value) > 21;
        }

        private int handValue(List<Card> cards)
        {
            return cards.Sum(card => card.Value > 10 ? 10 : card.Value);
            // TODO: Handle ace
        }
    }
}
