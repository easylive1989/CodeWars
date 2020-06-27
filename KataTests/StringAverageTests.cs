using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class StringAverageTests
    {

        [Test]
        public void InputSingleNumber_Should_ReturnItself()
        {
            Assert.AreEqual("three", StringAverage.AverageString("three"));
        }

        [Test]
        public void InputMultipleNumber_Should_ReturnAverageNumber()
        {
            Assert.AreEqual("four", StringAverage.AverageString("zero nine five two"));
        }

        [Test]
        public void InputContainsInvalidNumber_ShouldReturnNone()
        {
            Assert.AreEqual("n/a", StringAverage.AverageString("zero ss five two"));
        }

        [Test]
        public void InputEmpty_ShouldReturnNone()
        {
            Assert.AreEqual("n/a", StringAverage.AverageString(""));
        }

        [Test]
        public void InputNull_ShouldReturnNone()
        {
            Assert.AreEqual("n/a", StringAverage.AverageString(null));
        }
    }
}
