using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain.Strategies;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Strategies.Conjured
{
    public class AndUpdateItemIsCalled : WhenTestingTheStrategy
    {
        protected override void Setup()
        {
            StockItem = ItemBuilder
                .Build
                .WithQuality(ActualQualityValue)
                .WithSellin(ActualSellinValue)
                .AnInstance();

            StrategyUnderTest = new ConjuredUpdateStrategy();
        }

        protected override void ArrangeAndAct()
        {
            base.ArrangeAndAct();
        }
    }
}
