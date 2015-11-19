using Kata.GildedRose.CSharp.Common.Testing;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using Kata.GildedRose.CSharp.Common.Testing.Builders;

namespace Kata.GildedRose.CSharp.Unit.Tests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public class WhenTestingSomething : WhenTestingTheBehaviourOfSomething
    {
        IStockItemUpdateStrategy strategy;
        Item StockItem;

        protected override void Setup()
        {
            StockItem = ItemBuilder
                .Build
                .AnInstance();
        }

        protected override void ArrangeAndAct()
        {
            IUpdateItemStrategyFactory factory = new UpdateItemStrategyFactory();
            strategy = factory.Create(StockItem);
        }

        [Test]
        public void Factory_ItShouldReturnTheAStrategyType()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<IStockItemUpdateStrategy>(strategy);
        }

        [Test]
        public void Factory_ItShouldReturnABackStagePassStrategy()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<BackStagePassesUpdateStrategy>(strategy);
        }
    }   
}
