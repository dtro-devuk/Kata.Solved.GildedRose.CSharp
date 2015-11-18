using Kata.GildedRose.CSharp.Common.Testing.Builders;
using Kata.GildedRose.CSharp.Console;
using Kata.GildedRose.CSharp.Domain;
using System.Collections.Generic;

namespace Kata.GildedRose.CSharp.Common.Testing
{
    public abstract class WhenTestingTheGildedRoseProgram : WhenTestingTheBehaviourOfSomething
    {
        //Item under test
        protected Program GildedRoseConsole { get; set; }

        protected Item StockItemUnderTest { get; set; }
        protected List<Item> StockItemsUnderTest { get; set; }
        protected string ActualName { get; set; }
        protected int ActualSellinValue { get; set; }
        protected int ActualQualityValue { get; set; }
        protected int ExpectedQualityValue { get; set; }

        public WhenTestingTheGildedRoseProgram()
        {
            GildedRoseConsole = new Program();
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
