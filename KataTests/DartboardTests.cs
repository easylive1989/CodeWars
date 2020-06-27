using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class DartboardTests
    {
        [Test]
        public void Test_DB()
        {
            Assert.AreEqual("DB", new Dartboard().GetScore(4.06, -0.71));
        }

        [Test]
        public void Test_X()
        {
            Assert.AreEqual("X", new Dartboard().GetScore(-133.69, -147.38));
        }

        [Test]
        public void Test_SB()
        {
            Assert.AreEqual("SB", new Dartboard().GetScore(2.38, -6.06));
        }

        [Test]
        public void Test_20()
        {
            Assert.AreEqual("20", new Dartboard().GetScore(-5.43, 117.95));
        }


        [Test]
        public void Test_7()
        {
            Assert.AreEqual("7", new Dartboard().GetScore(-73.905, -95.94));
        }

        [Test]
        public void Test_T2()
        {
            Assert.AreEqual("T2", new Dartboard().GetScore(55.53, -87.95));
        }

        [Test]
        public void Test_D9()
        {
            Assert.AreEqual("D9", new Dartboard().GetScore(-145.19, 86.53));
        }
    }
}
