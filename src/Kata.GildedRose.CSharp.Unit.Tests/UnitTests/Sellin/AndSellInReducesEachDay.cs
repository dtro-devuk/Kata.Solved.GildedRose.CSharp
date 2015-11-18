using Kata.GildedRose.CSharp.Common.Testing;
using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Console;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Sellin
{
    [TestFixture]
    public class AndSellInReducesEachDay : WhenTestingTheGildedRoseProgram
    {
        protected override void Setup()
        {
            ActualSellinValue = 10;
            ActualQualityValue = 10;

            StockItemUnderTest = ItemBuilder
                .Build
                .WithName("+5 Dexterity Vest")
                .WithSellin(ActualSellinValue)
                .WithQuality(ActualQualityValue)
                .AnInstance();

            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldReturnALowerValue()
        {
            ArrangeAndAct();
            Assert.Less(GetFirstItemInInventory().SellIn, ActualSellinValue);
        }

        [Test]
        public void ItShouldDecreaseByAFactorOfOne()
        {
            ArrangeAndAct();

            var factor = ActualSellinValue - GetFirstItemInInventory().SellIn;

            Assert.AreEqual(1, factor);
        }
    }
}
