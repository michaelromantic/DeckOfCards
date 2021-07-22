using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
