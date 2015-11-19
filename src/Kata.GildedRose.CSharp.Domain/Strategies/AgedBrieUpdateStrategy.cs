namespace Kata.GildedRose.CSharp.Domain.Strategies
{
    public class AgedBrieUpdateStrategy : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality < 50) item.Quality++;
        }
    }
}