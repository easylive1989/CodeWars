using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public static class NextSmallerKata
    {
        public static long NextSmaller(long number)
        {
            long[] digitArray = ParseToDigitArray(number);
            if (IsSmallest(digitArray))
            {
                return -1;
            } 

            digitArray = FindSmaller(digitArray);

            if (digitArray[0] == 0)
            {
                return -1;
            }
            return GetOutput(digitArray);
        }

        private static bool IsSmallest(long[] digitArray)
        {
            long[] sortedDigitArray = digitArray.OrderBy(i => i).ToArray();
            return digitArray.SequenceEqual(sortedDigitArray);
        }

        private static long[] FindSmaller(long[] digitArray)
        {
            var smallerDigit = new List<long>();
            
            var firstDigit = digitArray[0];
            var otherDigits = digitArray.Skip(1).ToArray();
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
            return smallerDigit.ToArray();
        }
    

        private static long[] ParseToDigitArray(long number)
        {
            return Array.ConvertAll(number.ToString().ToArray(), x => (long)x - '0');
        }

        private static long GetOutput(long[] digitArray)
        {
            var total = 0L;
            for (int i = 0; i < digitArray.Length; i++)
            {
                total = 10 * total + digitArray[i];
            }
            return total;
        }
        
    }
}
