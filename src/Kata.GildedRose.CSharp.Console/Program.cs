using Kata.GildedRose.CSharp.ConsoleApp.Ninject;
using Kata.GildedRose.CSharp.Domain;
using Kata.GildedRose.CSharp.Domain.Factory;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Console
{
    public class Program
    {
        IUpdateItemStrategyFactory UpdateStrategyFactory { get; set; }
        public IList<Item> Items; //You can't touch this

        public Program(IUpdateItemStrategyFactory strategyFactory)
        {
            UpdateStrategyFactory = strategyFactory;
        }

        //[Ninject.Inject]
        //public void SetUpdateItemStrategyFactory(IUpdateItemStrategyFactory strategyFactory)
        //{
        //    UpdateStrategyFactory = strategyFactory;
        //}

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            //Do IOC using Ninject
            var ioc = new Ioc();
            var updateStrategy = ioc.Resolve<IUpdateItemStrategyFactory>();

            var app = new Program(updateStrategy)
            {
                Items = GetDefaultInventory()
            };
            //app.SetUpdateItemStrategyFactory(updateStrategy);

            app.UpdateQuality();

            System.Console.ReadKey();
        }

        public static List<Item> GetDefaultInventory()
        {
            return new List<Item>
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
                };
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                System.Console.WriteLine(item.Name + " : " + item.Quality.ToString() );
                var strategy = UpdateStrategyFactory.Create(item);
                strategy.UpdateItem(item);
            }
        }
    }
}