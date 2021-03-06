﻿using Kata.GildedRose.CSharp.Domain.Strategies;
using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.UnitTests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public class AndItemIsAgedBrie : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "Aged Brie";
            base.Setup();
        }

        [Test]
        public void Factory_AgedBrie_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsInstanceOf<AgedBrieUpdateStrategy>(Result);
        }
    }
}
