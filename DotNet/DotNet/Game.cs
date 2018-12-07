using System.Threading.Tasks;

namespace DotNet
{
    public interface Game
    {
        Game Shuffle();
        Game Assign(Player[] players);
        Game Deal();
        Task Start();
        Task<Player> Winner();
    }
}
