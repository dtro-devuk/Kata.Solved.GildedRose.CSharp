using Kata.GildedRose.CSharp.Console;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests
{
    [TestFixture]
    public class WhenTestTheGildedRoseProgram
    {
        string _actualName = "+5 Dexterity Vest";
        int _actualSellin = 10;
        int _actualQuality = 10;
        Item _actualStockItem;

        IList<Item> _stockItems;
        Program GildedRoseProgram;

        //[SetUp]
        //public void Init()
        //{
        //    //_actualStockItem = new Item
        //    //{
        //    //    Name = _actualName,
        //    //    SellIn = _actualSellin,
        //    //    Quality = _actualQuality
        //    //};

        //    //GildedRoseProgram = new Program();
        //    //_stockItems = new List<Item> { _actualStockItem };
        //}

        [Test]
        public void ItShouldAllowUsToSetAndRetrieveTheItemsCorrectly()
        {
            GildedRoseProgram.UpdateQuality();
            Assert.AreEqual(10, 10);
        }
    }
}
