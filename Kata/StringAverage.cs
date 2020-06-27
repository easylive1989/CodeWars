using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class StringAverage
    {

        private const int INVALID_NUMBER = -1;
        private const string INVALID_STRING_NUMBER = "n/a";

        public static string AverageString(string str)
        {
            if (str != null)
            {
                return DoAveragString(str);
            }
            else
            {
                return INVALID_STRING_NUMBER;
            }
        }

        private static string DoAveragString(string str)
        {
            string[] strNums = ToStringNumbers(str);
            int[] nums = ToNumbers(strNums);
            if (!ContainsInvalidNumber(nums))
            {
                int AverageNumber = CalculateAverage(nums);
                string AverageStrNumber = ToString(AverageNumber);
                return AverageStrNumber;
            }
            else
            {
                return INVALID_STRING_NUMBER;
            }
        }

        private static string[] ToStringNumbers(string str)
        {
            return str.Split(' ');
        }

        private static int[] ToNumbers(string[] strNumbers)
        {
            int[] numbers = new int[strNumbers.Length];
            for (int i = 0; i < strNumbers.Length; i++)
            {
                numbers[i] = ToNumber(strNumbers[i]);
            }
            return numbers;
        }

        private static Boolean ContainsInvalidNumber(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number.Equals(INVALID_NUMBER))
                    return true;
            }
            return false;
        }

        private static int CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        private static int ToNumber(string strNumber)
        {
            if (strNumber.Equals("zero"))
            {
                return 0;
            }
            else if (strNumber.Equals("one"))
            {
                return 1;
            }
            else if (strNumber.Equals("two"))
            {
                return 2;
            }
            else if (strNumber.Equals("three"))
            {
                return 3;
            }
            else if (strNumber.Equals("four"))
            {
                return 4;
            }
            else if (strNumber.Equals("five"))
            {
                return 5;
            }
            else if (strNumber.Equals("six"))
            {
                return 6;
            }
            else if (strNumber.Equals("seven"))
            {
                return 7;
            }
            else if (strNumber.Equals("eight"))
            {
                return 8;
            }
            else if (strNumber.Equals("nine"))
            {
                return 9;
            }
            else
            {
                return INVALID_NUMBER;
            }
        }

        private static String ToString(int number)
        {
            if (number == 0)
            {
                return "zero";
            }
            else if (number == 1)
            {
                return "one";
            }
            else if (number == 2)
            {
                return "two";
            }
            else if (number == 3)
            {
                return "three";
            }
            else if (number == 4)
            {
                return "four";
            }
            else if (number == 5)
            {
                return "five";
            }
            else if (number == 6)
            {
                return "six";
            }
            else if (number == 7)
            {
                return "seven";
            }
            else if (number == 8)
            {
                return "eight";
            }
            else if (number == 9)
            {
                return "nine";
            }
            else
            {
                return INVALID_STRING_NUMBER;
            }
        }
    }
}
