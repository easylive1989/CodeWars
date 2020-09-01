using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    // https://www.codewars.com/kata/5659c6d896bc135c4c00021e
    // 4 kyu
    public class NextSmallerKata
    {
        public long NextSmaller(long number)
        {
            var digits = ToDigits(number);
            if (IsSmallest(digits))
            {
                return -1;
            } 

            var smallerDigits = FindSmaller(digits);

            if (smallerDigits[0] == 0)
            {
                return -1;
            }
            return ToNumber(smallerDigits);
        }

        private bool IsSmallest(List<long> digits)
        {
            var smallestDigits = digits.OrderBy(i => i);
            return digits.SequenceEqual(smallestDigits);
        }

        private List<long> FindSmaller(List<long> digits)
        {
            var smallerDigits = new List<long>();
            
            var firstDigit = digits[0];
            var otherDigits = digits.Skip(1).ToList();
            if (IsSmallest(otherDigits))
            {
                var sortedDigits = digits.OrderByDescending(i => i).ToList();
                var secondLargeDigit = sortedDigits.First(i => i < firstDigit);
                sortedDigits.RemoveAt(sortedDigits.IndexOf(secondLargeDigit));

                smallerDigits.Add(secondLargeDigit);
                smallerDigits.AddRange(sortedDigits);
            }
            else
            {
                smallerDigits.Add(firstDigit);
                smallerDigits.AddRange(FindSmaller(otherDigits));
            }
            return smallerDigits.ToList();
        }
    

        private List<long> ToDigits(long number)
        {
            return number.ToString().Select(x => (long) x - '0').ToList();
        }

        private long ToNumber(List<long> digitArray)
        {
            return digitArray.Aggregate(0L, (total, number) => 10 * total + number);
        }
        
    }
}
