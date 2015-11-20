using NUnit.Framework;
using Kata.GildedRose.CSharp.Domain;
using System.Collections.Generic;
using Kata.GildedRose.CSharp.Common.Testing;

namespace Kata.GildedRose.CSharp.Unit.Tests.BehaviourTests.Access
{
    [TestFixture]
    public class AndWeUpdateTheQuality : WhenTestingTheGildedRoseProgram
    {
        //Override for more local setup
        protected override void Setup()
        {
            ActualSellinValue = 10;
            ActualQualityValue = 10;
            base.Setup();

            //Create stock items to test
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        [Test]
        public void ItShouldReduceQualityOnUpdate()
        {
            ArrangeAndAct();
            Assert.AreEqual(9, GildedRoseConsole.Items[0].Quality);
        }
    }
}
