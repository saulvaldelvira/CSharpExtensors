using NUnit.Framework;
using Extensores;
namespace Tests {
    public class IntegerTest {
        [Test]
        public void PrimeTest() {
            int a = 1, b = 3, c = 5, d = 6;
            Assert.IsFalse(a.IsPrime());
            Assert.IsTrue(b.IsPrime());
            Assert.IsTrue(c.IsPrime());
            Assert.IsFalse(d.IsPrime());
            Assert.AreEqual(3, a.NextPrime());
            Assert.AreEqual(5, b.NextPrime());
            Assert.AreEqual(3, c.PreviousPrime());
            Assert.AreEqual(5, d.PreviousPrime());
        }
    }
}