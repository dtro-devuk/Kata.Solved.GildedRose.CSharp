namespace Kata.GildedRose.CSharp.Domain.Factory
{
    public interface IUpdateItemStrategyFactory
    {
        IStockItemUpdateStrategy Create(Item item);
    }
}