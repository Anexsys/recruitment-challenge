using System;

namespace DotNet
{
    public class Card
    {
        public Suit? Suit { get; }
        public Rank? Rank { get; }
        public string DeckId { get; }

        public Card(Suit? suit, Rank? rank, String deckId)
        {
            Suit = suit;
            Rank = rank;
            DeckId = deckId;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit} in {DeckId}";
        }

        public override bool Equals(object obj)
        {
            Card that;
            return obj != null && obj is Card && (that = (Card)obj).Suit == Suit && that.Rank == Rank && DeckId.Equals(that.DeckId);
        }

        public override int GetHashCode()
        {
            return (Suit == null ? 32 : Suit.GetHashCode()) ^ (Rank == null ? 3 : Rank.GetHashCode()) * DeckId.GetHashCode();
        }
    }
}
