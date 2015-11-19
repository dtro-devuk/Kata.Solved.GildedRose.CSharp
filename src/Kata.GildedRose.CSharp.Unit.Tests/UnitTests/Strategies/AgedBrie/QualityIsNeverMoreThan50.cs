using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Strategies.AgedBrie
{
    [TestFixture]
    public class QualityIsNeverMoreThan50 : AndUpdateItemIsCalled
    {
        [Test]
        public void Strategy_Quality_ItShouldNeverBeMoreThan50()
        {
            ActualQualityValue = 50;

            ArrangeAndAct();
            Assert.LessOrEqual(StockItem.Quality, 50);
        }
    }
}
