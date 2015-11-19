namespace Kata.GildedRose.CSharp.Domain.Strategies
{
    public class StandardItemsUpdateStrategy : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            if (item.Quality > 0) item.Quality--;
            if (item.SellIn < 0)
            {
                if (item.Quality > 0) item.Quality--;
            }
        }
    }
}