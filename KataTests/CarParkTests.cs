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
        public void Two_Basic_Floor()
        {
            CarParkAssert(carpark: new[,]
            {
                { 2, 0, 1, 0 },
                { 0, 0, 0, 0 }
            }, expected: new[] { "R2", "D1", "R1" });
        }
        
        [Test]
        public void Three_Consecutive_Stair()
        {
            CarParkAssert(carpark: new[,]
            {
                { 0, 2, 0, 0, 1 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0 } 
            }, expected: new[] { "R3", "D3" });
        }
        
        [Test]
        public void Longest_Move()
        {
            CarParkAssert(carpark: new[,]
            {
                { 1, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 } 
            }, expected: new[] { "L4", "D1", "R4", "D1", "L4", "D1", "R4" });
        }
        
        [Test]
        public void Car_At_Exit()
        {
            CarParkAssert(carpark: new[,]
            {
                { 0, 0, 0, 0, 2 }
            }, expected: new string[0]);
        }
        
        private void CarParkAssert(int[,] carpark, string[] expected)
        {
            var carkPark = new CarPark();

            var actaul = carkPark.Escape(carpark);

            CollectionAssert.AreEqual(expected, actaul);
        }
    }
}