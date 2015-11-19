namespace Kata.GildedRose.CSharp.Domain.Factory
{
    public class UpdateItemStrategyFactory : IUpdateItemStrategyFactory
    {
        public IStockItemUpdateStrategy Create(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieUpdateStrategy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackStagePassesUpdateStrategy();
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItemsUpdateStratgey();
                default:
                    return new StandardItemsUpdateStrategy();
            }
        }
    }
}