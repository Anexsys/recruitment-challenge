package com.anexsys.recruitment.challenge;

/**
 * A Card must be in a 'deck' such that games which use more than one deck can identify the specific card.
 */
class Card {
    private final Suit suit;
    private final Rank rank;
    private final String deckId;
    Card(Suit suit, Rank rank, String deckId) {
        this.suit = suit;
        this.rank = rank;
        this.deckId = deckId;
    }
    Suit suit() {
        return this.suit;
    }
    Rank rank() {
        return this.rank;
    }
    String deckId() {
        return this.deckId;
    }
    @Override
    public String toString() {
        return this.rank + " of " + this.suit + " in " + this.deckId;
    }
    @Override
    public boolean equals(Object obj) {
        Card that;
        return obj != null && obj instanceof Card && (that = (Card) obj).suit == this.suit && that.rank == this.rank && this.deckId.equals(that.deckId);
    }
    @Override
    public int hashCode() {
        return (this.suit == null ? 32 : this.suit.hashCode()) ^ (this.rank == null ? 3 : this.rank.hashCode()) * this.deckId.hashCode();
    }
}
