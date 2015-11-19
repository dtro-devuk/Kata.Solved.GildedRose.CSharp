using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Console
{
    public class StandardItemsUpdater
    {
        public void StandardItemsUpdate(Item item)
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