﻿using Kata.GildedRose.CSharp.Domain.Strategies;
using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public class AndItemIsALegend : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "Sulfuras, Hand of Ragnaros";
            base.Setup();
        }

        [Test]
        public void Factory_Legend_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<LegendaryItemsUpdateStratgey>(Result);
        }
    }
}
