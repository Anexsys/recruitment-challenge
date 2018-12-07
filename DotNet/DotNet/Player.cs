using System;
using System.Collections.Generic;

namespace DotNet
{
    public class Player
    {
        private readonly string id;
        private readonly ISet<Card> currentCards;

        public Player(string id)
        {
            this.id = id;
            currentCards = new HashSet<Card>();
        }

        public Player Receive(Card card)
        {
            currentCards.Add(card);
            return this;
        }

        public Player Use(Card card)
        {
            bool removed = currentCards.Remove(card);
            if (!removed)
            {
                throw new ArgumentOutOfRangeException("Cannot use a card the player does not have");
            }
            return this;
        }

        public override string ToString()
        {
            return $"player-{id}";
        }
    }
}
