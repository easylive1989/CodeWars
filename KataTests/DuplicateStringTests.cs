using NUnit.Framework;

namespace Kata.Tests
{
    
    public class DuplicateStringTests
    {
        [Test]
        public void InputNull_Should_Return_Zero()
        {
            assertDuplicateCount(0, null);
        }

        [Test]
        public void InputEmpty_Should_Return_Zero()
        {
            assertDuplicateCount(0, "");
        }

        [Test]
        public void InputNoDupliucateString_Should_Return_Zero()
        {
            assertDuplicateCount(0, "abcde");
        }

        [Test]
        public void InputDupliucateString_Should_Return_DuplicateCount()
        {
            assertDuplicateCount(1, "abcdde");
        }

        [Test]
        public void InputDupliucateStringWithUpperCase_Should_Return_DuplicateCount()
        {
            assertDuplicateCount(2, "aBbcdde");
        }

        [Test]
        public void InputDupliucateStringWithSpace_Should_Return_DuplicateCount()
        {
            assertDuplicateCount(1, "abc dd e");
        }

        private void assertDuplicateCount(int expectedCount, string actual)
        {
            Assert.AreEqual(expectedCount, DuplicateString.DuplicateCount(actual));
        }
    }
}