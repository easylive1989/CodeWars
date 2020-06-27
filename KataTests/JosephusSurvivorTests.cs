using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class JosephusSurvivorTests
    {
        [Test]
        public void One_Person_One_Step()
        {
            SurvivorShouldBe(1, 1, 1);
        }

        [Test]
        public void Two_People_One_Step()
        {
            SurvivorShouldBe(2, 1, 2);
        }
        
        [Test]
        public void Two_People_Two_Step()
        {
            SurvivorShouldBe(2, 2, 1);
        }
        
        [Test]
        public void Three_People_One_Step()
        {
            SurvivorShouldBe(3, 1, 3);
        }
        
        [Test]
        public void Three_People_Two_Step()
        {
            SurvivorShouldBe(3, 2, 3);
        }

        private void SurvivorShouldBe(int peopleCount, int step, int expected)
        {
            Assert.AreEqual(expected, new JosephusSurvivor().Play(peopleCount, step));
        }

        [Test]
        public void CodeWarsExamples() 
        {        
            SurvivorShouldBe(7,3,4);
            SurvivorShouldBe(11,19,10);
            SurvivorShouldBe(40,3,28);
            SurvivorShouldBe(14,2,13);
            SurvivorShouldBe(100,1,100);
            SurvivorShouldBe(1,300,1);
            SurvivorShouldBe(2,300,1);
            SurvivorShouldBe(5,300,1);
            SurvivorShouldBe(7,300,7);
            SurvivorShouldBe(300,300,265);
        }
    }
}