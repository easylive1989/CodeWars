using System;
using System.Text.RegularExpressions;

namespace Kata
{
    // https://www.codewars.com/kata/57d5e850bfcdc545870000b7
    // 6 kyu
    public class DeadAnts
    {
        public int DeadAntCount(string ants)
        {
            if (ants == null)
            {
                return 0;
            }

            return CalculateDeadAntCount(FindDeadAntsCollections(ants));
        }

        private string FindDeadAntsCollections(string ants)
        {
            return new Regex("ant|[^ant]").Replace(ants, "");
        }

        private int CalculateDeadAntCount(String deadAntsCollections)
        {
            int antHeadCount = 0, antBodyCount = 0, antLegCount = 0;
            foreach(char partOfAnt in deadAntsCollections)
            {
                if (partOfAnt == 'a')
                    antHeadCount++;
                else if (partOfAnt == 'n')
                    antBodyCount++;
                else if (partOfAnt == 't')
                    antLegCount++;
            
            }
            return Math.Max(antHeadCount, Math.Max(antBodyCount, antLegCount));
        }

    }
}
