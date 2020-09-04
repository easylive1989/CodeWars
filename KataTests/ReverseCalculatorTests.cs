using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class ReverseCalculatorTests
    {
        [Test]
        public void One_Should_Be_One()
        {
            ResultShouldBe(1, "1");
        }
        
        [Test]
        public void One_Add_Two_Should_Be_Three()
        {
            ResultShouldBe(3, "1 2 +");
        }

        private static void ResultShouldBe(int expected, string expressions)
        {
            Assert.AreEqual(expected, new ReverseCalculator().Evaluate(expressions));
        }
    }
}