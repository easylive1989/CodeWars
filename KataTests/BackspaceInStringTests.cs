using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class BackspaceInStringTests
    {
        [Test]
        public void No_Backspace()
        {
            CleanStringShouldBe("a", "a");
        }

        [Test]
        public void One_Char_With_One_Backspace()
        {
            CleanStringShouldBe("", "a#");
        }

        [Test]
        public void Multiple_Char_With_Multiple_Backspace()
        {
            CleanStringShouldBe("ad", "ab#c#d");
        }

        [Test]
        public void Start_With_Backspace()
        {
            CleanStringShouldBe("a", "#a");
        }

        private static void CleanStringShouldBe(string expected, string backspacesString)
        {
            Assert.AreEqual(expected, new BackspacesString().CleanString(backspacesString));
        }
    }
}