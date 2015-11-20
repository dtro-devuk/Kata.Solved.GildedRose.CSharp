using Kata.GildedRose.CSharp.Domain.Strategies;
using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public class AndItemIsAStandardItem : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            base.Setup();
        }

        [TestCase("A normal item")]
        [TestCase("+5 Dexterity Vest")]
        [TestCase("")]
        public void Factory_StandardItems_ItShouldReturnTheCorrectStrategy(string itemName)
        {
            ActualName = itemName;
            ArrangeAndAct();
            Assert.IsInstanceOf<StandardItemsUpdateStrategy>(Result);
        }
    }
}
