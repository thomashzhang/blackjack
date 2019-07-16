using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class BlackJack
    {
        static void Main(string[] args)
        {
            var game = new Game(new Deck());
            while (true)
            {
                Console.WriteLine("Hello");
                string cards = string.Empty;
                foreach (Card card in game.playerCards)
                {
                    cards += "[" + card.ToString() + "] ";
                }
                Console.WriteLine("Your cards are: " + cards);
                Console.WriteLine("Select either 'hit' or 'stand'");
                var input = Console.ReadLine();
                if (input == "hit")
                {
                    bool result = game.Hit(game.playerCards);
                    if (!result)
                    {
                        Console.WriteLine("You busted, and thus you suck. GG");
                        break;
                    }
                }
                else if (input == "stand")
                {
                    bool result = game.Stand();
                    if (result)
                    {
                        Console.WriteLine("You actually won. Wow, I guess you're not bad.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Well, the dealer busted. GG");
                        break;
                    }
                }
            }
            while (true)
            {
                System.Console.ReadKey();
            };
        }
    }
}
