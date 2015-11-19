using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Strategies.Conjured
{
    [TestFixture]
    public class QualityDecreasesTwiceAsFastEachDay : AndUpdateItemIsCalled
    {
        [TestCase(10, 10, 8)]
        [TestCase(11, 10, 9)]
        public void Strategy_Quality_ItShouldDecreaseTwiceAsFast(int quality, int sellin, int expectedQuality)
        {
            ActualQualityValue = quality;
            ActualSellinValue = sellin;

            ArrangeAndAct();
            Assert.AreEqual(expectedQuality, StockItem.Quality);
        }
    }
}
