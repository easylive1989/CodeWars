using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    // https://www.codewars.com/kata/555624b601231dc7a400017a/train/csharp
    // 5 kyu
    public class JosephusSurvivor
    {
        public int Play(int count, int step)
        {
            return FindSurvivor(Candidates(count), 0, step);
        }

        private static List<int> Candidates(int count)
        {
            return Enumerable.Range(1, count).ToList();
        }

        private static int FindSurvivor(List<int> candidates, int start, int step)
        {
            if (HasSurvivor(candidates))
            {
                return candidates.First();
            }
            
            var victim = CalculateVictim(start, step, candidates.Count());
            return FindSurvivor(NextCandidate(candidates, victim), victim, step);
        }

        private static List<int> NextCandidate(List<int> candidates, int victim)
        {
            return candidates.Where((candidate, index) => index != victim).ToList();
        }

        private static int CalculateVictim(int start, int step, int count)
        {
            return (start + step - 1) % count;
        }

        private static bool HasSurvivor(List<int> candidates)
        {
            return candidates.Count() == 1;
        }
    }
}