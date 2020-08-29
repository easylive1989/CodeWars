using System.Collections.Generic;

namespace Kata
{
    public class MyMath
    {
        public List<int> FindPrimes(List<int> n)
        {
            var x = new List<int>();
            for (int i = 0; i < n.Count; i++)
            {
                if (n[i] == 2)
                {
                    x.Add(n[i]);
                }
                else
                {
                    for (int j = 2; j <= n[i]; j++)
                    {
                        if (n[i] % j == 0)
                        {
                            break;
                        }

                        if (n[i] == j)
                        {
                            x.Add(n[i]);
                        }
                    }
                }
            }

            return x;


            // var results = new List<int>();
            // foreach (var number in numbers)
            // {
            //     if (number == 2)
            //     {
            //         results.Add(number);
            //     }
            //     else
            //     {
            //         for (int modulo = 2; modulo <= number; modulo++)
            //         {
            //             if (number % modulo == 0)
            //             {
            //                 break;
            //             }
            //
            //             if (number == modulo)
            //             {
            //                 results.Add(number);
            //             }
            //         }
            //     }
            // }
            //
            // return results;
            //return numbers.Where(x => x == 2 || Enumerable.Range(2, x - 2).All(y => x % y != 0)).ToList();
        }
    }
}