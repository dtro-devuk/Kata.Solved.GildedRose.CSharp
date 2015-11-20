using Kata.GildedRose.CSharp.Common.Testing;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain.Factory;
using Kata.GildedRose.CSharp.Domain.Strategies;
using Rhino.Mocks;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public abstract class WhenTestingTheFactory : WhenTestingTheBehaviourOfSomething
    {
        protected IUpdateItemStrategyFactory Factory { get; set; }
        protected IStockItemUpdateStrategy Result { get; set; }
        protected Item StockItem { get; set; }
        protected string ActualName;

        protected IUpdateItemStrategyFactory MockStrategyFactory { get; set; }

        protected override void Setup()
        {
            MockStrategyFactory = MockRepository.GenerateStub<IUpdateItemStrategyFactory>();

            StockItem = ItemBuilder
                .Build
                .WithName(ActualName)
                .AnInstance();

            Factory = new UpdateItemStrategyFactory();
        }

        protected override void ArrangeAndAct()
        {
            Setup();
            Result = Factory.Create(StockItem);
        }
    }   
}
