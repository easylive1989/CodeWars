using System.Collections.Generic;
using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class MyMathTests
    {
        [Test]
        public void One_Prime()
        {
            PrimesShouldBe(new List<int>{2}, new List<int>(){2});
        }

        [Test]
        public void One_Prime_One_Even()
        {
            PrimesShouldBe(new List<int>{2}, new List<int>(){2, 4});
        }
        
        [Test]
        public void One_Prime_One_Composite()
        {
            PrimesShouldBe(new List<int>{2}, new List<int>(){2, 9});
        }

        private static void PrimesShouldBe(List<int> expected, List<int> numbers)
        {
            CollectionAssert.AreEqual(expected, new MyMath().FindPrimes(numbers));
        }
    }
}