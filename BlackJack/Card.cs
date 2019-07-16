using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum CardType { Spade, Jack, Heart, Diamond}

    public class Card
    {
        public CardType Type { get; }
        public int Value { get; }

        public Card(int value, CardType type)
        {
            Value = value;
            Type = type;
        }

        public override string ToString()
        {
            return $"Value: {Value}, Type: {Type}";
        }
    }
}
