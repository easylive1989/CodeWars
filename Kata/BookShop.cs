using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class BookShop
    {
        private readonly Dictionary<int, decimal> _discountDict = new Dictionary<int, decimal>()
        {
            {2, 0.95m},
            {3, 0.9m},
            {4, 0.8m},
            {5, 0.75m}
        };

        public decimal BuyHarryPotter(List<int> eachBookAmount)
        {
            if (eachBookAmount.Any(x => x > 0))
            {
                var maxCombination = eachBookAmount.Count(x => x > 0);
                return (_discountDict.ContainsKey(maxCombination)
                    ? maxCombination * 100 * _discountDict[maxCombination]
                    : maxCombination * 100) + BuyHarryPotter(eachBookAmount.Select(x => x > 0 ? x - 1 : x).ToList());
            }

            return 0;
        }
    }
}