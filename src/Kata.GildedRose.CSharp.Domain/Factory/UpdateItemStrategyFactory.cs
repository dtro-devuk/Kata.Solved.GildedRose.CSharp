using Kata.GildedRose.CSharp.Domain.Strategies;
using System;

namespace Kata.GildedRose.CSharp.Domain.Factory
{
    public class UpdateItemStrategyFactory : IUpdateItemStrategyFactory
    {
        public IStockItemUpdateStrategy Create(Item item)
        {
            if (item == null){
                throw new ArgumentNullException(nameof(item));
            }

            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieUpdateStrategy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackStagePassesUpdateStrategy();
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryItemsUpdateStratgey();
                case "Conjured Mana Cake":
                    return new ConjuredUpdateStrategy();
                default:
                    return new StandardItemsUpdateStrategy();
            }
        }
    }
}