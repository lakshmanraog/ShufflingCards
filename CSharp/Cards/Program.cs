

namespace Cards;
using System;
class Program
    {
        static void Main(string[] args)
        {
            // Inject Fisher-Yates shuffle strategy into Deck
            IShuffleStrategy shuffleStrategy = new FisherYatesShuffle();
            Deck deck = new Deck(shuffleStrategy);

            Console.WriteLine("Initial Deck:");
            PrintDeck(deck);

            // Shuffle using injected strategy
            deck.Shuffle();
            Console.WriteLine("\nShuffled Deck:");
            PrintDeck(deck);

            // Deal a few cards
            Console.WriteLine("\nDealing 5 cards:");
            for (int i = 0; i < 5; i++)
            {
                Card dealt = deck.Deal();
                Console.WriteLine($"{dealt.Rank} of {dealt.Suit}");
            }
        }

        static void PrintDeck(Deck deck)
        {
            foreach (var card in deck.GetCards())
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }
    }