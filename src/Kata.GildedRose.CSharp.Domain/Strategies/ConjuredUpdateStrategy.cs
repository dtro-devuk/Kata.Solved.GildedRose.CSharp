namespace Kata.GildedRose.CSharp.Domain.Strategies
{
    public class ConjuredUpdateStrategy : IStockItemUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            item.Quality -= 2;
            if (item.SellIn > 0)
                item.SellIn--;
            if (item.SellIn <= 0)
                item.Quality -= 2;
        }
    }
}