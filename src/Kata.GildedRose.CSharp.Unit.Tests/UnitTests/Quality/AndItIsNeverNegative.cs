using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Quality
{
    [TestFixture]
    public class AndItIsNeverNegative : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            ActualSellinValue = 0;
            ActualQualityValue = 0;
            ExpectedQualityValue = 0;

            //Create stock item to test
            var StockItemUnderTest = ItemBuilder
                .Build
                .WithName("+5 Dexterity Vest")
                .WithSellin(ActualSellinValue)
                .WithQuality(ActualQualityValue)
                .AnInstance();

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            //Set items on ItemUnderTest
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [TestCase("+5 Dexterity Vest", 0, 0, -1)]
        [TestCase("Aged Brie", 0, 0, -1)]
        [TestCase("Sulfuras, Hand of Ragnaros", 0, 0, -1)]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 0, 0, -1)]
        public void ItShouldNeverBeNegative(string actualName, int actualQuality, int actualSellin, int expectedQuality)
        {
            ActualName = actualName;
            ActualQualityValue = actualQuality;
            ActualSellinValue = actualSellin;
            ArrangeAndAct();

            Assert.AreNotEqual(expectedQuality, GetFirstItemInInventory().Quality);

        }
    }
}
