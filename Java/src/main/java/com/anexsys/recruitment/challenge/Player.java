package com.anexsys.recruitment.challenge;

import java.util.Set;
import java.util.HashSet;

class Player {
    private final String id;
    private final Set<Card> currentCards;
    Player(String id) {
        this.id = id;
        this.currentCards = new HashSet<>();
    }
    Player receive(Card card) {
        this.currentCards.add(card);
        return this;
    }
    Player use(Card card) {
        boolean removed = this.currentCards.remove(card);
        if (!removed) {
            throw new IllegalArgumentException("Cannot use a card the Player does not have");
        }
        return this;
    }
    @Override
    public String toString() {
        return "player-" + this.id;
    }
}
