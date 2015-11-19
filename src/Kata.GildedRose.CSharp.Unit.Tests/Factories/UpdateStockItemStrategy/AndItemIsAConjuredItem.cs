﻿using Kata.GildedRose.CSharp.Domain;
using NUnit.Framework;

namespace Kata.GildedRose.CSharp.Unit.Tests.Factories.UpdateStockItemStrategy
{
    [TestFixture]
    public class AndItemIsAConjuredItem : WhenTestingTheFactory
    {
        protected override void Setup()
        {
            ActualName = "Conjured Mana Cake";
            base.Setup();
        }

        [Test]
        public void Factory_ConjuredItem_ItShouldReturnTheCorrectStrategy()
        {
            ArrangeAndAct();
            Assert.IsNotInstanceOf<StandardItemsUpdateStrategy>(Result);
        }
    }
}
