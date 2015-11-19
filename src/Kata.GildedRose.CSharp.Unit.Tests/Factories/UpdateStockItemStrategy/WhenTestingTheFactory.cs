using Kata.GildedRose.CSharp.Common.Testing;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain.Factory;

namespace Kata.GildedRose.CSharp.Unit.Tests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public class WhenTestingSomething : WhenTestingTheBehaviourOfSomething
    {
        IUpdateItemStrategyFactory factory;
        IStockItemUpdateStrategy strategy;
        Item StockItem;
        string ActualName;

        protected override void Setup()
        {
            StockItem = ItemBuilder
                .Build
                .WithName(ActualName)
                .AnInstance();

            factory = new UpdateItemStrategyFactory();
        }

        protected override void ArrangeAndAct()
        {
            Setup();
            
            strategy = factory.Create(StockItem);
        }

        [Test]
        public void ItShouldReturnTheAStrategyType()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<IStockItemUpdateStrategy>(strategy);
        }

        [Test]
        public void ItShouldReturnTheCorrectStrategy()
        {
            ActualName = "Backstage passes to a TAFKAL80ETC concert";
            ArrangeAndAct();
            Assert.IsInstanceOf<BackStagePassesUpdateStrategy>(strategy);
        }
    }   
}
