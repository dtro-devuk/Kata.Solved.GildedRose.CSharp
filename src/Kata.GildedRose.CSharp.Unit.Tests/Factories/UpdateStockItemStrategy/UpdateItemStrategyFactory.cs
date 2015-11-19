using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Unit.Tests.Factories.UpdateStockItemStrategy
{
    public class UpdateItemStrategyFactory : IUpdateItemStrategyFactory
    {
        public IStockItemUpdateStrategy Create(Item stockItem)
        {
            return new AgedBrieUpdateStrategy();
        }
    }
}