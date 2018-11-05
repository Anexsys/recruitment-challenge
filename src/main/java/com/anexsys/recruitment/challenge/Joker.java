package com.anexsys.recruitment.challenge;

class Joker extends Card {
    Joker(String deckId) {
        super(null, null, deckId);
    }
    @Override
    public String toString() {
        return "Joker";
    }
}
