using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class MyNumbers
    {
        public int[] RemoveDuplicated(int[] numbers)
        {
            return numbers.Reverse().Distinct().Reverse().ToArray();
        }
    }
}