using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class RanksTests
    {
        [Test]
        public void One_Rank()
        {
            HighestRankShouldBe(1, new[] {1});
        }
        
        [Test]
        public void Two_Same_Rank()
        {
            HighestRankShouldBe(2, new[] {2, 2});
        }
        
        [Test]
        public void Two_Same_Rank_And_One_Different()
        {
            HighestRankShouldBe(3, new[] {2, 3, 3});
        }

        [Test]
        public void Two_Different_Rank()
        {
            HighestRankShouldBe(9, new [] {3, 9});
        }
        
        private void HighestRankShouldBe(int expected, int[] ranks)
        {
            Assert.AreEqual(expected, new Ranks().Highest(ranks));
        }
    }
}