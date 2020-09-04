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

        [Test]
        public void Reverse_One_Character()
        {
            ReverseTextShouldBe("a", "a");
        }
        
        [Test]
        public void Reverse_One_Word()
        {
            ReverseTextShouldBe("cba", "abc");
        }

        [Test]
        public void Reverse_Two_Word()
        {
            ReverseTextShouldBe("cbafed", "abc def");
        }

        private static void ReverseTextShouldBe(string expected, string text)
        {
            Assert.AreEqual(expected, new MyString().ReverseAndCombineText(text));
        }
    }
}