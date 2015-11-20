using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.BehaviourTests.Quality
{
    [TestFixture]
    public class AndItReducesFasterEachDay : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            ActualSellinValue = 0;
            ActualQualityValue = 10;
            ExpectedQualityValue = 8;

            StockItemUnderTest = ItemBuilder
                .Build
                .WithName("Test Item")
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GildedRoseConsole.Items = StockItemsUnderTest;

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            //Set items on ItemUnderTest
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void AfterTheSellbyDateHasPassed_ItShouldDegradeTwiceAsFast()
        {
            ArrangeAndAct();
            Assert.AreEqual(ExpectedQualityValue, GetFirstItemInInventory().Quality);
        }

        [Test]
        public void AfterTheSellbyDateHasPassed_ItShouldDegradeByFactorOfTwo()
        {
            ArrangeAndAct();
            var currentQuality = GetFirstItemInInventory().Quality;
            var factor = ActualQualityValue - currentQuality;
            Assert.AreEqual(2, factor);
        }

    }
}
