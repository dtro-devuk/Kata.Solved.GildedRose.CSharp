using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.BehaviourTests.Quality.Backstage_passes
{
    [TestFixture]
    public class AndHaveNoValueAfterTheConcert : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            //Sell by date 0 = sellby date passed

            ActualQualityValue = 10;
            ActualSellinValue = 0;
            ExpectedQualityValue = 0;

            StockItemUnderTest = ItemBuilder
                .Build
                .WithName("Backstage passes to a TAFKAL80ETC concert")
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldReturnNoValue()
        {
            ArrangeAndAct();

            Assert.AreEqual(ExpectedQualityValue, GetFirstItemInInventory().Quality);
        }

    }
}
