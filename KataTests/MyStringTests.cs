using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class MyStringTests
    {
        [Test]
        public void No_Duplicated_Word()
        {
            StringShouldBe("abc", "abc");
        }
        
        [Test]
        public void Two_No_Duplicated_Word()
        {
            StringShouldBe("abc", "abc abc");
        }

        private static void StringShouldBe(string expected, string sentence)
        {
            Assert.AreEqual(expected, new MyString().RemoveDuplicatedWord(sentence));
        }
    }
}