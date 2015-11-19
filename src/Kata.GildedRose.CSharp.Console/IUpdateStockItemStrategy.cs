using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Console
{
    public interface IStockItemUpdateStrategy
    {
        void UpdateItem(Item item);
    }
}