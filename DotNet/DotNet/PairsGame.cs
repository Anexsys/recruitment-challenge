﻿using System;
using System.Threading.Tasks;


namespace DotNet
{
    /**
 * Implement Game to play pairs, such that all cards are spread out in a grid
 * and each player takes it in turn to turn over two cards. They make a trick if
 * the cards have the same rank, regardless of suit. If they make a trick, they
 * get to have another go. The winner is the player with the most tricks. No
 * jokers are required.
 */

    public class PairsGame : Game
    {

        public Game Shuffle()
        {
            return this;
        }

        public Game Assign(Player[] players)
        {
            return this;
        }


        public Game Deal()
        {
            return this;
        }


        public async Task Start()
        {
            throw new NotImplementedException();
        }

        public Task<Player> Winner()
        {
            throw new NotImplementedException();
        }
    }
}
