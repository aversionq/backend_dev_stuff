using BackendDevStuff.Patterns.FactoryMethod.Creators;

namespace BackendDevStuff.Patterns.FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // could be injected with DI for example
            AbstractCreator creator = new ConcreteCreatorA();
            Console.WriteLine(creator.GetType());
            var productA = creator.CreateProduct();
            Console.WriteLine(productA.Name);
            Console.WriteLine(productA.GetType());

            creator = new ConcreteCreatorB();
            Console.WriteLine(creator.GetType());
            var productB = creator.CreateProduct();
            Console.WriteLine(productB.Name);
            Console.WriteLine(productB.GetType());
        }
    }
}
