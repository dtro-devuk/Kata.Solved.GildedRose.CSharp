using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.BehaviourTests.Quality.Legends
{
    [TestFixture]
    public class AndItemsNeverNeedToBeSold : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            ExpectedQualityValue = 10;
            ActualQualityValue = 10;
            ActualSellinValue = 10;
            ActualName = "Sulfuras, Hand of Ragnaros";

            StockItemUnderTest = ItemBuilder
                .Build
                .WithName(ActualName)
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldAlwaysHaveTheSameValue()
        {
            ArrangeAndAct();
            Assert.AreEqual(ExpectedQualityValue, GetFirstItemInInventory().Quality);
        }
    }
}
