using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class MyNumbersTests
    {
        [Test]
        public void One_Number()
        {
            DistinctNumbersShouldBe(new []{1}, new[] {1});
        }
        
        [Test]
        public void Two_Duplicated_Number()
        {
            DistinctNumbersShouldBe(new []{2}, new[] {2, 2});
        }
        
        [Test]
        public void Two_Set_Duplicated_Number()
        {
            DistinctNumbersShouldBe(new []{2, 3}, new[] {3, 2, 2, 3});
        }
        
        private static void DistinctNumbersShouldBe(int[] expected, int[] numbers)
        {
            Assert.AreEqual(expected, new MyNumbers().RemoveDuplicated(numbers));
        }
    }
}