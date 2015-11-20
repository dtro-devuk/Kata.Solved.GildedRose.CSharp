namespace Kata.GildedRose.CSharp.ConsoleApp.Ninject
{
    public interface IIocGateway
    {
        T Resolve<T>();
    }
}