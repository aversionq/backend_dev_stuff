using BackendDevStuff.Patterns.FactoryMethod.Products;

namespace BackendDevStuff.Patterns.FactoryMethod.Creators;

public class ConcreteCreatorA : AbstractCreator
{
    public override AbstractProduct CreateProduct() => new ConcreteProductA();
}
