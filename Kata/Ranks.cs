using System.Linq;

namespace Kata
{
    // https://www.codewars.com/kata/5420fc9bb5b2c7fd57000004
    // 6 kyu
    public class Ranks
    {
        public int Highest(int[] ranks)
        {
            return ranks.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenByDescending(x => x.Key).First().Key;
        }
    }
}