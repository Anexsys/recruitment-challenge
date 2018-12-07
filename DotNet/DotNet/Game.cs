using System.Threading.Tasks;

namespace DotNet
{
    public interface Game
    {
        Game Shuffle();
        Game Assign(Player[] players);
        Game Deal();
        Task<Player> Start();
        Task<Player> Winner();
    }
}
