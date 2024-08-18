using BackendDevStuff.Patterns.StrategyPattern.Strategies;

namespace BackendDevStuff.Patterns.StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // could be injected with DI
            IDoSomethingStrategy doer = new SomethingDoerA();
            Console.WriteLine(doer.GetIntNumber());

            doer = new SomethingDoerB();
            Console.WriteLine(doer.GetIntNumber());
        }
    }
}
