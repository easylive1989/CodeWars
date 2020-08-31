using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class PlayWithTwoStringsKataTests
    {

        [Test]
        public void smile67KataTest_withoutRandom1()
        {
            Assert.AreEqual("abCCde", new PlayWithTwoStrings().WorkOnStrings("abc", "cde"));
        }

        [Test]
        public void smile67KataTest_withoutRandom2()
        {
            Assert.AreEqual("ABABbababa", new PlayWithTwoStrings().WorkOnStrings("abab", "bababa"));

        }

        [Test]
        public void smile67KataTest_withoutRandom3()
        {
            Assert.AreEqual("abcDeFGtrzWDEFGgGFhjkWqE", new PlayWithTwoStrings().WorkOnStrings("abcdeFgtrzw", "defgGgfhjkwqe"));
        }

        [Test]
        public void smile67KataTest_withoutRandom4()
        {
            Assert.AreEqual("abcDEfgDEFGg", new PlayWithTwoStrings().WorkOnStrings("abcdeFg", "defgG"));
        }
    }
}
