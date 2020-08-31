using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    // https://www.codewars.com/kata/56c30ad8585d9ab99b000c54
    // 5 kyu
    public class PlayWithTwoStrings
    {
        public string WorkOnStrings(string a, string b)
        {
            return String.Concat(a.ToCharArray().Select(c => GetResult(b.ToLower().ToCharArray().GroupBy(i => i).Where(i => i.Key == Convert.ToString(c).ToLower().ToCharArray()[0]).SelectMany(i => i).Count(), c))) +
                   String.Concat(b.ToCharArray().Select(c => GetResult(a.ToLower().ToCharArray().GroupBy(i => i).Where(i => i.Key == Convert.ToString(c).ToLower().ToCharArray()[0]).SelectMany(i => i).Count(), c)));
        }

        private char GetResult(int count, char c)
        {
            return count % 2 == 0 ? c : 
                ( c >= 65 && c <= 90) ? (char)(c + 32) :
                ( c >= 97 && c <= 122) ? (char)(c - 32) :
                c ;
        }
    }
}
