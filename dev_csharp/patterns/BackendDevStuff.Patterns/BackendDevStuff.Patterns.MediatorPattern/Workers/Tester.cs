namespace BackendDevStuff.Patterns.MediatorPattern.Workers;

public class Tester : AbstractWorker
{
    public Tester()
    {
        
    }

    public override void Notify(string text)
    {
        Console.WriteLine($"Message to Tester: {text}");
    }
}
