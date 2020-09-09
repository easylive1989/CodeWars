using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class MyNumbers
    {
        public int[] RemoveDuplicated(int[] numbers)
        {
            return numbers.Reverse().Distinct().Reverse().ToArray();
        }

        public List<int> SumConsecutives(List<int> numbers)
        {
            var consecutiveSums = new List<int>();
            for (var index = 0; index < numbers.Count; )
            {
                var consecutiveNumbers = GetConsecutiveNumbers(numbers, index);
                consecutiveSums.Add(consecutiveNumbers.Sum());
                index += consecutiveNumbers.Count;
            }
            
            return consecutiveSums;
        }

        private List<int> GetConsecutiveNumbers(List<int> numbers, int index)
        {
            var consecutiveNumbers = new List<int> {numbers[index]};
            while (!IsLastNumber(numbers, index) && IsNumberConsecutive(numbers, index))
            {
                consecutiveNumbers.Add(numbers[index]);
                index++;
            }
            return consecutiveNumbers;
        }

        private static bool IsNumberConsecutive(List<int> numbers, int index)
        {
            return numbers[index] == numbers[index + 1];
        }

        private bool IsLastNumber(List<int> numbers, int index)
        {
            return index == numbers.Count - 1;
        }
    }
}