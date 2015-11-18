using Kata.GildedRose.CSharp.Console;
using NUnit.Framework;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Kata.GildedRose.CSharp.Acceptance.Tests
{
    [Binding]
    public class UpdateStockInventorySteps
    {
        Program GildedRoseConsole;
        string _name = "+5 Dexterity Vest";
        int _quality = 10;
        int _sellin = 10;
        
        public void Setup()
        {
            GildedRoseConsole = new Program()
            {
                Items = new List<Item> { new Item { Name = _name, SellIn = _sellin, Quality = _quality } }
            };
        }

        [Given(@"an item with quality of (.*)")]
        public void GivenAnItemWithQualityOf(int quality)
        {
            _quality = quality;
        }
        
        [Given(@"an item with a sell in of (.*)")]
        public void GivenAnItemWithASellInOf(int sellin)
        {
            _sellin = sellin;
        }
        
        [Given(@"an item with the name ""(.*)""")]
        public void GivenAnItemWithTheName(string name)
        {
            _name = name;
        }
        
        [When(@"the system updates the stock inventory")]
        public void WhenTheSystemUpdatesTheStockInventory()
        {
            Setup();
            GildedRoseConsole.UpdateQuality();
        }

        [Then(@"the item should have a quality of (.*)")]
        public void ThenTheItemShouldHaveAQualityOf(int quality)
        {
            Assert.AreEqual(GildedRoseConsole.Items[0].Quality, quality);
        }

        [Then(@"the item should have a sell in of (.*)")]
        public void ThenTheItemShouldHaveASellInOf(int sellin)
        {
            Assert.AreEqual(GildedRoseConsole.Items[0].Quality, sellin);
        }
    }
}
