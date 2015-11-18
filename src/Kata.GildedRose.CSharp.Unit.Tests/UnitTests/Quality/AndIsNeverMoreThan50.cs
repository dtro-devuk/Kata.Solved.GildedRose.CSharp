using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Quality
{
    [TestFixture]
    public class AndIsNeverMoreThan50 : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            StockItemUnderTest = ItemBuilder
                .Build
                .WithName(ActualName)
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [TestCase("+5 Dexterity Vest", 50, 0, 50)]
        [TestCase("Aged Brie", 50, 0, 50)]
        [TestCase("Sulfuras, Hand of Ragnaros", 50, 10, 50)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 50, 0, 50)]
        public void ItShouldNeverBeGreaterThanTheExpectedValue(string actualName, int actualQuality, int actualSellin, int expectedQuality)
        {
            ActualName = actualName;
            ActualQualityValue = actualQuality;
            ActualSellinValue = actualSellin;

            ArrangeAndAct();

            Assert.LessOrEqual(GetFirstItemInInventory().Quality, expectedQuality);
        }
}
}
