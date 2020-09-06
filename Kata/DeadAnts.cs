using System.Linq;
using System.Text.RegularExpressions;

namespace Kata
{
    // https://www.codewars.com/kata/57d5e850bfcdc545870000b7
    // 6 kyu
    public class DeadAnts
    {
        public int Count(string ants)
        {
            if (string.IsNullOrEmpty(ants))
            {
                return 0;
            }

            return CalculateDeadAntCount(FindDeadAnts(FindDeadAnts(ants)));
        }

        private string FindDeadAnts(string ants)
        {
            return new Regex("ant|[^ant]").Replace(ants, "");
        }

        private int CalculateDeadAntCount(string deadAntsCollections)
        {
            if (string.IsNullOrEmpty(deadAntsCollections))
            {
                return 0;
            }

            return deadAntsCollections.GroupBy(x => x).Max(x => x.Count());
        }
    }
}
