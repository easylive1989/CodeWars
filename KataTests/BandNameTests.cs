using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class BandNameTests
    {
        [Test]
        public void InputNounWithDiffStartAndLast_Should_ReturnNounWithThe()
        {
            Assert.AreEqual("The Knife", BandName.BandNameGenerator("knife"));
        }
        [Test]
        public void InputNounWithSameStartAndLast_Should_ReturnRepeatNoun()
        {
            Assert.AreEqual("Tartart", BandName.BandNameGenerator("tart"));
        }
        
        [Test]
        public void InputEmpty_Should_ReturnEmpty()
        {
            Assert.AreEqual("", BandName.BandNameGenerator(""));
        }

        [Test]
        public void InputNull_Should_ReturnEmpty()
        {
            Assert.AreEqual("", BandName.BandNameGenerator(null));
        }
    }
}