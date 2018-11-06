package com.anexsys.recruitment.challenge;

public class Main {

    public static void main(String[] args) throws Exception {
        new Main();
    }

    private Main() throws Exception {
        Game.GameComplete outcome = new PairsGame().assign(new Player[] {
            new Player("A"),
            new Player("B")
        }).shuffle().deal().start().get();
        System.out.println(outcome.winner());
    }

}
