using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Domain;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Strategies.AgedBrie
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

            StrategyUnderTest = new AgedBrieUpdateStrategy();
        }

        protected override void ArrangeAndAct()
        {
            base.ArrangeAndAct();
        }
    }
}
