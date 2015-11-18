using Kata.GildedRose.CSharp.Common.Testing;
using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Console;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Kata.GildedRose.CSharp.Acceptance.Tests
{
    [Binding]
    public class UpdateStockInventorySteps : WhenTestingTheGildedRoseProgram
    {
        protected override void Setup()
        {
            StockItemUnderTest = ItemBuilder
            .Build
            .WithName(ActualName)
            .WithSellin(ActualSellinValue)
            .WithQuality(ActualQualityValue)
            .AnInstance();

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };

            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Given(@"an item with quality of (.*)")]
        public void GivenAnItemWithQualityOf(int quality)
        {
            ActualQualityValue = quality;
        }
        
        [Given(@"an item with a sell in of (.*)")]
        public void GivenAnItemWithASellInOf(int sellin)
        {
            ActualSellinValue = sellin;
        }
        
        [Given(@"an item with the name ""(.*)""")]
        public void GivenAnItemWithTheName(string name)
        {
            ActualName = name;
        }
        
        [When(@"the system updates the stock inventory")]
        public void WhenTheSystemUpdatesTheStockInventory()
        {
            ArrangeAndAct();
        }

        [Then(@"the item should have a quality of (.*)")]
        public void ThenTheItemShouldHaveAQualityOf(int quality)
        {
            Assert.AreEqual(quality, GetFirstItemInInventory().Quality);
        }

        [Then(@"the item should have a sell in of (.*)")]
        public void ThenTheItemShouldHaveASellInOf(int sellin)
        {
            Assert.AreEqual(sellin, GetFirstItemInInventory().SellIn);
        }

        [Then(@"the item should have a quality less than or equal to (.*)")]
        public void ThenTheItemShouldHaveAQualityLessThanOrEqualTo(int quality)
        {
            Assert.LessOrEqual(GetFirstItemInInventory().Quality, quality);
        }

        [Then(@"the item should never have a quality equal to a negative value (.*)")]
        public void ThenTheItemShouldNeverHaveAQualityEqualToANegativeValue(int expectedQuality)
        {
            Assert.AreNotEqual(expectedQuality, GetFirstItemInInventory().Quality);
        }

    }
}
