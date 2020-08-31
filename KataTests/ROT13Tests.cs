using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class ROT13KataTests
    {
        [Test]
        public void Rot13Test()
        {
            
            Assert.AreEqual("nNM13 example.", new ROT13().Rot13("aAZ13 rknzcyr."));
        }
    }
}