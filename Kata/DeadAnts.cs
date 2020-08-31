using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kata
{
    // https://www.codewars.com/kata/57d5e850bfcdc545870000b7
    // 6 kyu
    public class DeadAnts
    {
        public int DeadAntCount(string ants)
        {
            if(ants != null)
            {
                return FindDeadAntCount(ants);
            }
            else
            {
                return 0;
            }
        }

        private int FindDeadAntCount(String ants)
        {
            String deadAntsCollections = FindDeadAntsCollections(ants);
            return CalculateDeadAntCount(deadAntsCollections);
        }

        private string FindDeadAntsCollections(string ants)
        {
            string pattern = "ant|[^ant]";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            return rgx.Replace(ants, replacement);
        }

        private int CalculateDeadAntCount(String deadAntsCollections)
        {
            int antHeadCount = 0, antBodyCount = 0, antLegCount = 0;
            foreach(char partOfAnt in deadAntsCollections.ToCharArray())
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
