using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    // https://www.codewars.com/kata/5966847f4025872c7d00015b
    // 6 kyu
    public class StringAverage
    {
        private readonly Dictionary<string, int> _numberDict = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };

        private const int InvalidNumber = -1;
        private const string InvalidStringNumber = "n/a";

        public string AverageString(string stringNumbers)
        {
            var nums = ToNumbers(stringNumbers);
            if (HasInvalidNumber(nums))
            {
                return InvalidStringNumber;
            }

            return ToString(CalculateAverage(nums));
        }
        
        private int[] ToNumbers(string str)
        {
            return str.Split(' ').Select(x => ToNumber(x)).ToArray();
        }

        private bool HasInvalidNumber(int[] numbers)
        {
            return numbers.Count(x => x == InvalidNumber) != 0;
        }

        private int CalculateAverage(int[] numbers)
        {
            return numbers.Sum() / numbers.Length;
        }

        private int ToNumber(string strNumber)
        {
            return _numberDict.ContainsKey(strNumber) ? _numberDict[strNumber] : InvalidNumber;
        }

        private string ToString(int number)
        {
            return _numberDict.ContainsValue(number)
                ? _numberDict.First(x => x.Value == number).Key
                : InvalidStringNumber;
        }
    }
}
