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
                Console.WriteLine("Welcome to the game.");
                Console.WriteLine("Your cards are: " + game.playerCards.ToString());
                var input = Console.ReadLine();
            }
        }
    }
}
