using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
