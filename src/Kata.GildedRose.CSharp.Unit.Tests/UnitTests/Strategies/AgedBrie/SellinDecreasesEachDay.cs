using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Strategies.AgedBrie
{
    [TestFixture]
    public class SellinDecreasesEachDay : AndUpdateItemIsCalled
    {
        [Test]
        public void Strategy_Sellin_ItShouldReduceEachDay()
        {
            ActualQualityValue = 10;
            ActualSellinValue = 10;
            ExpectedSellinValue = 9;

            ArrangeAndAct();
            Assert.AreEqual(ExpectedSellinValue, StockItem.SellIn);
        }
    }
}
