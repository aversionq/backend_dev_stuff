namespace BackendDevStuff.Patterns.Singleton;

public class SingletonClass
{
    private static readonly SingletonClass _instance = new SingletonClass();

    private SingletonClass()
    {
        
    }

    public static SingletonClass GetInstance()
    {
        return _instance;
    }
}
