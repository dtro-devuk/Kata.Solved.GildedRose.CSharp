using Kata.GildedRose.CSharp.Domain.Strategies;
using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public class AndItemIsABackStagePass : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "Backstage passes to a TAFKAL80ETC concert";
            base.Setup();
        }

        [Test]
        public void Factory_BackStagePass_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<BackStagePassesUpdateStrategy>(Result);
        }
    }
}
