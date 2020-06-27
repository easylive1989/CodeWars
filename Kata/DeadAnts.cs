using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kata
{
    public class DeadAnts
    {
        public static int DeadAntCount(string ants)
        {
            if(ants != null)
            {
                return findDeadAntCount(ants);
            }
            else
            {
                return 0;
            }
        }

        private static int findDeadAntCount(String ants)
        {
            String deadAntsCollections = findDeadAntsCollections(ants);
            return calculateDeadAntCount(deadAntsCollections);
        }

        private static string findDeadAntsCollections(string ants)
        {
            string pattern = "ant|[^ant]";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            return rgx.Replace(ants, replacement);
        }

        private static int calculateDeadAntCount(String deadAntsCollections)
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
