using System.Threading.Tasks;

namespace CSharp
{
    interface Game
    {
        Game Shuffle();
        Game Assign(Player[] players);
        Game Deal();

        Task<Player> Start();

        Task<Player> Winner();
    }
}
