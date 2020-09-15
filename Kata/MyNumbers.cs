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
            return numbers.Select((number, index) =>
                    index > 0 && numbers[index - 1] == number ? (int?) null : GetConsecutiveNumbers(numbers, index).Sum())
                .Where(sum => sum.HasValue).Select(sum => sum.Value).ToList();
            
            // var consecutiveSums = new List<int>();
            // for (var index = 0; index < numbers.Count; )
            // {
            //     var consecutiveNumbers = GetConsecutiveNumbers(numbers, index);
            //     consecutiveSums.Add(consecutiveNumbers.Sum());
            //     index += consecutiveNumbers.Count;
            // }
            //
            // return consecutiveSums;
        }

        private List<int> GetConsecutiveNumbers(List<int> numbers, int index)
        {
            return numbers.Skip(index)
                .TakeWhile(number => number == numbers[index]).ToList();
        }

        public int EvenSum(List<int> numbers)
        {
            UpdateEvenNumber(_evenNumbers);
            if (!HasEvenNumber(numbers))
            {
                return 0;
            }
            return _evenNumbers.Sum();
        }
        
        
        private readonly List<int> _evenNumbers = new List<int>();
        

        private void UpdateEvenNumber(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    _evenNumbers.Add(number);
                }
            }
        }
        
        private bool HasEvenNumber(List<int> numbers)
        {
            return _evenNumbers.Any(number => true);
        }
    }
}