package com.anexsys.recruitment.challenge;

class Deck {
    private static final Suit[] SUITS = Suit.values();
    private static final Rank[] RANKS = Rank.values();
    private static final int NUM_STANDARD_CARDS = SUITS.length * RANKS.length;
    private final Card[] cards;
    private final String id;
    Deck(int numJokers) {
        if (numJokers < 0) {
            throw new IllegalArgumentException("Invalid number of jokers: " + numJokers + " - expected 0 or more");
        }
        this.id = "deck-" + System.currentTimeMillis() + "-" + ("" + Math.random()).substring(0, 10);
        this.cards = new Card[NUM_STANDARD_CARDS + numJokers];
        for (int i = 0; i < SUITS.length; i++) {
            for (int j = 0; j < RANKS.length; j++) {
                this.cards[(i * RANKS.length) + j] = new Card(SUITS[i], RANKS[j], this.id);
            }
        }
        for (int k = NUM_STANDARD_CARDS; k < NUM_STANDARD_CARDS + numJokers; k++) {
            this.cards[k] = new Joker(this.id);
        }
    }
    Deck() {
        this(0);
    }
    Deck(String id, Card[] cards) {
        this.id = id;
        this.cards = cards;
    }
    String id() {
        return this.id;
    }
    Card[] cards() {
        return cards;
    }
}
