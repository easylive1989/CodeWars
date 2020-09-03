using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class DuplicateEncoderTests
    {
        [Test]
        public void One_Word_No_Duplicated()
        {
            DuplicatedStringShouldBe("(", "a");
        }
        
        [Test]
        public void Two_Word_Duplicated()
        {
            DuplicatedStringShouldBe("))", "aa");
        }
        
        [Test]
        public void Two_Word_Duplicated_And_One_Word_Not_Duplicated()
        {
            DuplicatedStringShouldBe(")()", "Ada");
        }

        private static void DuplicatedStringShouldBe(string expected, string input)
        {
            Assert.AreEqual(expected, new DuplicatedEncoder().Encode(input));
        }
    }
}