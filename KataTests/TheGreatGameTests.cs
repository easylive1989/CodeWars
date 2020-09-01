using System.Linq;
using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class TheGreatGameTests
    {
        [Test]
        public void Brackets_Greater_Than_Parentheses()
        {
            MessageShouldBe("TEAM 2 WINS", "()", "[]");
        }
        
        [Test]
        public void EightLess_Greater_Than_Brackets()
        {
            MessageShouldBe("TEAM 2 WINS", "[]", "8<");
        }
        
        [Test]
        public void Multi_Action()
        {
            MessageShouldBe("TEAM 2 WINS", "[]()8<8<", "[]8<()()");
        }
        
        [Test]
        public void Tie()
        {
            MessageShouldBe("TIE", "[]", "[]");
        }

        private static void MessageShouldBe(string expectedMessage, string actionOfTeam1, string actionOfTeam2)
        {
            Assert.AreEqual(expectedMessage, new TheGreatGame().WhoIsWinner(actionOfTeam1, actionOfTeam2));
        }
    }
}