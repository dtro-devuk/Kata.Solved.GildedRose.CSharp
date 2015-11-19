using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Console
{
    public class BackStagePassesUpdater
    {
        public void BackStagePassesUpdate(Item item)
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