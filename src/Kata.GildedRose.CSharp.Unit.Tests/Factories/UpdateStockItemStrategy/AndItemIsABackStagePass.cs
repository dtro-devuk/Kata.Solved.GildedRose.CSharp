using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.Factories.UpdateStockItemStrategy
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
        public void Factory_AgedBrie_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<BackStagePassesUpdateStrategy>(Result);
        }
    }
}
