using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class CarParkTests
    {
        [Test]
        public void OneFloor()
        {
            CarParkAssert(carpark: new [,]
            {
                { 2, 0, 0, 0 }
            }, expected: new [] { "R3" });
        }

        [Test]
        public void TwoFloor()
        {
            CarParkAssert(carpark: new[,]
            {
                { 2, 0, 1, 0 },
                { 0, 0, 0, 0 }
            }, expected: new[] { "R2", "R1" });
        }
        
        private void CarParkAssert(int[,] carpark, string[] expected)
        {
            var carkPark = new CarPark();

            var actaul = carkPark.Escape(carpark);

            CollectionAssert.AreEqual(expected, actaul);
        }
    }
}