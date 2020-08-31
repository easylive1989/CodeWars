using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class DuplicateStringTests
    {
        [Test]
        public void InputNull_Should_Return_Zero()
        {
            AssertDuplicateCount(0, null);
        }

        [Test]
        public void InputEmpty_Should_Return_Zero()
        {
            AssertDuplicateCount(0, "");
        }

        [Test]
        public void InputNoDupliucateString_Should_Return_Zero()
        {
            AssertDuplicateCount(0, "abcde");
        }

        [Test]
        public void InputDupliucateString_Should_Return_DuplicateCount()
        {
            AssertDuplicateCount(1, "abcdde");
        }

        [Test]
        public void InputDupliucateStringWithUpperCase_Should_Return_DuplicateCount()
        {
            AssertDuplicateCount(2, "aBbcdde");
        }

        [Test]
        public void InputDupliucateStringWithSpace_Should_Return_DuplicateCount()
        {
            AssertDuplicateCount(1, "abc dd e");
        }

        private void AssertDuplicateCount(int expectedCount, string actual)
        {
            Assert.AreEqual(expectedCount, new DuplicateString().DuplicateCount(actual));
        }
    }
}