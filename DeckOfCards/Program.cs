using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            string[] Suits = new string[] { "CLUBS", "SPADES", "HEARTS", "DIAMONDS" };
            string[] Ranks = new string[] { "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "JACK", "QUEEN", "KING", "ACE" };

            foreach (string name in Suits)
            {
                foreach (string number in Ranks)
                {
                    Card card = new Card(name, number);
                    cards.Add(card);
                }
            }

            bool keepPlaying = true;

            while(keepPlaying == true)
            {
                Console.WriteLine("DECK OF CARDS CONSOLE APP");
                Console.WriteLine("\n1. Get the total number of cards in the deck.");
                Console.WriteLine("2. Shuffle the deck.");
                Console.WriteLine("3. Sort the deck by rank.");
                Console.WriteLine("4. Sort the deck by suit then by rank.");
                Console.WriteLine("5. Close app.");

                string userChoice = Console.ReadLine();

                switch (userChoice) {
                    case "1":
                        Console.WriteLine("\nTotal Number of Cards:");
                        Console.WriteLine(cards.Count);
                        break;

                    case "2":
                        var rnd = new Random();
                        var randomized = cards.OrderBy(item => rnd.Next());

                        foreach (var card in randomized)
                        {
                            Console.WriteLine($"{card.Rank} of {card.Suit}");
                        }

                        break;

                    case "3":
                        var ranked = cards.OrderBy(item => item.Rank == "ACE").ThenBy(item => item.Rank == "KING").ThenBy(item => item.Rank == "QUEEN").ThenBy(item => item.Rank == "JACK").ThenBy(item => item.Rank == "TEN").ThenBy(item => item.Rank == "NINE").ThenBy(item => item.Rank == "EIGHT").ThenBy(item => item.Rank == "SEVEN").ThenBy(item => item.Rank == "SIX").ThenBy(item => item.Rank == "FIVE").ThenBy(item => item.Rank == "FOUR").ThenBy(item => item.Rank == "THREE").ThenBy(item => item.Rank == "TWO");

                        foreach (Card card in ranked)
                        {
                            Console.WriteLine($"{card.Rank} of {card.Suit}");
                        }
                        break;

                    case "4":
                        var suitRank = cards.OrderBy(item => item.Suit).ThenBy(item => item.Rank == "ACE").ThenBy(item => item.Rank == "KING").ThenBy(item => item.Rank == "QUEEN").ThenBy(item => item.Rank == "JACK").ThenBy(item => item.Rank == "TEN").ThenBy(item => item.Rank == "NINE").ThenBy(item => item.Rank == "EIGHT").ThenBy(item => item.Rank == "SEVEN").ThenBy(item => item.Rank == "SIX").ThenBy(item => item.Rank == "FIVE").ThenBy(item => item.Rank == "FOUR").ThenBy(item => item.Rank == "THREE").ThenBy(item => item.Rank == "TWO");

                        foreach (Card card in suitRank)
                        {
                            Console.WriteLine($"{card.Rank} of {card.Suit}");
                        }

                        break;

                    case "5":
                        keepPlaying = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid selection.  Select a number between 1-5.");
                        break;
                }

                Console.WriteLine("\npress any key to continue");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
