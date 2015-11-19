using Kata.GildedRose.CSharp.Common.Testing;
using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;
using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain.Factory;

namespace Kata.GildedRose.CSharp.Unit.Tests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public abstract class WhenTestingTheFactory : WhenTestingTheBehaviourOfSomething
    {
        protected IUpdateItemStrategyFactory Factory { get; set; }
        protected IStockItemUpdateStrategy Result { get; set; }
        protected Item StockItem { get; set; }
        protected string ActualName;

        protected override void Setup()
        {
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
