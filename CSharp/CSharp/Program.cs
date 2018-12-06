using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Task task = PrintWinner();

            while (!task.IsCompleted)
            {
                Console.WriteLine("Running the game");
                Thread.Sleep(1000);
            }
        }


        static async Task PrintWinner()
        {
            Player player = await new PairsGame().Assign(new Player[]
            {
            new Player("A"),
            new Player("B")
             }).Shuffle().Deal().Start();

            Console.WriteLine(player.ToString());
        }
    }
}
