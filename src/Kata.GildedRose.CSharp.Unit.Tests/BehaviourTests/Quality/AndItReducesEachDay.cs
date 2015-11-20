using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.BehaviourTests.Quality
{
    [TestFixture]
    public class AndItReducesEachDay : WhenTestingTheQuality
    {
        protected override void Setup()
        {
            ActualSellinValue = 10;
            ActualQualityValue = 10;
            base.Setup();

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GildedRoseConsole.Items = StockItemsUnderTest;

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            //Set items on ItemUnderTest
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldReturnALowerValue()
        {
            ArrangeAndAct();

            Assert.Less(GetFirstItemInInventory().Quality, ActualQualityValue);
        }

        [Test]
        public void ItShouldDecreaseByAFactorOfOne()
        {
            ArrangeAndAct();

            var factor = ActualQualityValue - GetFirstItemInInventory().Quality;

            Assert.AreEqual(1, factor);
        }

    }
}
