namespace Kata.GildedRose.CSharp.Domain.Strategies
{
    public class BackStagePassesUpdateStrategy : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
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
    }
}