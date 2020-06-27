using System;

namespace Kata
{
    public class BandName
    {
        public static string BandNameGenerator(string noun)
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

        private static string GenerateBandName(string noun)
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

        private static bool IsStartSameAsLast(string noun)
        {
            char firstWord = noun[0];
            char lastWord = noun[noun.Length-1];
            return firstWord == lastWord;
        }

        private static string RepeatNoun(string noun)
        {
            return Char.ToUpper(noun[0]) + noun.Substring(1) + noun.Substring(1);
        }

        private static string AddTheToNoun(string noun)
        {
            return "The " + Char.ToUpper(noun[0]) + noun.Substring(1);
        }
    }
}
