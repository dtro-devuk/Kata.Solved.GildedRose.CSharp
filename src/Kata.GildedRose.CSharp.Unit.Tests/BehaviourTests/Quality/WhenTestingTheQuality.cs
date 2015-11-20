using Kata.GildedRose.CSharp.Common.Testing;
using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Console;
using Kata.GildedRose.CSharp.ConsoleApp.Ninject;
using Kata.GildedRose.CSharp.Domain;
using Kata.GildedRose.CSharp.Domain.Factory;
using Rhino.Mocks;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Unit.Tests.BehaviourTests.Quality
{
    public abstract class WhenTestingTheQuality : WhenTestingTheBehaviourOfSomething
    {
        //Item under test
        protected Program GildedRoseConsole { get; set; }

        protected Item StockItemUnderTest { get; set; }
        protected List<Item> StockItemsUnderTest { get; set; }
        protected string ActualName { get; set; }
        protected int ActualSellinValue { get; set; }
        protected int ActualQualityValue { get; set; }
        protected int ExpectedQualityValue { get; set; }
        
        protected IUpdateItemStrategyFactory MockStrategyFactory { get; set; }

        public WhenTestingTheQuality()
        {
            var ioc = new Ioc();
            var updateStrategyFactory = ioc.Resolve<IUpdateItemStrategyFactory>();
            GildedRoseConsole = new Program(updateStrategyFactory);
            //GildedRoseConsole.SetUpdateItemStrategyFactory(updateStrategyFactory);

        }

        protected override void Setup()
        {
            //Some defaults 
            StockItemUnderTest = ItemBuilder.Build.AnInstance();
            StockItemsUnderTest = new List<Item> { StockItemUnderTest };
            GildedRoseConsole.Items = StockItemsUnderTest;
        }

        protected override void ArrangeAndAct()
        {
            Setup();
            GildedRoseConsole.UpdateQuality();
        }

        public Item GetFirstItemInInventory()
        {
            return GildedRoseConsole.Items[0];
        }
    }
}
