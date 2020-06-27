using System;
using System.Collections.Generic;

namespace Kata
{
    public class DuplicateString
    {
        public static int DuplicateCount(string str)
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

        private static int CalculateDuplicateCount(string input)
        {
            Dictionary<char, int> charCount = GenerateCharCount(input);
            return CalculateDuplicateCount(charCount);
        }

        private static Dictionary<char, int> GenerateCharCount(string input)
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

        private static int CalculateDuplicateCount(Dictionary<char, int> charCount)
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
