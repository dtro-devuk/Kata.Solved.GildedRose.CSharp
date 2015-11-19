namespace Kata.GildedRose.CSharp.Domain
{
    public class UpdateItemStrategyFactory : IUpdateItemStrategyFactory
    {
        public IStockItemUpdateStrategy Create(Item stockItem)
        {
            return new AgedBrieUpdateStrategy();
        }
    }
}