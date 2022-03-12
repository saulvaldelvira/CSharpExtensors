using NUnit.Framework;
using Extensores;
namespace Tests {
    public class StringTest {
        [Test]
        public void NumberOfVocalsTest() {
            string s = "Hi i am testing an extensor method :)";
            Assert.AreEqual(11, s.NumberOfVocals());
            s = "";
            Assert.AreEqual(0, s.NumberOfVocals());
            s = "ddddd";
            Assert.AreEqual(0, s.NumberOfVocals());
        }
        [Test]
        public void CountCharacter() {
            string s = "Hi i am testing an extensor method :)";
            Assert.AreEqual(3, s.CountCharacter('i'));
            s = "";
            Assert.AreEqual(0, s.CountCharacter('a'));
            s = "ddddd";
            Assert.AreEqual(5, s.CountCharacter('d'));
        }
    }
}
