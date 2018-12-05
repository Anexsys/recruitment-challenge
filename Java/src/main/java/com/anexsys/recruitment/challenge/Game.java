package com.anexsys.recruitment.challenge;

import java.util.concurrent.CompletableFuture;

interface Game {
    interface GameComplete {
        Player winner();
    }
    Game shuffle();
    Game assign(Player[] players);
    Game deal();
    CompletableFuture<GameComplete> start();
}
