using System.Collections.Generic;
using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class BookShopTests
    {
        private BookShop _bookShop;

        [SetUp]
        public void SetUp()
        {
            _bookShop = new BookShop();
        }
        
        [Test]
        public void One_First_Volume()
        {
            PriceShouldBe(new List<int>{1, 0, 0, 0, 0}, 100);
        }

        [Test]
        public void Two_First_Volume()
        {
            PriceShouldBe(new List<int>{2, 0, 0, 0, 0}, 200);
        }
        
        [Test]
        public void One_First_Vol_And_One_Second_Vol()
        {
            PriceShouldBe(new List<int>{1, 1, 0, 0, 0}, 190);
        }
        
        [Test]
        public void One_First_Vol_And_One_Second_Vol_And_One_Third_Vol()
        {
            PriceShouldBe(new List<int>{1, 1, 1, 0, 0}, 270);
        }
        
        [Test]
        public void One_First_Vol_And_One_Second_Vol_And_One_Third_Vol_And_One_Forth_Vol()
        {
            PriceShouldBe(new List<int>{1, 1, 1, 1, 0}, 320);
        }
        
        [Test]
        public void One_For_Each_Vol()
        {
            PriceShouldBe(new List<int>{1, 1, 1, 1, 1}, 375);
        }
        
        [Test]
        public void Two_One_First_Vol_And_One_Second_Vol()
        {
            PriceShouldBe(new List<int>{2, 1, 0, 0, 0}, 290);
        }
        
        [Test]
        public void Two_One_First_Vol_And_Two_Second_Vol_And_One_Third_Vol()
        {
            PriceShouldBe(new List<int>{2, 2, 1, 0, 0}, 460);
        }
        
        private void PriceShouldBe(List<int> eachBookAmount, int expected)
        {
            var price = _bookShop.BuyHarryPotter(eachBookAmount);
            Assert.AreEqual(expected, price);
        }

    }
}