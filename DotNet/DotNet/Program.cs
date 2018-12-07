using System.Threading.Tasks;

namespace DotNet
{
    public class Program
    {
        static void Main()
        {
            Task winner = new PairsGame().Assign(new Player[]
            {
                new Player("A"),
                new Player("CB"),
            }).Shuffle().Deal().Start();
        }
    }
}
