using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNet.Tests
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void ShouldImplementHashCodeAndEquals()
        {
            Card sut1 = new Card(Suit.CLUBS, Rank.ACE, "deck id");
            Card sut2 = new Card(Suit.CLUBS, Rank.ACE, "deck id");
            Assert.AreEqual(sut1.GetHashCode(), sut2.GetHashCode());
            Assert.IsTrue(sut1.Equals(sut2));
            Assert.IsFalse(sut1.Equals(null));
            Assert.IsFalse(sut1.Equals(new Card(Suit.CLUBS, Rank.ACE, "different deck it")));
        }
    }
}
