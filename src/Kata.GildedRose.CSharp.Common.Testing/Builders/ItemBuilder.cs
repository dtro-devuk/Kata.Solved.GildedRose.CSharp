using Kata.GildedRose.CSharp.Console;

namespace Kata.GildedRose.CSharp.Common.Testing.Builders
{
    /// <summary>
    /// Returns a builder class of Item for Testing
    /// </summary>
    public class ItemBuilder : Builder<ItemBuilder, Item>
    {
        string _name = "+5 Dexterity Vest";
        int _sellin = 10;
        int _quality = 10;

        public override Item AnInstance()
        {
            return new Item
            {
                Name = _name,
                SellIn = _sellin,
                Quality = _quality
            };
        }

        public ItemBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public ItemBuilder WithSellin(int sellin)
        {
            _sellin = sellin;
            return this;
        }

        public ItemBuilder WithQuality(int quality)
        {
            _quality = quality;
            return this;
        }
    }
}
