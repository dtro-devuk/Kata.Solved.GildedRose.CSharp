using Kata.GildedRose.CSharp.Domain;
using Kata.GildedRose.CSharp.Domain.Factory;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Console
{
    public class Program
    {
        public IList<Item> Items;

        IUpdateItemStrategyFactory _updateFactory;

        public Program()
        {
            _updateFactory = new UpdateItemStrategyFactory();
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                    {
                        new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                        new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                        new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                        new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                        new Item
                            {
                                Name = "Backstage passes to a TAFKAL80ETC concert",
                                SellIn = 15,
                                Quality = 20
                            },
                        new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                    }
            };

            app.UpdateQuality();

            System.Console.ReadKey();
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var strategy = _updateFactory.Create(item);
                strategy.UpdateItem(item);
            }
        }
    }
}