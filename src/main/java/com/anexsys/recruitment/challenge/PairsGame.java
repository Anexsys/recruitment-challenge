package com.anexsys.recruitment.challenge;

import java.util.concurrent.CompletableFuture;

/**
 * Implement Game to play pairs, such that all cards are spread out in a grid
 * and each player takes it in turn to turn over two cards. They make a trick if
 * the cards have the same rank, regardless of suit. If they make a trick, they
 * get to have another go. The winner is the player with the most tricks. No
 * jokers are required.
 */
class PairsGame implements Game {

    @Override
    public Game shuffle() {
        return this;
    }

    @Override
    public Game assign(Player[] players) {
        return this;
    }

    @Override
    public Game deal() {
        return this;
    }

    @Override
    public CompletableFuture<GameComplete> start() {
        return CompletableFuture.completedFuture(new Game.GameComplete(){
            @Override
            public Player winner() {
                return null;
            }
        });
    }

}