using System.Collections.Generic;
using Kata;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class GoodsCacheTests
    {
        [Test]
        public void PriceChange()
        {
            var myStock = new GoodsCache
            {
                Current = new List<Goods>() {new Goods() {Id = 3, Price = 2}, new Goods() {Id = 2, Price = 3,}}
            };
            
            myStock.UpdateGoods(new List<Goods>()
            {
                new Goods()
                {
                    Id = 1,
                    Price = 2
                },
                new Goods()
                {
                    Id = 2,
                    Price = 4,
                }
            });

            CollectionAssert.AreEqual(new List<Goods>()
            {
                new Goods()
                {
                    Id = 2,
                    Price = 4,
                }
            }, myStock.PriceChange);
        }
        
        [Test]
        public void New()
        {
            var myStock = new GoodsCache
            {
                Current = new List<Goods>() {new Goods() {Id = 3, Price = 2}, new Goods() {Id = 2, Price = 3,}}
            };
            
            myStock.UpdateGoods(new List<Goods>()
            {
                new Goods()
                {
                    Id = 1,
                    Price = 2
                },
                new Goods()
                {
                    Id = 2,
                    Price = 4,
                }
            });

            CollectionAssert.AreEqual(new List<Goods>()
            {
                new Goods()
                {
                    Id = 1,
                    Price = 2,
                }
            }, myStock.New);
        }
        
        [Test]
        public void Delete()
        {
            var myStock = new GoodsCache
            {
                Current = new List<Goods>() {new Goods() {Id = 3, Price = 2}, new Goods() {Id = 2, Price = 3,}}
            };
            
            myStock.UpdateGoods(new List<Goods>()
            {
                new Goods()
                {
                    Id = 1,
                    Price = 2
                },
                new Goods()
                {
                    Id = 2,
                    Price = 4,
                }
            });

            CollectionAssert.AreEqual(new List<Goods>()
            {
                new Goods()
                {
                    Id = 3,
                    Price = 2,
                }
            }, myStock.Delete);
        }
    }
}