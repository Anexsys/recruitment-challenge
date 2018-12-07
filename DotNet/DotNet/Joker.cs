namespace DotNet
{
    public class Joker : Card
    {
        public Joker(string deckId) : base(null, null, deckId) { }

        public override string ToString()
        {
            return "Joker";
        }
    }
}
