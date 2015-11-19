using Kata.GildedRose.CSharp.Domain;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Console
{
    public class Program
    {
        public IList<Item> Items;
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
                switch (item.Name)
                {
                    case "Aged Brie":
                        AgedBrieUpdator(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        BackStagePassesUpdater(item);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        LegendaryItemsUpdater(item);
                        break;
                    default:
                        StandardItemsUpdater(item);
                        break;
                }
            }
        }

        protected void LegendaryItemsUpdater(Item item)
        {
            //Do Nothing
        }

        protected void StandardItemsUpdater(Item item)
        {
            item.SellIn--;
            if (item.Quality > 0) item.Quality--;
            if (item.SellIn < 0)
            {
                if (item.Quality > 0) item.Quality--;
            }
        }

        protected void BackStagePassesUpdater(Item item)
        {
            item.SellIn--;

            if (item.Quality < 50) item.Quality++;

            if (item.SellIn < 10)
            {
                if (item.Quality < 50) item.Quality++;
            }
            if (item.SellIn < 5)
            {
                if (item.Quality < 50) item.Quality++;
            }
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }

        protected void AgedBrieUpdator(Item item)
        {
            item.SellIn--;
            if (item.Quality < 50) item.Quality++;
        }
    }
}