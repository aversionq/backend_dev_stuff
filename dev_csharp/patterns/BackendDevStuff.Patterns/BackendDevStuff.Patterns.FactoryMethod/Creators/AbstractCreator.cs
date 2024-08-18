using BackendDevStuff.Patterns.FactoryMethod.Products;

namespace BackendDevStuff.Patterns.FactoryMethod.Creators;

public abstract class AbstractCreator
{
    public abstract AbstractProduct CreateProduct();
}
