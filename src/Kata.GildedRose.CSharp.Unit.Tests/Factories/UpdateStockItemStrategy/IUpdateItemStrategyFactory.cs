using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Unit.Tests.Factories.UpdateStockItemStrategy
{
    public interface IUpdateItemStrategyFactory
    {
        IStockItemUpdateStrategy Create(Item item);
    }
}