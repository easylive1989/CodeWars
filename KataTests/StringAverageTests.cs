using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class StringAverageTests
    {

        [Test]
        public void InputSingleNumber_Should_ReturnItself()
        {
            Assert.AreEqual("three", new StringAverage().AverageString("three"));
        }

        [Test]
        public void InputMultipleNumber_Should_ReturnAverageNumber()
        {
            Assert.AreEqual("four", new StringAverage().AverageString("zero nine five two"));
        }

        [Test]
        public void InputContainsInvalidNumber_ShouldReturnNone()
        {
            Assert.AreEqual("n/a", new StringAverage().AverageString("zero ss five two"));
        }

        [Test]
        public void InputEmpty_ShouldReturnNone()
        {
            Assert.AreEqual("n/a", new StringAverage().AverageString(""));
        }
    }
}
