using Kata;
using Kata.Models;
using NUnit.Framework;

namespace KataTests
{
    
    public class DartboardTests
    {
        [Test]
        public void Test_DB()
        {
            Assert.AreEqual("DB", GetDartboard(4.06, -0.71));
        }

        [Test]
        public void Test_X()
        {
            Assert.AreEqual("X", GetDartboard(-133.69, -147.38));
        }

        [Test]
        public void Test_SB()
        {
            Assert.AreEqual("SB", GetDartboard(2.38, -6.06));
        }

        [Test]
        public void Test_20()
        {
            Assert.AreEqual("20", GetDartboard(-5.43, 117.95));
        }

        [Test]
        public void Test_7()
        {
            Assert.AreEqual("7", GetDartboard(-73.905, -95.94));
        }

        [Test]
        public void Test_T2()
        {
            Assert.AreEqual("T2", GetDartboard(55.53, -87.95));
        }

        [Test]
        public void Test_D9()
        {
            Assert.AreEqual("D9", GetDartboard(-145.19, 86.53));
        }

        private static string GetDartboard(double x, double y)
        {
            return new Dartboard().GetScore(Point.Create2dPoint(x, y));
        }
    }
}
