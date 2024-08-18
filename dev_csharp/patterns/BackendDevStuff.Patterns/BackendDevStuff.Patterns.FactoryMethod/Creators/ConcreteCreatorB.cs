using BackendDevStuff.Patterns.FactoryMethod.Products;

namespace BackendDevStuff.Patterns.FactoryMethod.Creators;

public class ConcreteCreatorB : AbstractCreator
{
    public override AbstractProduct CreateProduct() => new ConcreteProductB();
}
