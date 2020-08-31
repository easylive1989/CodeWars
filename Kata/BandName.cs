using System;

namespace Kata
{
    // https://www.codewars.com/kata/59727ff285281a44e3000011
    // 7 kyu
    public class BandName
    {
        public string BandNameGenerator(string noun)
        {
            if(String.IsNullOrEmpty(noun))
            {
                return "";
            }
            else
            {
                return GenerateBandName(noun);
            }
        }

        private string GenerateBandName(string noun)
        {
            bool isStartSameAsLast = IsStartSameAsLast(noun);
            if (isStartSameAsLast)
            {
                return RepeatNoun(noun);
            }
            else
            {
                return AddTheToNoun(noun);
            }
        }

        private bool IsStartSameAsLast(string noun)
        {
            char firstWord = noun[0];
            char lastWord = noun[noun.Length-1];
            return firstWord == lastWord;
        }

        private string RepeatNoun(string noun)
        {
            return Char.ToUpper(noun[0]) + noun.Substring(1) + noun.Substring(1);
        }

        private string AddTheToNoun(string noun)
        {
            return "The " + Char.ToUpper(noun[0]) + noun.Substring(1);
        }
    }
}
