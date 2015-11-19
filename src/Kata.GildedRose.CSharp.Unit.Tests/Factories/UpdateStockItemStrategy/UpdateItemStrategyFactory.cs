using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Unit.Tests.Factories.UpdateStockItemStrategy
{
    public class UpdateItemStrategyFactory : IUpdateItemStrategyFactory
    {
        public IStockItemUpdateStrategy Create(Item stockItem)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    _updateStrategy = new AgedBrieUpdateStrategy();
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    _updateStrategy = new BackStagePassesUpdateStrategy();
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    _updateStrategy = new LegendaryItemsUpdateStratgey();
                    break;
                default:
                    _updateStrategy = new StandardItemsUpdateStrategy();
                    break;
            }
        }
    }
}