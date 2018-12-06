using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Joker : Card
    {
        public Joker(string deckId) : base(null, null, deckId) { }

        public override string ToString()
        {
            return "Joker";
        }
    }
}
