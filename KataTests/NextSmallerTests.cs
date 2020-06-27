using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class NextSmallerTests
    {
        [Test]
        public void Single_Should_Return_None()
        {
            NextSmallerShouldBe(0, -1);
        }

        [Test]
        public void TwoDigit_Should_Return_Smallest()
        {
            NextSmallerShouldBe(91, 19);
        }

        [Test]
        public void ThreeDigit_Should_Return_Smaller()
        {
            NextSmallerShouldBe(917, 791);
        }

        [Test]
        public void FourDigit_Should_Return_Smaller()
        {
            NextSmallerShouldBe(2143, 2134);
        }
        
        [Test]
        public void Smallest_Should_Return_None()
        {
            NextSmallerShouldBe(1234, -1);
        }
        
        [Test]
        public void DuplicateDigits_Should_Return_Smaller()
        {
            NextSmallerShouldBe(29009, 20990);
        }

        [Test]
        public void Smallest_WithZero_Should_Return_None()
        {
            NextSmallerShouldBe(1027, -1);
        }

        private void NextSmallerShouldBe(int input, int expected)
        {
            var result = NextSmallerKata.NextSmaller(input);
            Assert.AreEqual(expected, result);
        }
    }
}
