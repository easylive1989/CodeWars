using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class EuclideanSpaceTests
    {
        [Test]
        public void Two_Dim_Distance()
        {
            var distance = new EuclideanSpace().Calculate2dDistance("1,2", "4,5");
            Assert.AreEqual(4.2426406871192848d, distance);
        }
    }
}