using Kata.GildedRose.CSharp.Console;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Common.Testing.Builders
{
    public class ItemCollectionBuilder : Builder<ItemCollectionBuilder, IEnumerable<Item>>
    {
        private Item _item = ItemBuilder.Build.AnInstance();

        private IEnumerable<Item> _items;

        public ItemCollectionBuilder()
        {
            _items = new List<Item> { _item };
        }

        public override IEnumerable<Item> AnInstance()
        {
            return _items;
        }

        public ItemCollectionBuilder WithItems(IList<Item> items)
        {
            _items = items;
            return this;
        }
    }
}
