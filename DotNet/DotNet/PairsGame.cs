using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
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
        public Player[] Players { get; private set; } = new Player[2];
        public Deck Deck { get; private set; } = new Deck();
        public List<Card> DealtCards { get; private set; }
        public int PlayerOneScore { get; private set; }

        public int PlayerTwoScore { get; private set; }

        public int CurrentPlayer { get; private set; }



        public Game Shuffle()
        {
            Card[] cards = Deck.Cards;

            for (int i = 0; i < cards.Length; i++)
            {
                int random = (int)new Random().NextDouble() * cards.Length;
                Card temp = cards[i];
                cards[i] = cards[random];
                cards[random] = temp;
            }
            Deck = new Deck("pairsGame deck 1", cards);
            return this;
        }

        public Game Assign(Player[] players)
        {
            if (noOfPlayersLegal(players))
            {
                Players[0] = players[0];
                Players[1] = players[1];
                return this;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Too many players");
            }
        }

        private bool noOfPlayersLegal(Player[] players)
        {
            if (players.Length != 2)
            {
                return false;
            }
            else if (players[0] == null || players[1] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Game Deal()
        {
            DealtCards = new List<Card>(Deck.Cards);
            return this;
        }


        public async Task Start()
        {
            Player player = await Winner();
            Console.WriteLine(player.ToString());
        }

        public Task<Player> Winner()
        {
            return Task.Run(() =>
          {
              while (DealtCards.Count > 0)
              {
                  Random random = new Random();
                  int randomCard1 = (int)(random.NextDouble() * DealtCards.Count - 1);
                  int randomCard2 = (int)(random.NextDouble() * DealtCards.Count - 1);
                  Card cardOne = DealtCards[randomCard1];
                  Card cardTwo = DealtCards[randomCard2];

                  if (cardOne.Rank.Equals(cardTwo.Rank))
                  {
                      removeMatchingCards(randomCard1, randomCard2);
                      addScore();
                  }
                  else
                  {
                      getNextPlayer();
                  }
              }
              return PlayerOneScore > PlayerTwoScore ? Players[0] : Players[1];
          });
            
        }


        private void removeMatchingCards(int randomCard1, int randomCard2)
        {
            DealtCards.RemoveAt(randomCard1);
            DealtCards.RemoveAt(randomCard2);
        }


        private void addScore()
        {
            if (CurrentPlayer == 0)
            {
                PlayerOneScore++;
            }
            else
            {
                PlayerTwoScore++;
            }
        }


        private void getNextPlayer()
        {
            if (CurrentPlayer == 0)
            {
                CurrentPlayer++;
            }
            else
            {
                CurrentPlayer--;
            }
        }
    }
}
