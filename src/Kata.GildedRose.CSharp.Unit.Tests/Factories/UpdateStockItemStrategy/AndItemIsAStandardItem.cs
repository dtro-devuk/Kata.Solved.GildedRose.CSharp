using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public class AndItemIsAStandardItem : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "A normal item";
            base.Setup();
        }

        [Test]
        public void Factory_StandardItems_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<StandardItemsUpdateStrategy>(Result);
        }
    }
}
