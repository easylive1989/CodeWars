using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class SimpleRunKataTests
    {
        [Test]
        public void Test_All_Meeting_At_Same_Position()
        {
            Assert.AreEqual(3, new SimpleRun().RunnersMeetings(new int[] { 1, 4, 2 }, new int[] { 27, 18, 24 }));
        }

        [Test]
        public void Test_Meeting()
        {
            Assert.AreEqual(2, new SimpleRun().RunnersMeetings(new int[] { 1, 4, 2 }, new int[] { 5, 6, 2 }));
        }

        [Test]
        public void Test_Never_Meeting()
        {
            Assert.AreEqual(-1, new SimpleRun().RunnersMeetings(new int[] { 1, 2, 3 }, new int[] { 1, 1, 1 }));
        }

        [Test]
        public void Test_Different_Runner()
        {
            Assert.AreEqual(2, new SimpleRun().RunnersMeetings(new int[] { 1, 1000 }, new int[] { 23, 22 }));
        }
    }
}
