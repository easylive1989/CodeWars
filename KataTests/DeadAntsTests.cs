using Kata;
using NUnit.Framework;

namespace KataTests
{
    public class DeadAntsTests
    {
        [Test]
        public void InputFourLiveAnts_Should_ReturnZeroDeadAnt()
        {
            Assert.AreEqual(0, new DeadAnts().Count("ant ant ant ant"));
        }

        [Test]
        public void InputNull_Should_ReturnZeroDeadAnt()
        {
            Assert.AreEqual(0, new DeadAnts().Count(null));
        }

        [Test]
        public void InputLiveAntContainsDeadAnt_Should_ReturnCorrectDeadAnt()
        {
            Assert.AreEqual(2, new DeadAnts().Count("ant anantt aantnt"));
        }

        [Test]
        public void InputAntsWithDot_Should_ReturnCorrectDeadAnt()
        {
            Assert.AreEqual(1, new DeadAnts().Count("ant ant .... a nt"));
        }
    }
}
