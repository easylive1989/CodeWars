using Kata;
using NUnit.Framework;

namespace KataTests
{
    
    public class TwoSumTests
    {
        [Test]
        public void Input_Num_Array_Should_Return_First_Two_Item()
        {
            int[] actual = TwoSum.findTwoSum(new int[] { 2, 7, 11, 15 }, 9);
            int[] expect = new int[] { 0, 1 };
            CollectionAssert.AreEqual(expect, actual);
        }
        
        [Test]
        public void Input_Num_Array_Should_Return_Last_Two_Item()
        {
            int[] actual = TwoSum.findTwoSum(new int[] { 2, 7, 11, 15 }, 26);
            int[] expect = new int[] { 2, 3 };
            CollectionAssert.AreEqual(expect, actual);
        }
    }
}