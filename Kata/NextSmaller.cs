using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class NextSmallerKata
    {
        public long NextSmaller(long number)
        {
            var digits = ToDigits(number);
            if (IsSmallest(digits))
            {
                return -1;
            } 

            digits = FindSmaller(digits);

            if (digits[0] == 0)
            {
                return -1;
            }
            return ToNumber(digits);
        }

        private bool IsSmallest(List<long> digitArray)
        {
            var smallestDigits = digitArray.OrderBy(i => i);
            return digitArray.SequenceEqual(smallestDigits);
        }

        private List<long> FindSmaller(List<long> digitArray)
        {
            var smallerDigit = new List<long>();
            
            var firstDigit = digitArray[0];
            var otherDigits = digitArray.Skip(1).ToList();
            if (IsSmallest(otherDigits))
            {
                var sortedDigits = digitArray.OrderByDescending(i => i).ToList();
                var secondLargestThanFirst = sortedDigits.First(i => i < firstDigit);
                sortedDigits.RemoveAt(sortedDigits.IndexOf(secondLargestThanFirst));

                smallerDigit.Add(secondLargestThanFirst);
                smallerDigit.AddRange(sortedDigits);
            }
            else
            {
                smallerDigit.Add(firstDigit);
                smallerDigit.AddRange(FindSmaller(otherDigits));
            }
            return smallerDigit.ToList();
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
