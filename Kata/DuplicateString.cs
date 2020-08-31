using System;
using System.Collections.Generic;

namespace Kata
{
    // https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1
    // 6 kyu
    public class DuplicateString
    {
        public int DuplicateCount(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                string input = str.ToLower().Replace(" ", "");
                return CalculateDuplicateCount(input);
            }
            else
            {
                return 0;
            }
        }

        private int CalculateDuplicateCount(string input)
        {
            Dictionary<char, int> charCount = GenerateCharCount(input);
            return CalculateDuplicateCount(charCount);
        }

        private Dictionary<char, int> GenerateCharCount(string input)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            foreach (char character in input.ToCharArray())
            {
                if (count.ContainsKey(character))
                {
                    count[character]++;
                }
                else
                {
                    count[character] = 1;
                }
            }
            return count;
        }

        private int CalculateDuplicateCount(Dictionary<char, int> charCount)
        {
            int duplicateCount = 0;
            foreach (KeyValuePair<char, int> entry in charCount)
            {
                if (entry.Value > 1)
                {
                    duplicateCount++;
                }
            }
            return duplicateCount;
        }
    }
}
