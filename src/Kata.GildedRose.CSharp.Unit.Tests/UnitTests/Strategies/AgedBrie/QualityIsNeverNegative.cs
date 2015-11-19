using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Strategies.AgedBrie
{
    [TestFixture]
    public class QualityIsNeverNegative : AndUpdateItemIsCalled
    {
        [Test]
        public void Strategy_Quality_ItShouldNeverBeNegative()
        {
            ActualQualityValue = 0;
            ActualSellinValue = 0;

            ArrangeAndAct();
            Assert.AreNotEqual(-1, StockItem.Quality);
        }
    }
}
