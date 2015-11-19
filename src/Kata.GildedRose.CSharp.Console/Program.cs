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
                if (item.Name == "Sulfuras, Hand of Ragnaros") { continue; }

                if (item.Name == "Aged Brie")
                {
                    if (item.Quality < 50) item.Quality++;
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.Quality < 50) item.Quality++;

                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50) item.Quality++;
                    }
                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50) item.Quality++;
                    }
                }
                else
                {
                    if (item.Quality > 0) item.Quality--;
                }

                item.SellIn--;

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.Quality > 0) item.Quality--;
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        if (item.Quality < 50) item.Quality++;
                    }
                }
            }
        }
    }
}