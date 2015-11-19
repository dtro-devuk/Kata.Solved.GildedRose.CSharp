namespace Kata.GildedRose.CSharp.Domain
{
    public class LegendaryItemsUpdateStratgey : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn = item.SellIn;
            item.Quality = item.Quality;
        }
    }
}