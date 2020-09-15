using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class GoodsCache
    {
        public List<Goods> PriceChange { get; set; }
        
        public List<Goods> New { get; set; }
        
        public List<Goods> Delete { get; set; }

        public List<Goods> Current { get; set; } = new List<Goods>();

        public void UpdateGoods(List<Goods> latestGoods)
        {
            PriceChange = latestGoods.Intersect(Current, new GoodsPriceCompare()).ToList();
            
            New = latestGoods.Except(Current).ToList();
            Delete = Current.Except(latestGoods).ToList();

            Current = latestGoods;
        }
    }

    public class GoodsPriceCompare : IEqualityComparer<Goods>
    {
        public bool Equals(Goods goods1, Goods goods2)
        {
            return goods1.Id == goods2.Id && goods1.Price != goods2.Price;
        }

        public int GetHashCode(Goods goods)
        {
            return goods.GetHashCode();
        }
    }

    public class Goods
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Goods goods)
            {
                return goods.Id == Id;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}