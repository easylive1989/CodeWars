using System;
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

        public string AverageString(string str)
        {
            if (str == null)
            {
                return InvalidStringNumber;
            }

            return DoAverageString(str);
        }

        private string DoAverageString(string str)
        {
            var nums = ToNumbers(str);
            if (HasInvalidNumber(nums))
            {
                return InvalidStringNumber;
            }

            var averageNumber = CalculateAverage(nums);
            return ToString(averageNumber);
        }

        private int[] ToNumbers(string str)
        {
            var strNumbers = str.Split(' ');
            var numbers = new int[strNumbers.Length];
            for (int i = 0; i < strNumbers.Length; i++)
            {
                numbers[i] = ToNumber(strNumbers[i]);
            }
            return numbers;
        }

        private Boolean HasInvalidNumber(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number.Equals(InvalidNumber))
                    return true;
            }
            return false;
        }

        private int CalculateAverage(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        private int ToNumber(string strNumber)
        {
            return _numberDict.ContainsKey(strNumber) ? _numberDict[strNumber] : InvalidNumber;
        }

        private String ToString(int number)
        {
            return _numberDict.ContainsValue(number)
                ? _numberDict.First(x => x.Value == number).Key
                : InvalidStringNumber;
        }
    }
}
