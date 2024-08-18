namespace BackendDevStuff.Patterns.MediatorPattern.Workers;

public class Customer : AbstractWorker
{
    public Customer()
    {
        
    }

    public override void Notify(string text)
    {
        Console.WriteLine($"Message to customer: {text}");
    }
}
