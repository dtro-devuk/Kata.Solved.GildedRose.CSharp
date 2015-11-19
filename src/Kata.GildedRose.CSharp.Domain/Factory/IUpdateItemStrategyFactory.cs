using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Domain
{
    public interface IUpdateItemStrategyFactory
    {
        IStockItemUpdateStrategy Create(Item stockItem);
    }
}