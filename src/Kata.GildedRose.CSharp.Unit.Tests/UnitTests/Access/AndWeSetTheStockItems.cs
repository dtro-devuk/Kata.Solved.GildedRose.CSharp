using NUnit.Framework;
using Kata.GildedRose.CSharp.Domain;
using System.Collections.Generic;
using Kata.GildedRose.CSharp.Common.Testing;
using Kata.GildedRose.CSharp.Common.Testing.Builders;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Access
{
    [TestFixture]
    public class AndWeSetTheStockItems : WhenTestingTheGildedRoseProgram
    {
        //Override for more local setup
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

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldAllowUsToSetAndRetrieveTheItemsCorrectly()
        {
            ArrangeAndAct();
            Assert.AreEqual(StockItemUnderTest, GildedRoseConsole.Items[0]);
        }

        [Test]
        public void ItShouldAllowUsAllowUsToUpdateItemsCorrectly()
        {
            ArrangeAndAct();
            Assert.AreEqual(StockItemUnderTest, GildedRoseConsole.Items[0]);
        }
    }
}
