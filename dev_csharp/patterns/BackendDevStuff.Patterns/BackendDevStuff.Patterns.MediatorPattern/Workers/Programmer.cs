namespace BackendDevStuff.Patterns.MediatorPattern.Workers;

public class Programmer : AbstractWorker
{
    public Programmer()
    {
        
    }

    public override void Notify(string text)
    {
        Console.WriteLine($"Message to programmer: {text}");
    }
}
