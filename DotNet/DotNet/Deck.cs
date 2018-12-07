using System;

namespace DotNet
{
    public class Deck
    {
        private static readonly int NUM_SUITS = Enum.GetNames(typeof(Suit)).Length;
        private static readonly int NUM_RANKS = Enum.GetNames(typeof(Rank)).Length;
        private static readonly int NUM_STANDARD_CARDS = NUM_RANKS * NUM_SUITS;
        private readonly string id;

        public Card[] Cards { get; }


        public Deck(int numJokers)
        {
            if (numJokers < 0)
            {
                throw new ArgumentOutOfRangeException($"Invalid number of jokers: {numJokers} - expected 0 or more");
            }

            id = $"deck-{DateTime.Now.Ticks} - {new Random().NextDouble().ToString().Substring(0, 10)}";
            Cards = new Card[NUM_STANDARD_CARDS + numJokers];

            for (int i = 0; i < NUM_SUITS; i++)
            {
                for (int j = 0; j < NUM_RANKS; j++)
                {
                    Cards[(i * NUM_RANKS) + j] = new Card((Suit)i, (Rank)j, id);
                }
            }

            for (int k = NUM_STANDARD_CARDS; k < NUM_STANDARD_CARDS + numJokers; k++)
            {
                Cards[k] = new Joker(id);
            }
        }

        public Deck() : this(0) { }

        public Deck(string id, Card[] cards)
        {
            this.id = id;
            this.Cards = cards;
        }
    }
}
