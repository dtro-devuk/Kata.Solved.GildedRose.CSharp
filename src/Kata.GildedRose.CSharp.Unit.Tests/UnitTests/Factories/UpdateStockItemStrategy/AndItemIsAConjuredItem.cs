using Kata.GildedRose.CSharp.Domain.Strategies;
using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public class AndItemIsAConjuredItem : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "Conjured Mana Cake";
            base.Setup();
        }

        [Test]
        public void Factory_ConjuredItem_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsNotInstanceOf<StandardItemsUpdateStrategy>(Result);
        }
    }
}
