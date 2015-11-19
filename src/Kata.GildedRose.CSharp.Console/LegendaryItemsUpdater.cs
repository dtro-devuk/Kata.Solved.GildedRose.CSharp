using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Console
{
    public class LegendaryItemsUpdater : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn = item.SellIn;
            item.Quality = item.Quality;
        }
    }
}