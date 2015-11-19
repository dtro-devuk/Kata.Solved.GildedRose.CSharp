using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Strategies.AgedBrie
{
    [TestFixture]
    public class QualityIncreasesEachDay : AndUpdateItemIsCalled
    {
        [TestCase(10, 10, 11)]
        [TestCase(11, 10, 12)]
        public void Strategy_Quality_ItShouldIncreaseEachDay(int quality, int sellin, int expectedQuality)
        {
            ActualQualityValue = quality;
            ActualSellinValue = sellin;

            ArrangeAndAct();
            Assert.AreEqual(expectedQuality, StockItem.Quality);
        }
    }
}
